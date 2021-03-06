﻿namespace BackupMonitor
{
    partial class frmTypes
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
            this.txtTypes = new System.Windows.Forms.TextBox();
            this.lblHelpString = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblHelpItemName = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTypes
            // 
            this.txtTypes.Location = new System.Drawing.Point(12, 12);
            this.txtTypes.Name = "txtTypes";
            this.txtTypes.Size = new System.Drawing.Size(252, 20);
            this.txtTypes.TabIndex = 0;
            this.txtTypes.TextChanged += new System.EventHandler(this.txtTypes_TextChanged);
            this.txtTypes.MouseEnter += new System.EventHandler(this.txtTypes_MouseEnter);
            this.txtTypes.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // lblHelpString
            // 
            this.lblHelpString.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblHelpString.Margin = new System.Windows.Forms.Padding(0, 5, 0, 2);
            this.lblHelpString.Name = "lblHelpString";
            this.lblHelpString.Size = new System.Drawing.Size(60, 15);
            this.lblHelpString.Text = "context help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHelpItemName,
            this.lblHelpString});
            this.statusStrip1.Location = new System.Drawing.Point(0, 42);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(359, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblHelpItemName
            // 
            this.lblHelpItemName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblHelpItemName.Name = "lblHelpItemName";
            this.lblHelpItemName.Size = new System.Drawing.Size(30, 17);
            this.lblHelpItemName.Text = "item";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(272, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.control_MouseLeave);
            // 
            // frmTypes
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 64);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTypes";
            this.Text = "Edit File Types";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTypes;
        private System.Windows.Forms.ToolStripStatusLabel lblHelpString;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblHelpItemName;
        private System.Windows.Forms.Button btnSave;
    }
}