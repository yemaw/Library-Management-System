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
    public partial class Window_Popup_LendBook : Template_Master
    {
        LibraryDBEntities entity = new LibraryDBEntities();
        public Window_Popup_LendBook()
        {
            InitializeComponent();
        }

        public Window_Popup_LendBook(int bid)
        {
            InitializeComponent();

            txtBookID.Text = bid.ToString();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            
            LibTran t = new LibTran();
            t.MemberID = Convert.ToInt32(txtMemberID.Text);
            t.BookID = Convert.ToInt32(txtBookID.Text);
            t.LendDate = DateTime.Today;

            entity.AddToLibTrans(t);
            entity.SaveChanges();
            
            Book b = entity.Books.Where(x => x.BookID == t.BookID).First();
            b.BookStatus = 0 ;
            
            entity.SaveChanges();
            ucListBooks bl = new ucListBooks();
            bl.Refresh();

            this.Close();
            
        }

        
    }
}
