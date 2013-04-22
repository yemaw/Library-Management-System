namespace Team6A_LibraryManagementSystem
{
    partial class Window_AdvanceSearch
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
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblPublisherName = new System.Windows.Forms.Label();
            this.txtPublishName = new System.Windows.Forms.TextBox();
            this.lblPublishDate = new System.Windows.Forms.Label();
            this.txtPublishDate = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBookCategory = new System.Windows.Forms.Label();
            this.txtBookCategory = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtBookTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblBookTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAuthor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAuthor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPublisherName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPublishName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPublishDate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPublishDate, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblBookCategory, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtBookCategory, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(187, 88);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.94118F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(481, 295);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(3, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(52, 13);
            this.lblBookTitle.TabIndex = 0;
            this.lblBookTitle.Text = "BookTitle";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(233, 3);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(151, 20);
            this.txtBookTitle.TabIndex = 1;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(3, 54);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(233, 57);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(151, 20);
            this.txtAuthor.TabIndex = 5;
            // 
            // lblPublisherName
            // 
            this.lblPublisherName.AutoSize = true;
            this.lblPublisherName.Location = new System.Drawing.Point(3, 102);
            this.lblPublisherName.Name = "lblPublisherName";
            this.lblPublisherName.Size = new System.Drawing.Size(81, 13);
            this.lblPublisherName.TabIndex = 6;
            this.lblPublisherName.Text = "Publisher Name";
            // 
            // txtPublishName
            // 
            this.txtPublishName.Location = new System.Drawing.Point(233, 105);
            this.txtPublishName.Name = "txtPublishName";
            this.txtPublishName.Size = new System.Drawing.Size(151, 20);
            this.txtPublishName.TabIndex = 7;
            // 
            // lblPublishDate
            // 
            this.lblPublishDate.AutoSize = true;
            this.lblPublishDate.Location = new System.Drawing.Point(3, 152);
            this.lblPublishDate.Name = "lblPublishDate";
            this.lblPublishDate.Size = new System.Drawing.Size(64, 13);
            this.lblPublishDate.TabIndex = 8;
            this.lblPublishDate.Text = "PublishDate";
            // 
            // txtPublishDate
            // 
            this.txtPublishDate.Location = new System.Drawing.Point(233, 155);
            this.txtPublishDate.Name = "txtPublishDate";
            this.txtPublishDate.Size = new System.Drawing.Size(151, 20);
            this.txtPublishDate.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(233, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Search";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblBookCategory
            // 
            this.lblBookCategory.AutoSize = true;
            this.lblBookCategory.Location = new System.Drawing.Point(3, 202);
            this.lblBookCategory.Name = "lblBookCategory";
            this.lblBookCategory.Size = new System.Drawing.Size(74, 13);
            this.lblBookCategory.TabIndex = 10;
            this.lblBookCategory.Text = "BookCategory";
            // 
            // txtBookCategory
            // 
            this.txtBookCategory.Location = new System.Drawing.Point(233, 205);
            this.txtBookCategory.Name = "txtBookCategory";
            this.txtBookCategory.Size = new System.Drawing.Size(151, 20);
            this.txtBookCategory.TabIndex = 11;
            // 
            // Window_AdvanceSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 459);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Window_AdvanceSearch";
            this.Text = "Advance Search";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblPublisherName;
        private System.Windows.Forms.TextBox txtPublishName;
        private System.Windows.Forms.Label lblPublishDate;
        private System.Windows.Forms.TextBox txtPublishDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblBookCategory;
        private System.Windows.Forms.TextBox txtBookCategory;
    }
}