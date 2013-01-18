namespace BackupMonitor
{
    partial class frmMain
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
            this.lbServers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemServer = new System.Windows.Forms.Button();
            this.btnEditServer = new System.Windows.Forms.Button();
            this.btnAddServer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemEmail = new System.Windows.Forms.Button();
            this.btnEditEmail = new System.Windows.Forms.Button();
            this.btnNewEmail = new System.Windows.Forms.Button();
            this.lbEmails = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHelpItemName,
            this.lblHelpString});
            this.statusStrip1.Location = new System.Drawing.Point(0, 250);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(260, 22);
            this.statusStrip1.TabIndex = 0;
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
            // lbServers
            // 
            this.lbServers.FormattingEnabled = true;
            this.lbServers.Location = new System.Drawing.Point(9, 19);
            this.lbServers.Name = "lbServers";
            this.lbServers.Size = new System.Drawing.Size(132, 82);
            this.lbServers.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemServer);
            this.groupBox1.Controls.Add(this.btnEditServer);
            this.groupBox1.Controls.Add(this.btnAddServer);
            this.groupBox1.Controls.Add(this.lbServers);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 112);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servers";
            // 
            // btnRemServer
            // 
            this.btnRemServer.Location = new System.Drawing.Point(148, 79);
            this.btnRemServer.Name = "btnRemServer";
            this.btnRemServer.Size = new System.Drawing.Size(75, 23);
            this.btnRemServer.TabIndex = 4;
            this.btnRemServer.Text = "Remove";
            this.btnRemServer.UseVisualStyleBackColor = true;
            // 
            // btnEditServer
            // 
            this.btnEditServer.Location = new System.Drawing.Point(148, 49);
            this.btnEditServer.Name = "btnEditServer";
            this.btnEditServer.Size = new System.Drawing.Size(75, 23);
            this.btnEditServer.TabIndex = 3;
            this.btnEditServer.Text = "Edit";
            this.btnEditServer.UseVisualStyleBackColor = true;
            // 
            // btnAddServer
            // 
            this.btnAddServer.Location = new System.Drawing.Point(148, 19);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(75, 23);
            this.btnAddServer.TabIndex = 2;
            this.btnAddServer.Text = "New";
            this.btnAddServer.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemEmail);
            this.groupBox2.Controls.Add(this.btnEditEmail);
            this.groupBox2.Controls.Add(this.btnNewEmail);
            this.groupBox2.Controls.Add(this.lbEmails);
            this.groupBox2.Location = new System.Drawing.Point(13, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 112);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "E-Mails";
            // 
            // btnRemEmail
            // 
            this.btnRemEmail.Location = new System.Drawing.Point(148, 79);
            this.btnRemEmail.Name = "btnRemEmail";
            this.btnRemEmail.Size = new System.Drawing.Size(75, 23);
            this.btnRemEmail.TabIndex = 4;
            this.btnRemEmail.Text = "Remove";
            this.btnRemEmail.UseVisualStyleBackColor = true;
            // 
            // btnEditEmail
            // 
            this.btnEditEmail.Location = new System.Drawing.Point(148, 49);
            this.btnEditEmail.Name = "btnEditEmail";
            this.btnEditEmail.Size = new System.Drawing.Size(75, 23);
            this.btnEditEmail.TabIndex = 3;
            this.btnEditEmail.Text = "Edit";
            this.btnEditEmail.UseVisualStyleBackColor = true;
            // 
            // btnNewEmail
            // 
            this.btnNewEmail.Location = new System.Drawing.Point(148, 19);
            this.btnNewEmail.Name = "btnNewEmail";
            this.btnNewEmail.Size = new System.Drawing.Size(75, 23);
            this.btnNewEmail.TabIndex = 2;
            this.btnNewEmail.Text = "New";
            this.btnNewEmail.UseVisualStyleBackColor = true;
            // 
            // lbEmails
            // 
            this.lbEmails.FormattingEnabled = true;
            this.lbEmails.Location = new System.Drawing.Point(9, 19);
            this.lbEmails.Name = "lbEmails";
            this.lbEmails.Size = new System.Drawing.Size(132, 82);
            this.lbEmails.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 272);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Backup Monitor";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblHelpItemName;
        private System.Windows.Forms.ToolStripStatusLabel lblHelpString;
        private System.Windows.Forms.ListBox lbServers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemServer;
        private System.Windows.Forms.Button btnEditServer;
        private System.Windows.Forms.Button btnAddServer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemEmail;
        private System.Windows.Forms.Button btnEditEmail;
        private System.Windows.Forms.Button btnNewEmail;
        private System.Windows.Forms.ListBox lbEmails;
    }
}

