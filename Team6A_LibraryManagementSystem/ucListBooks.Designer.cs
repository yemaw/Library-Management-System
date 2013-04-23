namespace Team6A_LibraryManagementSystem
{
    partial class ucListBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSearchByBookID = new System.Windows.Forms.GroupBox();
            this.txtSearchByBookID = new System.Windows.Forms.TextBox();
            this.btnSearchByBookID = new System.Windows.Forms.Button();
            this.gbSearchByBookTitle = new System.Windows.Forms.GroupBox();
            this.llbClearSearchBookByTitle = new System.Windows.Forms.LinkLabel();
            this.txtSearchByBookTitle = new System.Windows.Forms.TextBox();
            this.btnSearchByBookTitle = new System.Windows.Forms.Button();
            this.dgvBooksList = new System.Windows.Forms.DataGridView();
            this.gbSearchByBookID.SuspendLayout();
            this.gbSearchByBookTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearchByBookID
            // 
            this.gbSearchByBookID.Controls.Add(this.txtSearchByBookID);
            this.gbSearchByBookID.Controls.Add(this.btnSearchByBookID);
            this.gbSearchByBookID.Location = new System.Drawing.Point(13, 10);
            this.gbSearchByBookID.Name = "gbSearchByBookID";
            this.gbSearchByBookID.Size = new System.Drawing.Size(275, 85);
            this.gbSearchByBookID.TabIndex = 0;
            this.gbSearchByBookID.TabStop = false;
            this.gbSearchByBookID.Text = "Search by BookID";
            // 
            // txtSearchByBookID
            // 
            this.txtSearchByBookID.Location = new System.Drawing.Point(19, 34);
            this.txtSearchByBookID.Name = "txtSearchByBookID";
            this.txtSearchByBookID.Size = new System.Drawing.Size(146, 20);
            this.txtSearchByBookID.TabIndex = 1;
            // 
            // btnSearchByBookID
            // 
            this.btnSearchByBookID.Location = new System.Drawing.Point(190, 33);
            this.btnSearchByBookID.Name = "btnSearchByBookID";
            this.btnSearchByBookID.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByBookID.TabIndex = 0;
            this.btnSearchByBookID.Text = "Search";
            this.btnSearchByBookID.UseVisualStyleBackColor = true;
            this.btnSearchByBookID.Click += new System.EventHandler(this.btnSearchByBookID_Click);
            // 
            // gbSearchByBookTitle
            // 
            this.gbSearchByBookTitle.Controls.Add(this.llbClearSearchBookByTitle);
            this.gbSearchByBookTitle.Controls.Add(this.txtSearchByBookTitle);
            this.gbSearchByBookTitle.Controls.Add(this.btnSearchByBookTitle);
            this.gbSearchByBookTitle.Location = new System.Drawing.Point(316, 11);
            this.gbSearchByBookTitle.Name = "gbSearchByBookTitle";
            this.gbSearchByBookTitle.Size = new System.Drawing.Size(275, 85);
            this.gbSearchByBookTitle.TabIndex = 2;
            this.gbSearchByBookTitle.TabStop = false;
            this.gbSearchByBookTitle.Text = "Search by Book Title";
            // 
            // llbClearSearchBookByTitle
            // 
            this.llbClearSearchBookByTitle.AutoSize = true;
            this.llbClearSearchBookByTitle.Location = new System.Drawing.Point(200, 57);
            this.llbClearSearchBookByTitle.Name = "llbClearSearchBookByTitle";
            this.llbClearSearchBookByTitle.Size = new System.Drawing.Size(31, 13);
            this.llbClearSearchBookByTitle.TabIndex = 5;
            this.llbClearSearchBookByTitle.TabStop = true;
            this.llbClearSearchBookByTitle.Text = "Clear";
            this.llbClearSearchBookByTitle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbClearSearchBookByTitle_LinkClicked);
            // 
            // txtSearchByBookTitle
            // 
            this.txtSearchByBookTitle.Location = new System.Drawing.Point(19, 34);
            this.txtSearchByBookTitle.Name = "txtSearchByBookTitle";
            this.txtSearchByBookTitle.Size = new System.Drawing.Size(169, 20);
            this.txtSearchByBookTitle.TabIndex = 1;
            // 
            // btnSearchByBookTitle
            // 
            this.btnSearchByBookTitle.Location = new System.Drawing.Point(194, 31);
            this.btnSearchByBookTitle.Name = "btnSearchByBookTitle";
            this.btnSearchByBookTitle.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByBookTitle.TabIndex = 0;
            this.btnSearchByBookTitle.Text = "Search";
            this.btnSearchByBookTitle.UseVisualStyleBackColor = true;
            this.btnSearchByBookTitle.Click += new System.EventHandler(this.btnSearchByBookTitle_Click);
            // 
            // dgvBooksList
            // 
            this.dgvBooksList.AllowUserToAddRows = false;
            this.dgvBooksList.AllowUserToDeleteRows = false;
            this.dgvBooksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooksList.Location = new System.Drawing.Point(13, 118);
            this.dgvBooksList.Name = "dgvBooksList";
            this.dgvBooksList.Size = new System.Drawing.Size(760, 243);
            this.dgvBooksList.TabIndex = 4;
            this.dgvBooksList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooksList_CellClick);
            // 
            // ucListBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvBooksList);
            this.Controls.Add(this.gbSearchByBookTitle);
            this.Controls.Add(this.gbSearchByBookID);
            this.Name = "ucListBooks";
            this.Size = new System.Drawing.Size(789, 387);
            this.Load += new System.EventHandler(this.ucListBooks_Load);
            this.Controls.SetChildIndex(this.gbSearchByBookID, 0);
            this.Controls.SetChildIndex(this.gbSearchByBookTitle, 0);
            this.Controls.SetChildIndex(this.dgvBooksList, 0);
            this.gbSearchByBookID.ResumeLayout(false);
            this.gbSearchByBookID.PerformLayout();
            this.gbSearchByBookTitle.ResumeLayout(false);
            this.gbSearchByBookTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchByBookID;
        private System.Windows.Forms.TextBox txtSearchByBookID;
        private System.Windows.Forms.Button btnSearchByBookID;
        private System.Windows.Forms.GroupBox gbSearchByBookTitle;
        private System.Windows.Forms.TextBox txtSearchByBookTitle;
        private System.Windows.Forms.Button btnSearchByBookTitle;
        private System.Windows.Forms.DataGridView dgvBooksList;
        private System.Windows.Forms.LinkLabel llbClearSearchBookByTitle;
    }
}
