namespace BackupMonitor
{
    partial class frmFolder
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblHelpItemName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHelpString = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chkBoxSubdirectories = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnSaveFolder = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHelpItemName,
            this.lblHelpString});
            this.statusStrip1.Location = new System.Drawing.Point(0, 69);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(405, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblHelpItemName
            // 
            this.lblHelpItemName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpItemName.Name = "lblHelpItemName";
            this.lblHelpItemName.Size = new System.Drawing.Size(33, 17);
            this.lblHelpItemName.Text = "item";
            // 
            // lblHelpString
            // 
            this.lblHelpString.Name = "lblHelpString";
            this.lblHelpString.Size = new System.Drawing.Size(72, 17);
            this.lblHelpString.Text = "context help";
            // 
            // chkBoxSubdirectories
            // 
            this.chkBoxSubdirectories.AutoSize = true;
            this.chkBoxSubdirectories.Location = new System.Drawing.Point(12, 38);
            this.chkBoxSubdirectories.Name = "chkBoxSubdirectories";
            this.chkBoxSubdirectories.Size = new System.Drawing.Size(135, 17);
            this.chkBoxSubdirectories.TabIndex = 2;
            this.chkBoxSubdirectories.Text = "Include subdirectories?";
            this.chkBoxSubdirectories.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(334, 9);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(59, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(13, 12);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(315, 20);
            this.txtFolderPath.TabIndex = 4;
            // 
            // btnSaveFolder
            // 
            this.btnSaveFolder.Location = new System.Drawing.Point(172, 34);
            this.btnSaveFolder.Name = "btnSaveFolder";
            this.btnSaveFolder.Size = new System.Drawing.Size(59, 23);
            this.btnSaveFolder.TabIndex = 5;
            this.btnSaveFolder.Text = "Save";
            this.btnSaveFolder.UseVisualStyleBackColor = true;
            // 
            // frmFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 91);
            this.Controls.Add(this.btnSaveFolder);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.chkBoxSubdirectories);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFolder";
            this.Text = "Add Folder to Monitor";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblHelpItemName;
        private System.Windows.Forms.ToolStripStatusLabel lblHelpString;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox chkBoxSubdirectories;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnSaveFolder;
    }
}