namespace UnicodePasswordGenerator
{
    partial class Form1
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
            this.UnicodeFolderChooserBTN = new System.Windows.Forms.Button();
            this.UnicodeFolderChooser = new System.Windows.Forms.FolderBrowserDialog();
            this.GenerateUnicodePasswordBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UnicodePasswordTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UnicodeFolderChooserBTN
            // 
            this.UnicodeFolderChooserBTN.Location = new System.Drawing.Point(13, 13);
            this.UnicodeFolderChooserBTN.Name = "UnicodeFolderChooserBTN";
            this.UnicodeFolderChooserBTN.Size = new System.Drawing.Size(263, 64);
            this.UnicodeFolderChooserBTN.TabIndex = 0;
            this.UnicodeFolderChooserBTN.Text = "Choose Unicode Folder";
            this.UnicodeFolderChooserBTN.UseVisualStyleBackColor = true;
            this.UnicodeFolderChooserBTN.Click += new System.EventHandler(this.UnicodeFolderChooserBTN_Click);
            // 
            // GenerateUnicodePasswordBTN
            // 
            this.GenerateUnicodePasswordBTN.Location = new System.Drawing.Point(13, 105);
            this.GenerateUnicodePasswordBTN.Name = "GenerateUnicodePasswordBTN";
            this.GenerateUnicodePasswordBTN.Size = new System.Drawing.Size(260, 66);
            this.GenerateUnicodePasswordBTN.TabIndex = 3;
            this.GenerateUnicodePasswordBTN.Text = "Generate Unicode Password";
            this.GenerateUnicodePasswordBTN.UseVisualStyleBackColor = true;
            this.GenerateUnicodePasswordBTN.Click += new System.EventHandler(this.GenerateUnicodePasswordBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Generated Unicode Password";
            // 
            // UnicodePasswordTB
            // 
            this.UnicodePasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UnicodePasswordTB.Location = new System.Drawing.Point(10, 217);
            this.UnicodePasswordTB.Multiline = true;
            this.UnicodePasswordTB.Name = "UnicodePasswordTB";
            this.UnicodePasswordTB.Size = new System.Drawing.Size(260, 78);
            this.UnicodePasswordTB.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UnicodePasswordTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GenerateUnicodePasswordBTN);
            this.Controls.Add(this.UnicodeFolderChooserBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UnicodeFolderChooserBTN;
        private System.Windows.Forms.FolderBrowserDialog UnicodeFolderChooser;
        private System.Windows.Forms.Button GenerateUnicodePasswordBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UnicodePasswordTB;
    }
}

