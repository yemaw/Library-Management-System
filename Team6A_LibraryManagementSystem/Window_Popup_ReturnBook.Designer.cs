namespace Team6A_LibraryManagementSystem
{
    partial class Window_Popup_ReturnBook
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblBookIDValue = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblMemberIDValue = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblMemberNameValue = new System.Windows.Forms.Label();
            this.lblRentDate = new System.Windows.Forms.Label();
            this.lblRentDateValue = new System.Windows.Forms.Label();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblChargeValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(296, 251);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.Location = new System.Drawing.Point(58, 28);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(103, 22);
            this.lblBookTitle.TabIndex = 1;
            this.lblBookTitle.Text = "(Book Title)";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblBookID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBookIDValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMemberID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMemberIDValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMemberName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMemberNameValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblRentDate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblRentDateValue, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCharge, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblChargeValue, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(55, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(471, 180);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(3, 0);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(46, 13);
            this.lblBookID.TabIndex = 0;
            this.lblBookID.Text = "Book ID";
            // 
            // lblBookIDValue
            // 
            this.lblBookIDValue.AutoSize = true;
            this.lblBookIDValue.Location = new System.Drawing.Point(238, 0);
            this.lblBookIDValue.Name = "lblBookIDValue";
            this.lblBookIDValue.Size = new System.Drawing.Size(52, 13);
            this.lblBookIDValue.TabIndex = 1;
            this.lblBookIDValue.Text = "(Book ID)";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(3, 37);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(59, 13);
            this.lblMemberID.TabIndex = 2;
            this.lblMemberID.Text = "Member ID";
            // 
            // lblMemberIDValue
            // 
            this.lblMemberIDValue.AutoSize = true;
            this.lblMemberIDValue.Location = new System.Drawing.Point(238, 37);
            this.lblMemberIDValue.Name = "lblMemberIDValue";
            this.lblMemberIDValue.Size = new System.Drawing.Size(65, 13);
            this.lblMemberIDValue.TabIndex = 3;
            this.lblMemberIDValue.Text = "(Member ID)";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(3, 74);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(76, 13);
            this.lblMemberName.TabIndex = 4;
            this.lblMemberName.Text = "Member Name";
            // 
            // lblMemberNameValue
            // 
            this.lblMemberNameValue.AutoSize = true;
            this.lblMemberNameValue.Location = new System.Drawing.Point(238, 74);
            this.lblMemberNameValue.Name = "lblMemberNameValue";
            this.lblMemberNameValue.Size = new System.Drawing.Size(82, 13);
            this.lblMemberNameValue.TabIndex = 5;
            this.lblMemberNameValue.Text = "(Member Name)";
            // 
            // lblRentDate
            // 
            this.lblRentDate.AutoSize = true;
            this.lblRentDate.Location = new System.Drawing.Point(3, 111);
            this.lblRentDate.Name = "lblRentDate";
            this.lblRentDate.Size = new System.Drawing.Size(56, 13);
            this.lblRentDate.TabIndex = 6;
            this.lblRentDate.Text = "Rent Date";
            // 
            // lblRentDateValue
            // 
            this.lblRentDateValue.AutoSize = true;
            this.lblRentDateValue.Location = new System.Drawing.Point(238, 111);
            this.lblRentDateValue.Name = "lblRentDateValue";
            this.lblRentDateValue.Size = new System.Drawing.Size(62, 13);
            this.lblRentDateValue.TabIndex = 7;
            this.lblRentDateValue.Text = "(Rent Date)";
            // 
            // lblCharge
            // 
            this.lblCharge.AutoSize = true;
            this.lblCharge.Location = new System.Drawing.Point(3, 148);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(41, 13);
            this.lblCharge.TabIndex = 8;
            this.lblCharge.Text = "Charge";
            // 
            // lblChargeValue
            // 
            this.lblChargeValue.AutoSize = true;
            this.lblChargeValue.Location = new System.Drawing.Point(238, 148);
            this.lblChargeValue.Name = "lblChargeValue";
            this.lblChargeValue.Size = new System.Drawing.Size(77, 13);
            this.lblChargeValue.TabIndex = 9;
            this.lblChargeValue.Text = "(Charge Value)";
            // 
            // Window_Popup_ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 358);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimizeBox = false;
            this.Name = "Window_Popup_ReturnBook";
            this.Text = "Lend Book - Library Management System (Team 6A)";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblBookIDValue;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblMemberIDValue;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblMemberNameValue;
        private System.Windows.Forms.Label lblRentDate;
        private System.Windows.Forms.Label lblRentDateValue;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Label lblChargeValue;

    }
}