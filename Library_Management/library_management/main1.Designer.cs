namespace library_management
{
    partial class main1
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.bookInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBookEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayStoreRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printBookRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookISSueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBookIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchIssueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.searchIssueBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 519);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1215, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookInformationToolStripMenuItem,
            this.bookISSueToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1215, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // bookInformationToolStripMenuItem
            // 
            this.bookInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBookEntryToolStripMenuItem,
            this.searchBookToolStripMenuItem,
            this.displayStoreRecordToolStripMenuItem,
            this.printBookRecordToolStripMenuItem});
            this.bookInformationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bookInformationToolStripMenuItem.Name = "bookInformationToolStripMenuItem";
            this.bookInformationToolStripMenuItem.Size = new System.Drawing.Size(139, 23);
            this.bookInformationToolStripMenuItem.Text = "Book Information";
            // 
            // newBookEntryToolStripMenuItem
            // 
            this.newBookEntryToolStripMenuItem.Name = "newBookEntryToolStripMenuItem";
            this.newBookEntryToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.newBookEntryToolStripMenuItem.Text = "New Book Entry";
            this.newBookEntryToolStripMenuItem.Click += new System.EventHandler(this.newBookEntryToolStripMenuItem_Click);
            // 
            // searchBookToolStripMenuItem
            // 
            this.searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            this.searchBookToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.searchBookToolStripMenuItem.Text = "Search Book";
            this.searchBookToolStripMenuItem.Click += new System.EventHandler(this.searchBookToolStripMenuItem_Click);
            // 
            // displayStoreRecordToolStripMenuItem
            // 
            this.displayStoreRecordToolStripMenuItem.Name = "displayStoreRecordToolStripMenuItem";
            this.displayStoreRecordToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.displayStoreRecordToolStripMenuItem.Text = "Display Store Record";
            this.displayStoreRecordToolStripMenuItem.Click += new System.EventHandler(this.displayStoreRecordToolStripMenuItem_Click);
            // 
            // printBookRecordToolStripMenuItem
            // 
            this.printBookRecordToolStripMenuItem.Name = "printBookRecordToolStripMenuItem";
            this.printBookRecordToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.printBookRecordToolStripMenuItem.Text = "Print Book Record";
            this.printBookRecordToolStripMenuItem.Click += new System.EventHandler(this.printBookRecordToolStripMenuItem_Click);
            // 
            // bookISSueToolStripMenuItem
            // 
            this.bookISSueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBookIssueToolStripMenuItem,
            this.searchIssueBookToolStripMenuItem,
            this.searchIssueBookToolStripMenuItem1});
            this.bookISSueToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bookISSueToolStripMenuItem.Name = "bookISSueToolStripMenuItem";
            this.bookISSueToolStripMenuItem.Size = new System.Drawing.Size(92, 23);
            this.bookISSueToolStripMenuItem.Text = "Book Issue";
            // 
            // newBookIssueToolStripMenuItem
            // 
            this.newBookIssueToolStripMenuItem.Name = "newBookIssueToolStripMenuItem";
            this.newBookIssueToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.newBookIssueToolStripMenuItem.Text = "New Book Issue";
            this.newBookIssueToolStripMenuItem.Click += new System.EventHandler(this.newBookIssueToolStripMenuItem_Click);
            // 
            // searchIssueBookToolStripMenuItem
            // 
            this.searchIssueBookToolStripMenuItem.Name = "searchIssueBookToolStripMenuItem";
            this.searchIssueBookToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.searchIssueBookToolStripMenuItem.Text = "Display Issue Book";
            this.searchIssueBookToolStripMenuItem.Click += new System.EventHandler(this.searchIssueBookToolStripMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(1047, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 17);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // searchIssueBookToolStripMenuItem1
            // 
            this.searchIssueBookToolStripMenuItem1.Name = "searchIssueBookToolStripMenuItem1";
            this.searchIssueBookToolStripMenuItem1.Size = new System.Drawing.Size(202, 24);
            this.searchIssueBookToolStripMenuItem1.Text = "Search Issue Book";
            this.searchIssueBookToolStripMenuItem1.Click += new System.EventHandler(this.searchIssueBookToolStripMenuItem1_Click);
            // 
            // main1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 541);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "main1";
            this.Text = "main1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem bookInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBookEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayStoreRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookISSueToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripMenuItem newBookIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchIssueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printBookRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchIssueBookToolStripMenuItem1;
    }
}



