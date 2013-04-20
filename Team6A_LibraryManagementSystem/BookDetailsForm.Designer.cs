namespace Team6A_LibraryManagementSystem
{
    partial class BookDetailsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBookDescription = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPublisherName = new System.Windows.Forms.Label();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblPublishDate = new System.Windows.Forms.Label();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblRentalPricePerDay = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBookTitlePageTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.85166F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.14834F));
            this.tableLayoutPanel1.Controls.Add(this.lblBookDescription, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBookTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAuthor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPublisherName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPublisherName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtAuthor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPublishDate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpPublishDate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblRentalPricePerDay, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(59, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.20513F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.79487F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 242);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblBookDescription
            // 
            this.lblBookDescription.AutoSize = true;
            this.lblBookDescription.Location = new System.Drawing.Point(3, 31);
            this.lblBookDescription.Name = "lblBookDescription";
            this.lblBookDescription.Size = new System.Drawing.Size(88, 13);
            this.lblBookDescription.TabIndex = 1;
            this.lblBookDescription.Text = "Book Description";
            this.lblBookDescription.Click += new System.EventHandler(this.label2_Click);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 34);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 69);
            this.textBox2.TabIndex = 2;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(3, 110);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Author";
            // 
            // lblPublisherName
            // 
            this.lblPublisherName.AutoSize = true;
            this.lblPublisherName.Location = new System.Drawing.Point(3, 135);
            this.lblPublisherName.Name = "lblPublisherName";
            this.lblPublisherName.Size = new System.Drawing.Size(81, 13);
            this.lblPublisherName.TabIndex = 4;
            this.lblPublisherName.Text = "Publisher Name";
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.Location = new System.Drawing.Point(150, 138);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(238, 20);
            this.txtPublisherName.TabIndex = 5;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(150, 113);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(238, 20);
            this.txtAuthor.TabIndex = 6;
            // 
            // lblPublishDate
            // 
            this.lblPublishDate.AutoSize = true;
            this.lblPublishDate.Location = new System.Drawing.Point(3, 161);
            this.lblPublishDate.Name = "lblPublishDate";
            this.lblPublishDate.Size = new System.Drawing.Size(67, 13);
            this.lblPublishDate.TabIndex = 7;
            this.lblPublishDate.Text = "Publish Date";
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.Location = new System.Drawing.Point(150, 164);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(190, 20);
            this.dtpPublishDate.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(150, 196);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox4);
            this.splitContainer1.Size = new System.Drawing.Size(150, 42);
            this.splitContainer1.SplitterDistance = 55;
            this.splitContainer1.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(41, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(42, 20);
            this.textBox4.TabIndex = 0;
            // 
            // lblRentalPricePerDay
            // 
            this.lblRentalPricePerDay.AutoSize = true;
            this.lblRentalPricePerDay.Location = new System.Drawing.Point(3, 193);
            this.lblRentalPricePerDay.Name = "lblRentalPricePerDay";
            this.lblRentalPricePerDay.Size = new System.Drawing.Size(106, 13);
            this.lblRentalPricePerDay.TabIndex = 9;
            this.lblRentalPricePerDay.Text = "Rental Price Per Day";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblBookTitlePageTitle
            // 
            this.lblBookTitlePageTitle.AutoSize = true;
            this.lblBookTitlePageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitlePageTitle.Location = new System.Drawing.Point(54, 26);
            this.lblBookTitlePageTitle.Name = "lblBookTitlePageTitle";
            this.lblBookTitlePageTitle.Size = new System.Drawing.Size(127, 26);
            this.lblBookTitlePageTitle.TabIndex = 1;
            this.lblBookTitlePageTitle.Text = "Book Name";
            // 
            // BookDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(581, 522);
            this.Controls.Add(this.lblBookTitlePageTitle);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BookDetailsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBookDescription;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPublisherName;
        private System.Windows.Forms.TextBox txtPublisherName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblPublishDate;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.Label lblRentalPricePerDay;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblBookTitlePageTitle;

    }
}
