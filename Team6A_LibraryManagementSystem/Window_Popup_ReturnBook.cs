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
    public partial class Window_Popup_ReturnBook : Template_Master
    {
        LibTran transaction;
        Book book;
        Member member;
        BooksModel bookmodel;
        double charge;

        Window_Master MainWindowObject;

        public void setMainWindowRefrence(Window_Master window)
        {
            MainWindowObject = window;
        }

        public Window_Popup_ReturnBook()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //make unresizable 
        }

        public Window_Popup_ReturnBook(int _book_id)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //make unresizable 
            
            transaction =  EntityBroker.getLastTransationByBookID(_book_id);
            book = EntityBroker.getBookByBookID(_book_id);
            member = EntityBroker.getMemberByMemberID(transaction.MemberID);
            bookmodel = EntityBroker.getBookModelByID(book.BookModelID);

            calculateCharge();

            lblBookTitle.Text = bookmodel.BookTitle;

            lblBookIDValue.Text = book.BookID.ToString();
            lblMemberNameValue.Text = member.MemberName;
            lblMemberIDValue.Text = member.MemberID.ToString();
            lblRentDateValue.Text = transaction.LendDate.ToString("dd MM, yyyy");
            lblChargeValue.Text = charge.ToString();
        }

        private void calculateCharge() {
            int diffDays = (DateTime.Today.Date - transaction.LendDate.Date).Days;
            charge = diffDays * Convert.ToInt32(bookmodel.RentalPricePerDay);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //update book status
            book.BookStatus = 1;
            int i = EntityBroker.updateBook(book);
            if (i == 1)
            {
                //transaction
                transaction.ReturnDate = DateTime.Today.Date;
                transaction.ChargeAmount = (decimal)charge;
                int j = EntityBroker.updateTransaction(transaction);
                if (j != 1) {
                    MessageBox.Show("Error Saving in Book Transaction Update. Please Contact to Programmer");
                }
            }
            else {
                MessageBox.Show("Error Saving in Book Status Change. Please Contact to Programmer");
            }
            
            ucListBooks booklist = new ucListBooks();
            booklist.setMainWindowRefrence(MainWindowObject);
            MainWindowObject.RequestContentChange(booklist);

            this.Close();
        }
    }
}
