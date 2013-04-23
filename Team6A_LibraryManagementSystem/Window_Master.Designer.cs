namespace Team6A_LibraryManagementSystem
{
    partial class Window_Master
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lendBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberLastRentedBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersConsumePieChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(1, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(788, 416);
            this.panelMain.TabIndex = 0;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.lendBookToolStripMenuItem1,
            this.viewToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(793, 26);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip2";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.memberToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(41, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Image = global::Team6A_LibraryManagementSystem.Properties.Resources.book_add;
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.bookToolStripMenuItem.Text = "Add Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.Image = global::Team6A_LibraryManagementSystem.Properties.Resources.user_add;
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.memberToolStripMenuItem.Text = "Add Member";
            this.memberToolStripMenuItem.Click += new System.EventHandler(this.memberToolStripMenuItem_Click);
            // 
            // lendBookToolStripMenuItem1
            // 
            this.lendBookToolStripMenuItem1.Image = global::Team6A_LibraryManagementSystem.Properties.Resources.book_go;
            this.lendBookToolStripMenuItem1.Name = "lendBookToolStripMenuItem1";
            this.lendBookToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
            this.lendBookToolStripMenuItem1.Text = "Lend Book";
            this.lendBookToolStripMenuItem1.Click += new System.EventHandler(this.lendBookToolStripMenuItem1_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem1,
            this.memberToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(42, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // bookToolStripMenuItem1
            // 
            this.bookToolStripMenuItem1.Image = global::Team6A_LibraryManagementSystem.Properties.Resources.book;
            this.bookToolStripMenuItem1.Name = "bookToolStripMenuItem1";
            this.bookToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.bookToolStripMenuItem1.Text = "Book List";
            this.bookToolStripMenuItem1.Click += new System.EventHandler(this.bookToolStripMenuItem1_Click);
            // 
            // memberToolStripMenuItem1
            // 
            this.memberToolStripMenuItem1.Image = global::Team6A_LibraryManagementSystem.Properties.Resources.user;
            this.memberToolStripMenuItem1.Name = "memberToolStripMenuItem1";
            this.memberToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.memberToolStripMenuItem1.Text = "Member List";
            this.memberToolStripMenuItem1.Click += new System.EventHandler(this.memberToolStripMenuItem1_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthlyReportToolStripMenuItem,
            this.membersConsumePieChartToolStripMenuItem,
            this.memberLastRentedBookToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // monthlyReportToolStripMenuItem
            // 
            this.monthlyReportToolStripMenuItem.Image = global::Team6A_LibraryManagementSystem.Properties.Resources.report;
            this.monthlyReportToolStripMenuItem.Name = "monthlyReportToolStripMenuItem";
            this.monthlyReportToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.monthlyReportToolStripMenuItem.Text = "Members Consume";
            this.monthlyReportToolStripMenuItem.Click += new System.EventHandler(this.monthlyReportToolStripMenuItem_Click);
            // 
            // memberLastRentedBookToolStripMenuItem
            // 
            this.memberLastRentedBookToolStripMenuItem.Image = global::Team6A_LibraryManagementSystem.Properties.Resources.report;
            this.memberLastRentedBookToolStripMenuItem.Name = "memberLastRentedBookToolStripMenuItem";
            this.memberLastRentedBookToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.memberLastRentedBookToolStripMenuItem.Text = "Members Last Rented Book";
            this.memberLastRentedBookToolStripMenuItem.Click += new System.EventHandler(this.memberLastRentedBookToolStripMenuItem_Click);
            // 
            // membersConsumePieChartToolStripMenuItem
            // 
            this.membersConsumePieChartToolStripMenuItem.Image = global::Team6A_LibraryManagementSystem.Properties.Resources.report;
            this.membersConsumePieChartToolStripMenuItem.Name = "membersConsumePieChartToolStripMenuItem";
            this.membersConsumePieChartToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.membersConsumePieChartToolStripMenuItem.Text = "Members Consume (Pie Chart)";
            this.membersConsumePieChartToolStripMenuItem.Click += new System.EventHandler(this.membersConsumePieChartToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(41, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Image = global::Team6A_LibraryManagementSystem.Properties.Resources.help;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Team6A_LibraryManagementSystem.Properties.Resources._6A;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Window_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 455);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.MainMenu);
            this.MaximizeBox = false;
            this.Name = "Window_Master";
            this.Text = "Library Management System (Team 6A)";
            this.Load += new System.EventHandler(this.Window_Master_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem memberLastRentedBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersConsumePieChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lendBookToolStripMenuItem1;
    }
}

