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
        Window_Master MainWindowObject;

        public void setMainWindowRefrence(Window_Master window)
        {
            MainWindowObject = window;
        }

        public Window_Popup_LendBook()
        {
            InitializeComponent();
        }

        public Window_Popup_LendBook(int _book_id)
        {
            InitializeComponent();
            txtBookID.Text = _book_id.ToString();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            //#TODO::ExceptionHandle
            LibraryDBEntities entity = new LibraryDBEntities();
            LibTran t = new LibTran();
            t.MemberID = Convert.ToInt32(txtMemberID.Text);
            t.BookID = Convert.ToInt32(txtBookID.Text);
            t.LendDate = DateTime.Today;

            entity.AddToLibTrans(t);
            entity.SaveChanges();
            
            Book b = entity.Books.Where(x => x.BookID == t.BookID).First();
            b.BookStatus = 0 ;
            
            int i = entity.SaveChanges();
            if (i == 1)
            {
                ucListBooks booklist = new ucListBooks();
                booklist.setMainWindowRefrence(MainWindowObject);
                MainWindowObject.RequestContentChange(booklist);
            }
            this.Close();
        }

        
    }
}
