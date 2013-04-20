namespace Team6A_LibraryManagementSystem
{
    partial class Window_Popup_Details
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
            this.panelPopup = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelPopup
            // 
            this.panelPopup.Location = new System.Drawing.Point(12, 12);
            this.panelPopup.Name = "panelPopup";
            this.panelPopup.Size = new System.Drawing.Size(841, 435);
            this.panelPopup.TabIndex = 0;
            // 
            // Window_Popup_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 459);
            this.Controls.Add(this.panelPopup);
            this.Name = "Window_Popup_Details";
            this.Text = "Window_Popup_Details";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPopup;
    }
}