namespace Team6A_LibraryManagementSystem
{
    partial class MemberListForm
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
            this.txtAddMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddMember
            // 
            this.txtAddMember.Location = new System.Drawing.Point(464, 387);
            this.txtAddMember.Name = "txtAddMember";
            this.txtAddMember.Size = new System.Drawing.Size(75, 23);
            this.txtAddMember.TabIndex = 3;
            this.txtAddMember.Text = "Add Member";
            this.txtAddMember.UseVisualStyleBackColor = true;
            this.txtAddMember.Click += new System.EventHandler(this.txtAddMember_Click);
            // 
            // MemberListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(611, 422);
            this.Controls.Add(this.txtAddMember);
            this.Name = "MemberListForm";
            this.Controls.SetChildIndex(this.txtAddMember, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtAddMember;

    }
}
