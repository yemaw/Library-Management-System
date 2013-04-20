namespace Team6A_LibraryManagementSystem
{
    partial class BookListForm
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
            this.txtSearchByBookID = new System.Windows.Forms.TextBox();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.btnSearchByBookID = new System.Windows.Forms.Button();
            this.gbSearchByBookID = new System.Windows.Forms.GroupBox();
            this.gbSearchBook = new System.Windows.Forms.GroupBox();
            this.llbAdvanceSearch = new System.Windows.Forms.LinkLabel();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbSearchByBookID.SuspendLayout();
            this.gbSearchBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchByBookID
            // 
            this.txtSearchByBookID.Location = new System.Drawing.Point(12, 19);
            this.txtSearchByBookID.Name = "txtSearchByBookID";
            this.txtSearchByBookID.Size = new System.Drawing.Size(131, 20);
            this.txtSearchByBookID.TabIndex = 4;
            this.txtSearchByBookID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Location = new System.Drawing.Point(15, 19);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(189, 20);
            this.txtSearchBook.TabIndex = 5;
            // 
            // btnSearchByBookID
            // 
            this.btnSearchByBookID.Location = new System.Drawing.Point(151, 19);
            this.btnSearchByBookID.Name = "btnSearchByBookID";
            this.btnSearchByBookID.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByBookID.TabIndex = 7;
            this.btnSearchByBookID.Text = "Search";
            this.btnSearchByBookID.UseVisualStyleBackColor = true;
            // 
            // gbSearchByBookID
            // 
            this.gbSearchByBookID.Controls.Add(this.txtSearchByBookID);
            this.gbSearchByBookID.Controls.Add(this.btnSearchByBookID);
            this.gbSearchByBookID.Location = new System.Drawing.Point(119, 47);
            this.gbSearchByBookID.Name = "gbSearchByBookID";
            this.gbSearchByBookID.Size = new System.Drawing.Size(240, 68);
            this.gbSearchByBookID.TabIndex = 8;
            this.gbSearchByBookID.TabStop = false;
            this.gbSearchByBookID.Text = "Search by BookID";
            // 
            // gbSearchBook
            // 
            this.gbSearchBook.Controls.Add(this.llbAdvanceSearch);
            this.gbSearchBook.Controls.Add(this.btnSearchBook);
            this.gbSearchBook.Controls.Add(this.txtSearchBook);
            this.gbSearchBook.Location = new System.Drawing.Point(385, 27);
            this.gbSearchBook.Name = "gbSearchBook";
            this.gbSearchBook.Size = new System.Drawing.Size(226, 88);
            this.gbSearchBook.TabIndex = 9;
            this.gbSearchBook.TabStop = false;
            this.gbSearchBook.Text = "Search Book";
            // 
            // llbAdvanceSearch
            // 
            this.llbAdvanceSearch.AutoSize = true;
            this.llbAdvanceSearch.Location = new System.Drawing.Point(12, 55);
            this.llbAdvanceSearch.Name = "llbAdvanceSearch";
            this.llbAdvanceSearch.Size = new System.Drawing.Size(87, 13);
            this.llbAdvanceSearch.TabIndex = 7;
            this.llbAdvanceSearch.TabStop = true;
            this.llbAdvanceSearch.Text = "Advance Search";
            this.llbAdvanceSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(119, 50);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBook.TabIndex = 6;
            this.btnSearchBook.Text = "Search";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(454, 442);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 10;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // BookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(635, 477);
            this.Controls.Add(this.gbSearchBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.gbSearchByBookID);
            this.Name = "BookListForm";
            this.Load += new System.EventHandler(this.BookListForm_Load);
            this.Controls.SetChildIndex(this.gbSearchByBookID, 0);
            this.Controls.SetChildIndex(this.btnAddBook, 0);
            this.Controls.SetChildIndex(this.gbSearchBook, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbSearchByBookID.ResumeLayout(false);
            this.gbSearchByBookID.PerformLayout();
            this.gbSearchBook.ResumeLayout(false);
            this.gbSearchBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchByBookID;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.Button btnSearchByBookID;
        private System.Windows.Forms.GroupBox gbSearchByBookID;
        private System.Windows.Forms.GroupBox gbSearchBook;
        private System.Windows.Forms.LinkLabel llbAdvanceSearch;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnAddBook;
    }
}
