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
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //make unresizable 
        }

        public Window_Popup_LendBook(int _book_id)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //make unresizable 
            txtBookID.Text = _book_id.ToString();
            
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            //#TODO::ExceptionHandle
            LibraryDBEntities entity = new LibraryDBEntities();
            LibTran t = new LibTran();

            int member_id = 0;
            int book_id = 0;
            try
            {
                book_id = Convert.ToInt32(txtBookID.Text);
            }
            catch
            {
                MessageBox.Show("BookID you entered is not valid type.");
                return;
            }

            try
            {
                member_id = Convert.ToInt32(txtMemberID.Text);
            }
            catch
            {
                MessageBox.Show("MemberID you entered is not valid type.");
                return;
            }

            Book book = EntityBroker.getBookByBookID(book_id);
            if (book == null) {
                MessageBox.Show("BookID doesn't exit.");
                return;
            }
            if (book.BookStatus != 1)
            {
                MessageBox.Show("Book is not avaiable to rent.");
                return;
            }
     
            Member member = new Member();
            member = EntityBroker.getMemberByMemberID(member_id);
            if (member == null) {
                MessageBox.Show("MemberID doesn't exit.");
                return;
            }

            t.MemberID = member_id;
            t.BookID = book_id;
            t.LendDate = DateTime.Now;

            entity.AddToLibTrans(t);
            try
            {
                entity.SaveChanges();

            }catch{ 
                MessageBox.Show("User not exit");
            }
            Book b = entity.Books.Where(x => x.BookID == t.BookID).SingleOrDefault();
            b.BookStatus = 0;

            int i = entity.SaveChanges();
            if (i == 1)
            {
                try
                {
                    ucListBooks booklist = new ucListBooks();
                    booklist.setMainWindowRefrence(MainWindowObject);
                    MainWindowObject.RequestContentChange(booklist);
                }
                catch {
                    MessageBox.Show("Exception. Please close the window manually. Sorry for inconvenience");
                }
            }
            this.Close();
        }

        
    }
}
