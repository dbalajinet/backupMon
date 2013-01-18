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
            this.btnMailList = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHelpItemName,
            this.lblHelpString});
            this.statusStrip1.Location = new System.Drawing.Point(0, 159);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(260, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblHelpItemName
            // 
            this.lblHelpItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpItemName.Name = "lblHelpItemName";
            this.lblHelpItemName.Size = new System.Drawing.Size(27, 17);
            this.lblHelpItemName.Text = "item";
            // 
            // lblHelpString
            // 
            this.lblHelpString.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpString.Name = "lblHelpString";
            this.lblHelpString.Size = new System.Drawing.Size(55, 17);
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
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servers";
            // 
            // btnRemServer
            // 
            this.btnRemServer.Location = new System.Drawing.Point(148, 79);
            this.btnRemServer.Name = "btnRemServer";
            this.btnRemServer.Size = new System.Drawing.Size(75, 23);
            this.btnRemServer.TabIndex = 3;
            this.btnRemServer.Text = "&Remove";
            this.btnRemServer.UseVisualStyleBackColor = true;
            this.btnRemServer.MouseEnter += new System.EventHandler(this.btnRemServer_MouseEnter);
            this.btnRemServer.MouseLeave += new System.EventHandler(this.btnRemServer_MouseLeave);
            // 
            // btnEditServer
            // 
            this.btnEditServer.Location = new System.Drawing.Point(148, 49);
            this.btnEditServer.Name = "btnEditServer";
            this.btnEditServer.Size = new System.Drawing.Size(75, 23);
            this.btnEditServer.TabIndex = 2;
            this.btnEditServer.Text = "&Edit";
            this.btnEditServer.UseVisualStyleBackColor = true;
            this.btnEditServer.MouseEnter += new System.EventHandler(this.btnEditServer_MouseEnter);
            this.btnEditServer.MouseLeave += new System.EventHandler(this.btnEditServer_MouseLeave);
            // 
            // btnAddServer
            // 
            this.btnAddServer.Location = new System.Drawing.Point(148, 19);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(75, 23);
            this.btnAddServer.TabIndex = 0;
            this.btnAddServer.Text = "&New";
            this.btnAddServer.UseVisualStyleBackColor = true;
            this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            this.btnAddServer.MouseEnter += new System.EventHandler(this.btnAddServer_MouseEnter);
            this.btnAddServer.MouseLeave += new System.EventHandler(this.btnAddServer_MouseLeave);
            // 
            // btnMailList
            // 
            this.btnMailList.Location = new System.Drawing.Point(71, 131);
            this.btnMailList.Name = "btnMailList";
            this.btnMailList.Size = new System.Drawing.Size(120, 23);
            this.btnMailList.TabIndex = 1;
            this.btnMailList.Text = "Edit &Mailing List";
            this.btnMailList.UseVisualStyleBackColor = true;
            this.btnMailList.Click += new System.EventHandler(this.btnMailList_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 181);
            this.Controls.Add(this.btnMailList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Backup Monitor";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnMailList;
    }
}

