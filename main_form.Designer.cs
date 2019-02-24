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
            this.app_nameLbl = new System.Windows.Forms.Label();
            this.app_nameTxtBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dllLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // app_nameLbl
            // 
            this.app_nameLbl.AutoSize = true;
            this.app_nameLbl.Location = new System.Drawing.Point(49, 27);
            this.app_nameLbl.Name = "app_nameLbl";
            this.app_nameLbl.Size = new System.Drawing.Size(90, 13);
            this.app_nameLbl.TabIndex = 0;
            this.app_nameLbl.Text = "Application Name";
            // 
            // app_nameTxtBox
            // 
            this.app_nameTxtBox.Location = new System.Drawing.Point(52, 43);
            this.app_nameTxtBox.Name = "app_nameTxtBox";
            this.app_nameTxtBox.Size = new System.Drawing.Size(114, 20);
            this.app_nameTxtBox.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dllLabel
            // 
            this.dllLabel.AutoSize = true;
            this.dllLabel.Location = new System.Drawing.Point(49, 91);
            this.dllLabel.Name = "dllLabel";
            this.dllLabel.Size = new System.Drawing.Size(71, 13);
            this.dllLabel.TabIndex = 2;
            this.dllLabel.Text = "DLL Location";
            this.dllLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Inject";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 196);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dllLabel);
            this.Controls.Add(this.app_nameTxtBox);
            this.Controls.Add(this.app_nameLbl);
            this.Name = "main_form";
            this.Text = "DLL Injector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label app_nameLbl;
        private System.Windows.Forms.TextBox app_nameTxtBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label dllLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

