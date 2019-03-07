namespace DLL_Injector
{
    partial class main_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.injectBtn = new System.Windows.Forms.Button();
            this.appListBox = new System.Windows.Forms.ListBox();
            this.dllTxtBox = new System.Windows.Forms.TextBox();
            this.selectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // injectBtn
            // 
            this.injectBtn.Enabled = false;
            this.injectBtn.Location = new System.Drawing.Point(479, 216);
            this.injectBtn.Name = "injectBtn";
            this.injectBtn.Size = new System.Drawing.Size(75, 33);
            this.injectBtn.TabIndex = 0;
            this.injectBtn.Text = "Inject";
            this.injectBtn.UseVisualStyleBackColor = true;
            // 
            // appListBox
            // 
            this.appListBox.FormattingEnabled = true;
            this.appListBox.Location = new System.Drawing.Point(12, 39);
            this.appListBox.Name = "appListBox";
            this.appListBox.Size = new System.Drawing.Size(542, 173);
            this.appListBox.TabIndex = 1;
            // 
            // dllTxtBox
            // 
            this.dllTxtBox.Location = new System.Drawing.Point(12, 13);
            this.dllTxtBox.Name = "dllTxtBox";
            this.dllTxtBox.Size = new System.Drawing.Size(463, 20);
            this.dllTxtBox.TabIndex = 2;
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(481, 11);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(73, 23);
            this.selectBtn.TabIndex = 3;
            this.selectBtn.Text = "Select DLL";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 272);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.dllTxtBox);
            this.Controls.Add(this.appListBox);
            this.Controls.Add(this.injectBtn);
            this.Name = "main_form";
            this.Text = "DLL Injector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button injectBtn;
        private System.Windows.Forms.ListBox appListBox;
        private System.Windows.Forms.TextBox dllTxtBox;
        private System.Windows.Forms.Button selectBtn;
    }
}

