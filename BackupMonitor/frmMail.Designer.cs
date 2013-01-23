namespace BackupMonitor
{
    partial class frmMail
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
            this.txtMailList = new System.Windows.Forms.TextBox();
            this.btnSaveMail = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblHelpItemName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHelpString = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMailList
            // 
            this.txtMailList.Location = new System.Drawing.Point(12, 12);
            this.txtMailList.Multiline = true;
            this.txtMailList.Name = "txtMailList";
            this.txtMailList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMailList.Size = new System.Drawing.Size(317, 67);
            this.txtMailList.TabIndex = 0;
            this.txtMailList.MouseEnter += new System.EventHandler(this.txtMailList_MouseEnter);
            this.txtMailList.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // btnSaveMail
            // 
            this.btnSaveMail.Location = new System.Drawing.Point(107, 85);
            this.btnSaveMail.Name = "btnSaveMail";
            this.btnSaveMail.Size = new System.Drawing.Size(113, 23);
            this.btnSaveMail.TabIndex = 1;
            this.btnSaveMail.Text = "Save Mailing List";
            this.btnSaveMail.UseVisualStyleBackColor = true;
            this.btnSaveMail.MouseEnter += new System.EventHandler(this.btnSaveMail_MouseEnter);
            this.btnSaveMail.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHelpItemName,
            this.lblHelpString});
            this.statusStrip1.Location = new System.Drawing.Point(0, 115);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(339, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblHelpItemName
            // 
            this.lblHelpItemName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblHelpItemName.Name = "lblHelpItemName";
            this.lblHelpItemName.Size = new System.Drawing.Size(30, 17);
            this.lblHelpItemName.Text = "item";
            // 
            // lblHelpString
            // 
            this.lblHelpString.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblHelpString.Margin = new System.Windows.Forms.Padding(0, 5, 0, 2);
            this.lblHelpString.Name = "lblHelpString";
            this.lblHelpString.Size = new System.Drawing.Size(60, 15);
            this.lblHelpString.Text = "context help";
            // 
            // frmMail
            // 
            this.AcceptButton = this.btnSaveMail;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 137);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSaveMail);
            this.Controls.Add(this.txtMailList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMail";
            this.Text = "Edit Mailing List";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMailList;
        private System.Windows.Forms.Button btnSaveMail;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblHelpItemName;
        private System.Windows.Forms.ToolStripStatusLabel lblHelpString;
    }
}