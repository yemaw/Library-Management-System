using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Team6A_LibraryManagementSystem
{
    public partial class Window_Master : Template_Master
    {
        public Window_Master()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.FixedSingle; //make unresizable 
        }

        private void Window_Master_Load(object sender, EventArgs e)
        {
            
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            ucListBooks booklist = new ucListBooks();
            panelMain.Controls.Add(booklist);
            
        }

        public void RequestContent(UserControl uc){
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc);
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window_Popup_Details pd = new Window_Popup_Details(new ucDetailsBook());
            pd.Show();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window_Popup_Details pd = new Window_Popup_Details(new ucDetialsMember());
            pd.Show();
        }

        private void advanceSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window_AdvanceSearch avs = new Window_AdvanceSearch();
            avs.Show();
        }

        private void memberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new ucListMember());
        }

        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new ucListBooks());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Team 6A \n Ruby \n Nay Chi \n DJ \n Ye Maw");
        }

    }
}
