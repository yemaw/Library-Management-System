using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Team6A_LibraryManagementSystem
{
    public partial class ucDetailsBook : ucDetails
    {
        private LibraryDBEntities entity;
        private BooksModel bookmodel;
        
        private DataTable dt;
        

        public ucDetailsBook()
        {
            InitializeComponent();
            lblBookTitlePageTitle.Text = "";
        }

        public ucDetailsBook(int _book_model_id) {
            InitializeComponent();

            entity = new LibraryDBEntities();
            dt = new DataTable();

            dt.Columns.Add("Book ID", typeof(int));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Lend Date", typeof(string));
            dt.Columns.Add("Due Date", typeof(string));

            bookmodel = EntityBroker.getBookModelByID(_book_model_id);
            
        }

        private void ucDetailsBook_Load(object sender, EventArgs e)
        {
            if (bookmodel == null) {
                return;
            }

            lblBookTitlePageTitle.Text = bookmodel.BookTitle;
            txtBookTitle.Text = bookmodel.BookTitle;
            txtBookDescription.Text = bookmodel.BookDescription;
            txtAuthor.Text = bookmodel.Author;
            txtBookCategory.Text = bookmodel.BookCategory;
            txtPublisherName.Text = bookmodel.PublisherName;
            dtpPublishDate.Value = bookmodel.PublishDate.Value;

            dt.Rows.Clear();

            var books = EntityBroker.getBooksByBookModelID(bookmodel.BookModelId);
            
            foreach (Book book in books)
            {
                string lend_date = "";
                string status = (book.BookStatus == 0) ? "Rented" : (book.BookStatus == 1) ? "Avaiable" : "Not Avaiable";
                //LibTran t = EntityBroker.getTransationByBookID(book.BookID);
                

                if (book.BookStatus == 0) {
                    lend_date = t.LendDate.ToString();    
                }

                dt.Rows.Add(
                    book.BookID,
                    status,
                    lend_date
                    );
            }
            dgvListOfCopies.DataSource = dt;
            
        }

        private void txtBookTitle_KeyUp(object sender, KeyEventArgs e)
        {
            lblBookTitlePageTitle.Text = txtBookTitle.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bookmodel.BookTitle = lblBookTitlePageTitle.Text;
            bookmodel.BookTitle = txtBookTitle.Text;
            bookmodel.BookDescription = txtBookDescription.Text;
            bookmodel.Author = txtAuthor.Text;
            bookmodel.BookCategory = txtBookCategory.Text;
            bookmodel.PublisherName = txtPublisherName.Text;
            bookmodel.PublishDate = dtpPublishDate.Value;

            int i = EntityBroker.updateBookModelEntity(bookmodel);
            if (i == 1)
            {
                MessageBox.Show("Book Information Saved");
            }
            else { 
                MessageBox.Show("Error in updating. Error code :: {0}", i.ToString());
            }
        }

        

        
        

    }
}
