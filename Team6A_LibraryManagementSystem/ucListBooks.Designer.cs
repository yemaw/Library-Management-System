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
            this.txtSearchByBookTitle = new System.Windows.Forms.TextBox();
            this.btnSearchByBookTitle = new System.Windows.Forms.Button();
            this.gbSearchByBookID.SuspendLayout();
            this.gbSearchByBookTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearchByBookID
            // 
            this.gbSearchByBookID.Controls.Add(this.txtSearchByBookID);
            this.gbSearchByBookID.Controls.Add(this.btnSearchByBookID);
            this.gbSearchByBookID.Location = new System.Drawing.Point(13, 34);
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
            this.btnSearchByBookID.Location = new System.Drawing.Point(194, 31);
            this.btnSearchByBookID.Name = "btnSearchByBookID";
            this.btnSearchByBookID.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByBookID.TabIndex = 0;
            this.btnSearchByBookID.Text = "Search";
            this.btnSearchByBookID.UseVisualStyleBackColor = true;
            // 
            // gbSearchByBookTitle
            // 
            this.gbSearchByBookTitle.Controls.Add(this.txtSearchByBookTitle);
            this.gbSearchByBookTitle.Controls.Add(this.btnSearchByBookTitle);
            this.gbSearchByBookTitle.Location = new System.Drawing.Point(316, 34);
            this.gbSearchByBookTitle.Name = "gbSearchByBookTitle";
            this.gbSearchByBookTitle.Size = new System.Drawing.Size(275, 85);
            this.gbSearchByBookTitle.TabIndex = 2;
            this.gbSearchByBookTitle.TabStop = false;
            this.gbSearchByBookTitle.Text = "Search by Book Title";
            // 
            // txtSearchByBookTitle
            // 
            this.txtSearchByBookTitle.Location = new System.Drawing.Point(19, 34);
            this.txtSearchByBookTitle.Name = "txtSearchByBookTitle";
            this.txtSearchByBookTitle.Size = new System.Drawing.Size(146, 20);
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
            // 
            // ucBooksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbSearchByBookTitle);
            this.Controls.Add(this.gbSearchByBookID);
            this.Name = "ucBooksList";
            this.Size = new System.Drawing.Size(792, 470);
            this.Controls.SetChildIndex(this.gbSearchByBookID, 0);
            this.Controls.SetChildIndex(this.gbSearchByBookTitle, 0);
            this.gbSearchByBookID.ResumeLayout(false);
            this.gbSearchByBookID.PerformLayout();
            this.gbSearchByBookTitle.ResumeLayout(false);
            this.gbSearchByBookTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchByBookID;
        private System.Windows.Forms.TextBox txtSearchByBookID;
        private System.Windows.Forms.Button btnSearchByBookID;
        private System.Windows.Forms.GroupBox gbSearchByBookTitle;
        private System.Windows.Forms.TextBox txtSearchByBookTitle;
        private System.Windows.Forms.Button btnSearchByBookTitle;
    }
}
