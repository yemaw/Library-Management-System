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
        public Window_Popup_ReturnBook()
        {
            InitializeComponent();
        }

        public Window_Popup_ReturnBook(int _book_id)
        {
            InitializeComponent();
            
            LibTran transaction =  EntityBroker.getLastTransationByBookID(_book_id);
            Book book = EntityBroker.getBookByBookID(_book_id);

            int _member_id = 1;// transaction.MemberID;
            MessageBox.Show(transaction.TransactionID.ToString()); 
            MessageBox.Show(transaction.MemberID.ToString()); 
            //MessageBox.Show(_member_id.ToString());
            //Member member = EntityBroker.getMemberByMemberID(_member_id);

            //lblBookIDValue.Text = book.BookID.ToString();
            //lblMemberNameValue.Text = member.MemberName;
            //lblMemberIDValue.Text = member.MemberID.ToString();
            //lblRentDateValue.Text = transaction.LendDate.ToString("dd MM, yyyy");
 
        }
    }
}
