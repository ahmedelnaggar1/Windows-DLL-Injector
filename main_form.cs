using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLL_Injector
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dllLocationDialog = new OpenFileDialog();

            dllLocationDialog.Title = "Select DLL file";

            // Allow the user to only select DLL files
            dllLocationDialog.Filter = "DLL Files (*.dll) | *.dll";
            
            // Show the user a file dialog and get selected file
            if(dllLocationDialog.ShowDialog() == DialogResult.OK)
            {
                dllTxtBox.Text = dllLocationDialog.FileName;
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // Once the application loads
            // Get a list of all current running processes
            // Show list in List appListBox

            // Get all running processes
            Process[] allProcesses = Process.GetProcesses();
            
            // Add processes to appListBox
            foreach(Process process in allProcesses)
            {
                appListBox.Items.Add(process.ProcessName);
            }
        }
    }
}
