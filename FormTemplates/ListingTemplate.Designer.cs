namespace FormTemplates
{
    partial class ListingTemplate
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.llbBooksMenu = new System.Windows.Forms.LinkLabel();
            this.llbMembersMenu = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormTemplates.Properties.Resources.nuslogo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // llbBooksMenu
            // 
            this.llbBooksMenu.AutoSize = true;
            this.llbBooksMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbBooksMenu.Location = new System.Drawing.Point(117, 13);
            this.llbBooksMenu.Name = "llbBooksMenu";
            this.llbBooksMenu.Size = new System.Drawing.Size(54, 20);
            this.llbBooksMenu.TabIndex = 1;
            this.llbBooksMenu.TabStop = true;
            this.llbBooksMenu.Text = "Books";
            
            // 
            // llbMembersMenu
            // 
            this.llbMembersMenu.AutoSize = true;
            this.llbMembersMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbMembersMenu.Location = new System.Drawing.Point(178, 13);
            this.llbMembersMenu.Name = "llbMembersMenu";
            this.llbMembersMenu.Size = new System.Drawing.Size(75, 20);
            this.llbMembersMenu.TabIndex = 2;
            this.llbMembersMenu.TabStop = true;
            this.llbMembersMenu.Text = "Members";
            // 
            // ListingTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 422);
            this.Controls.Add(this.llbMembersMenu);
            this.Controls.Add(this.llbBooksMenu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListingTemplate";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.OpenFileDialog openFileDialog1;
        protected System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llbBooksMenu;
        private System.Windows.Forms.LinkLabel llbMembersMenu;
    }
}

