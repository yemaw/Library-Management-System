namespace Team6A_LibraryManagementSystem
{
    partial class ucDetailsBook
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
            this.lblBookTitlePageTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBookDescription = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtBookDescription = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPublisherName = new System.Windows.Forms.Label();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblPublishDate = new System.Windows.Forms.Label();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtRentalPriceDecimal = new System.Windows.Forms.TextBox();
            this.txtRentalPricePoint = new System.Windows.Forms.TextBox();
            this.lblRentalPricePerDay = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookCategory = new System.Windows.Forms.Label();
            this.txtBookCategory = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvListOfCopies = new System.Windows.Forms.DataGridView();
            this.lblListOfCopies = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookTitlePageTitle
            // 
            this.lblBookTitlePageTitle.AutoSize = true;
            this.lblBookTitlePageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitlePageTitle.Location = new System.Drawing.Point(115, 0);
            this.lblBookTitlePageTitle.Name = "lblBookTitlePageTitle";
            this.lblBookTitlePageTitle.Size = new System.Drawing.Size(122, 26);
            this.lblBookTitlePageTitle.TabIndex = 3;
            this.lblBookTitlePageTitle.Text = "(Book Title)";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.85166F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.14834F));
            this.tableLayoutPanel1.Controls.Add(this.lblBookDescription, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBookTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBookDescription, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAuthor, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPublisherName, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPublisherName, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtAuthor, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPublishDate, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtpPublishDate, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblRentalPricePerDay, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtBookTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBookCategory, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBookCategory, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(120, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.20513F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.79487F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 263);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblBookDescription
            // 
            this.lblBookDescription.AutoSize = true;
            this.lblBookDescription.Location = new System.Drawing.Point(3, 23);
            this.lblBookDescription.Name = "lblBookDescription";
            this.lblBookDescription.Size = new System.Drawing.Size(88, 13);
            this.lblBookDescription.TabIndex = 1;
            this.lblBookDescription.Text = "Book Description";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(3, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(55, 13);
            this.lblBookTitle.TabIndex = 1;
            this.lblBookTitle.Text = "Book Title";
            // 
            // txtBookDescription
            // 
            this.txtBookDescription.Location = new System.Drawing.Point(150, 26);
            this.txtBookDescription.Multiline = true;
            this.txtBookDescription.Name = "txtBookDescription";
            this.txtBookDescription.Size = new System.Drawing.Size(238, 54);
            this.txtBookDescription.TabIndex = 2;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(3, 117);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Author";
            // 
            // lblPublisherName
            // 
            this.lblPublisherName.AutoSize = true;
            this.lblPublisherName.Location = new System.Drawing.Point(3, 149);
            this.lblPublisherName.Name = "lblPublisherName";
            this.lblPublisherName.Size = new System.Drawing.Size(81, 13);
            this.lblPublisherName.TabIndex = 4;
            this.lblPublisherName.Text = "Publisher Name";
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.Location = new System.Drawing.Point(150, 152);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(238, 20);
            this.txtPublisherName.TabIndex = 5;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(150, 120);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(238, 20);
            this.txtAuthor.TabIndex = 6;
            // 
            // lblPublishDate
            // 
            this.lblPublishDate.AutoSize = true;
            this.lblPublishDate.Location = new System.Drawing.Point(3, 175);
            this.lblPublishDate.Name = "lblPublishDate";
            this.lblPublishDate.Size = new System.Drawing.Size(67, 13);
            this.lblPublishDate.TabIndex = 7;
            this.lblPublishDate.Text = "Publish Date";
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.Location = new System.Drawing.Point(150, 178);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(190, 20);
            this.dtpPublishDate.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(150, 216);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtRentalPriceDecimal);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtRentalPricePoint);
            this.splitContainer1.Size = new System.Drawing.Size(150, 42);
            this.splitContainer1.SplitterDistance = 55;
            this.splitContainer1.TabIndex = 10;
            // 
            // txtRentalPriceDecimal
            // 
            this.txtRentalPriceDecimal.Location = new System.Drawing.Point(3, 3);
            this.txtRentalPriceDecimal.Name = "txtRentalPriceDecimal";
            this.txtRentalPriceDecimal.Size = new System.Drawing.Size(41, 20);
            this.txtRentalPriceDecimal.TabIndex = 0;
            // 
            // txtRentalPricePoint
            // 
            this.txtRentalPricePoint.Location = new System.Drawing.Point(3, 3);
            this.txtRentalPricePoint.Name = "txtRentalPricePoint";
            this.txtRentalPricePoint.Size = new System.Drawing.Size(42, 20);
            this.txtRentalPricePoint.TabIndex = 0;
            // 
            // lblRentalPricePerDay
            // 
            this.lblRentalPricePerDay.AutoSize = true;
            this.lblRentalPricePerDay.Location = new System.Drawing.Point(3, 213);
            this.lblRentalPricePerDay.Name = "lblRentalPricePerDay";
            this.lblRentalPricePerDay.Size = new System.Drawing.Size(106, 13);
            this.lblRentalPricePerDay.TabIndex = 9;
            this.lblRentalPricePerDay.Text = "Rental Price Per Day";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(150, 3);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(238, 20);
            this.txtBookTitle.TabIndex = 0;
            this.txtBookTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBookTitle_KeyUp);
            // 
            // lblBookCategory
            // 
            this.lblBookCategory.AutoSize = true;
            this.lblBookCategory.Location = new System.Drawing.Point(3, 83);
            this.lblBookCategory.Name = "lblBookCategory";
            this.lblBookCategory.Size = new System.Drawing.Size(49, 13);
            this.lblBookCategory.TabIndex = 11;
            this.lblBookCategory.Text = "Category";
            // 
            // txtBookCategory
            // 
            this.txtBookCategory.Location = new System.Drawing.Point(150, 86);
            this.txtBookCategory.Name = "txtBookCategory";
            this.txtBookCategory.Size = new System.Drawing.Size(238, 20);
            this.txtBookCategory.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(446, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvListOfCopies
            // 
            this.dgvListOfCopies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOfCopies.Location = new System.Drawing.Point(3, 364);
            this.dgvListOfCopies.Name = "dgvListOfCopies";
            this.dgvListOfCopies.Size = new System.Drawing.Size(828, 205);
            this.dgvListOfCopies.TabIndex = 7;
            // 
            // lblListOfCopies
            // 
            this.lblListOfCopies.AutoSize = true;
            this.lblListOfCopies.Location = new System.Drawing.Point(4, 345);
            this.lblListOfCopies.Name = "lblListOfCopies";
            this.lblListOfCopies.Size = new System.Drawing.Size(70, 13);
            this.lblListOfCopies.TabIndex = 8;
            this.lblListOfCopies.Text = "List of Copies";
            // 
            // ucDetailsBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblListOfCopies);
            this.Controls.Add(this.dgvListOfCopies);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblBookTitlePageTitle);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucDetailsBook";
            this.Size = new System.Drawing.Size(853, 572);
            this.Load += new System.EventHandler(this.ucDetailsBook_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookTitlePageTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblBookDescription;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtBookDescription;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPublisherName;
        private System.Windows.Forms.TextBox txtPublisherName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblPublishDate;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtRentalPriceDecimal;
        private System.Windows.Forms.TextBox txtRentalPricePoint;
        private System.Windows.Forms.Label lblRentalPricePerDay;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblBookCategory;
        private System.Windows.Forms.TextBox txtBookCategory;
        private System.Windows.Forms.DataGridView dgvListOfCopies;
        private System.Windows.Forms.Label lblListOfCopies;
    }
}
