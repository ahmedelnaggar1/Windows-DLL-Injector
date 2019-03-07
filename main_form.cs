using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLL_Injector
{
    public partial class main_form : Form
    {
        public main_form()
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
    }
}
