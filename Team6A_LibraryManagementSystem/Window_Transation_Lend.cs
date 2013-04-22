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
    public partial class Window_Transation_Lend : Template_Master
    {
        LibraryDBEntities entity = new LibraryDBEntities();
        public Window_Transation_Lend()
        {
            InitializeComponent();
        }

        public Window_Transation_Lend(int bid)
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
            this.Close();
        }

        
    }
}
