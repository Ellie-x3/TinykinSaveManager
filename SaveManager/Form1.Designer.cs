namespace SaveManager
{
    partial class frmSave
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblApplied = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(223, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(12, 94);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(223, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblApplied
            // 
            this.lblApplied.AutoSize = true;
            this.lblApplied.Location = new System.Drawing.Point(65, 120);
            this.lblApplied.Name = "lblApplied";
            this.lblApplied.Size = new System.Drawing.Size(0, 15);
            this.lblApplied.TabIndex = 4;
            this.lblApplied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 141);
            this.Controls.Add(this.lblApplied);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnBrowse);
            this.Name = "frmSave";
            this.Text = "SaveManager Tinykin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBrowse;
        private FolderBrowserDialog folderBrowserDialog1;
        private ComboBox comboBox1;
        private Button btnApply;
        private Label lblApplied;
    }
}