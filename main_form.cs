using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLL_Injector
{
    public partial class mainForm : Form
    {
        // Let's import all required methods from kernel32.dll
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        // Required privileges
        const int PROCESS_CREATE_THREAD     = 0x0002;
        const int PROCESS_QUERY_INFORMATION = 0x0400;
        const int PROCESS_VM_OPERATION      = 0x0008;
        const int PROCESS_VM_WRITE          = 0x0020;
        const int PROCESS_VM_READ           = 0x0010;

        const uint MEM_COMMIT               = 0x00001000;
        const uint MEM_RESERVE              = 0x00002000;
        const uint PAGE_READWRITE           = 4;

        public mainForm()
        {
            InitializeComponent();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dllLocationDialog = new OpenFileDialog();

            dllLocationDialog.Title = "Select DLL file";

            // Allow the user to only select DLL files
            dllLocationDialog.Filter = "DLL Files (*.dll) | *.dll";

            // Show the user a file dialog and get selected file
            if (dllLocationDialog.ShowDialog() == DialogResult.OK)
            {
                dllTxtBox.Text = dllLocationDialog.FileName;
            }

            //re-enable inject button
            injectBtn.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Once the application loads
            // Get a list of all current running processes
            // Show list in control appListBox

            // Get all running processes
            Process[] allProcesses = Process.GetProcesses();

            ImageList appIcons = new ImageList();
            Icon appIcon;

            appListView.SmallImageList = appIcons;

            // Add processes to appListBox
            foreach (Process process in allProcesses)
            {
                // Get the icon of the process
                // Get the critical info from the process such as name
                // Add to appListView
                try
                {
                    appIcon = Icon.ExtractAssociatedIcon(process.MainModule.FileName);

                    appIcons.Images.Add(appIcon.GetHashCode().ToString(), appIcon.ToBitmap());

                    string[] row = 
                    {
                        process.ProcessName,
                        process.Id.ToString(),
                        process.MainModule.FileName
                    };

                    ListViewItem item = new ListViewItem(row)
                    {
                        ImageKey = appIcon.GetHashCode().ToString()
                    };

                    appListView.Items.Add(item);
                }
                catch { } // Access is denied
            }
        }
    
        private void injectBtn_Click(object sender, EventArgs e)
        {
            // Get the handle of the target process
            // Store the location of the dll in the target processes' memory space
            // Using the stored location, create a thread that will run LoadLibraryA to load target DLL

            // Get target process handle
            Process targetProcess = Process.GetProcessesByName(appListView.FocusedItem.Text)[0];

            IntPtr processHandle = OpenProcess(PROCESS_CREATE_THREAD | PROCESS_QUERY_INFORMATION | PROCESS_VM_OPERATION | PROCESS_VM_READ | PROCESS_VM_WRITE,
                                   false, targetProcess.Id);

            // Get LoadLibraryA method address
            IntPtr loadLibraryAddr = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");

            string dllLocation = dllTxtBox.Text;

            // Allocate memory space into target process
            IntPtr allocatedMemoryAddress = VirtualAllocEx(processHandle, IntPtr.Zero, (uint)((dllLocation.Length + 1) * Marshal.SizeOf(typeof(char))),
                MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);

            // Write DLL location into allocated memory space
            UIntPtr bytesWritten;
            WriteProcessMemory(processHandle, allocatedMemoryAddress, Encoding.Default.GetBytes(dllLocation), (uint)((dllLocation.Length + 1) * Marshal.SizeOf(typeof(char))), out bytesWritten);

            // Create thread to execute LoadLibraryA with the DLL as a parameter
            CreateRemoteThread(processHandle, IntPtr.Zero, 0, loadLibraryAddr, allocatedMemoryAddress, 0, IntPtr.Zero);
        }

        private void creatorLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Link to GitHub
            Process.Start("https://github.com/ahmedelnaggar1");
        }
    }
}
