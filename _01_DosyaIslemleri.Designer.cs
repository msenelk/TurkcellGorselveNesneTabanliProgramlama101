namespace TurkcellGorselveNesneTabanliProgramlama201
{
    partial class _01_DosyaIslemleri
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnFolderBrowserDialog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOpenFileDialog = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnSaveFileDialog = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // BtnFolderBrowserDialog
            // 
            this.BtnFolderBrowserDialog.Location = new System.Drawing.Point(674, 29);
            this.BtnFolderBrowserDialog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnFolderBrowserDialog.Name = "BtnFolderBrowserDialog";
            this.BtnFolderBrowserDialog.Size = new System.Drawing.Size(215, 47);
            this.BtnFolderBrowserDialog.TabIndex = 0;
            this.BtnFolderBrowserDialog.Text = "Folder Browser Dialog";
            this.BtnFolderBrowserDialog.UseVisualStyleBackColor = true;
            this.BtnFolderBrowserDialog.Click += new System.EventHandler(this.BtnFolderBrowserDialog_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // BtnOpenFileDialog
            // 
            this.BtnOpenFileDialog.Location = new System.Drawing.Point(674, 114);
            this.BtnOpenFileDialog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnOpenFileDialog.Name = "BtnOpenFileDialog";
            this.BtnOpenFileDialog.Size = new System.Drawing.Size(215, 47);
            this.BtnOpenFileDialog.TabIndex = 2;
            this.BtnOpenFileDialog.Text = "Open File Dialog";
            this.BtnOpenFileDialog.UseVisualStyleBackColor = true;
            this.BtnOpenFileDialog.Click += new System.EventHandler(this.BtnOpenFileDialog_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnSaveFileDialog
            // 
            this.BtnSaveFileDialog.Location = new System.Drawing.Point(674, 203);
            this.BtnSaveFileDialog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSaveFileDialog.Name = "BtnSaveFileDialog";
            this.BtnSaveFileDialog.Size = new System.Drawing.Size(215, 47);
            this.BtnSaveFileDialog.TabIndex = 3;
            this.BtnSaveFileDialog.Text = "Save File Dialog";
            this.BtnSaveFileDialog.UseVisualStyleBackColor = true;
            this.BtnSaveFileDialog.Click += new System.EventHandler(this.BtnSaveFileDialog_Click);
            // 
            // _01_DosyaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 482);
            this.Controls.Add(this.BtnSaveFileDialog);
            this.Controls.Add(this.BtnOpenFileDialog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFolderBrowserDialog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "_01_DosyaIslemleri";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button BtnFolderBrowserDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnSaveFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

