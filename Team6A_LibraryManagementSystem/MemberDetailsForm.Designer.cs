namespace Team6A_LibraryManagementSystem
{
    partial class MemberDetailsForm
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
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblNIRCNumber = new System.Windows.Forms.Label();
            this.txtNIRCNumber = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblMemberIDValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.52326F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.47675F));
            this.tableLayoutPanel1.Controls.Add(this.txtMemberName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPhoneNumber, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPhoneNumber, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblMemberID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNIRCNumber, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblMemberName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNIRCNumber, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblMemberIDValue, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(85, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.76923F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 182);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(3, 0);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(56, 13);
            this.lblMemberID.TabIndex = 0;
            this.lblMemberID.Text = "MemberID";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(3, 32);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(76, 13);
            this.lblMemberName.TabIndex = 2;
            this.lblMemberName.Text = "Member Name";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(108, 35);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(166, 20);
            this.txtMemberName.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(3, 65);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(108, 68);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(166, 18);
            this.txtAddress.TabIndex = 5;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(3, 89);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 6;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(108, 92);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(166, 20);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // lblNIRCNumber
            // 
            this.lblNIRCNumber.AutoSize = true;
            this.lblNIRCNumber.Location = new System.Drawing.Point(3, 115);
            this.lblNIRCNumber.Name = "lblNIRCNumber";
            this.lblNIRCNumber.Size = new System.Drawing.Size(53, 13);
            this.lblNIRCNumber.TabIndex = 8;
            this.lblNIRCNumber.Text = "NIRC No.";
            // 
            // txtNIRCNumber
            // 
            this.txtNIRCNumber.Location = new System.Drawing.Point(108, 118);
            this.txtNIRCNumber.Name = "txtNIRCNumber";
            this.txtNIRCNumber.Size = new System.Drawing.Size(166, 20);
            this.txtNIRCNumber.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 147);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(108, 150);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // lblMemberIDValue
            // 
            this.lblMemberIDValue.AutoSize = true;
            this.lblMemberIDValue.Location = new System.Drawing.Point(108, 0);
            this.lblMemberIDValue.Name = "lblMemberIDValue";
            this.lblMemberIDValue.Size = new System.Drawing.Size(37, 13);
            this.lblMemberIDValue.TabIndex = 12;
            this.lblMemberIDValue.Text = "12354";
            // 
            // MemberDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MemberDetailsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblNIRCNumber;
        private System.Windows.Forms.TextBox txtNIRCNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblMemberIDValue;
    }
}
