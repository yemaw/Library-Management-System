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

        Window_Master MainWindowObject;
        Window_Popup_Details ParentWindowObject;
        int book_model_id = 0;

        public void setMainWindowRefrence(Window_Master window)
        {
            MainWindowObject = window;
        }

        public void setParentWindowRefrence(Window_Popup_Details window)
        {
            ParentWindowObject = window;
        }

        public ucDetailsBook()
        {
            InitializeComponent();
            lblBookTitlePageTitle.Text = "";
            btnAddNew.Enabled = false;
        }
        
        public ucDetailsBook(int _book_model_id) {
            InitializeComponent();

            book_model_id = _book_model_id;
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
            if (book_model_id > 0)
            {
                fillBookList();
                dgvListOfCopies.DataSource = dt;
            }
        }

        public void fillBookList() {
            try
            {
                lblBookTitlePageTitle.Text = bookmodel.BookTitle;
                txtBookTitle.Text = bookmodel.BookTitle;
                txtBookDescription.Text = bookmodel.BookDescription;
                txtAuthor.Text = bookmodel.Author;
                txtBookCategory.Text = bookmodel.BookCategory;
                txtPublisherName.Text = bookmodel.PublisherName;
                dtpPublishDate.Value = bookmodel.PublishDate.Value;
                txtRentalPricePerDay.Text = bookmodel.RentalPricePerDay.ToString();
                maxAvaiableDaysToRent.Text = bookmodel.MaxAvailableDayToRent.ToString();
            }
            catch { }
            dt.Rows.Clear();

            var books = EntityBroker.getBooksByBookModelID(bookmodel.BookModelId);

            dgvListOfCopies.DataSource = null;
            foreach (Book book in books)
            {
                string lend_date_str = "-";
                string due_date_str = "-";

                string status = (book.BookStatus == 0) ? "Rented" : (book.BookStatus == 1) ? "Avaiable" : "Not Avaiable";
                
                LibTran t = EntityBroker.getLastTransationByBookID(book.BookID);

                if (book.BookStatus == 0)
                {
                    lend_date_str = t.LendDate.ToString("dd MM yyyy");
                    DateTime DueDate = t.LendDate.AddDays(Convert.ToDouble(bookmodel.MaxAvailableDayToRent));
                    due_date_str = DueDate.ToString("dd MM yyyy");
                }

                dt.Rows.Add(
                    book.BookID,
                    status,
                    lend_date_str,
                    due_date_str
                  );
            }
            
        }

        private void txtBookTitle_KeyUp(object sender, KeyEventArgs e)
        {
            lblBookTitlePageTitle.Text = txtBookTitle.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (txtBookTitle.Text == "")
            {
                MessageBox.Show("Book Title shouldn't be empty.");
                return;
            }
            if (txtRentalPricePerDay.Text == "")
            {
                MessageBox.Show("Rental Price shouldn't be empty.");
                return;
            }
            if (maxAvaiableDaysToRent.Text == "")
            {
                MessageBox.Show("Max Avaiable Days To Rent shouldn't be empty.");
                return;
            }

            if (book_model_id > 0)
            {
                bookmodel.BookTitle = lblBookTitlePageTitle.Text;
                bookmodel.BookTitle = txtBookTitle.Text;
                bookmodel.BookDescription = (string)txtBookDescription.Text;
                bookmodel.Author = txtAuthor.Text;
                bookmodel.BookCategory = txtBookCategory.Text;
                bookmodel.PublisherName = txtPublisherName.Text;
                bookmodel.PublishDate = dtpPublishDate.Value;
                bookmodel.RentalPricePerDay = (decimal)Convert.ToDouble(txtRentalPricePerDay.Text);
                bookmodel.MaxAvailableDayToRent = (short)Convert.ToInt32(maxAvaiableDaysToRent.Text);

                i = EntityBroker.updateBookModel(bookmodel);
            }
            else
            {
                BooksModel bm = new BooksModel();
                    
                bm.BookTitle = (string) txtBookTitle.Text;
                bm.BookDescription = (string)txtBookDescription.Text;
                bm.Author = (string) txtAuthor.Text;
                bm.BookCategory = (string) txtBookCategory.Text;
                bm.PublisherName = (string) txtPublisherName.Text;
                bm.PublishDate = dtpPublishDate.Value;
                bm.RentalPricePerDay = (decimal)Convert.ToDouble(txtRentalPricePerDay.Text);
                bm.MaxAvailableDayToRent = (short)Convert.ToDouble(maxAvaiableDaysToRent.Text);

                i = EntityBroker.createNewBookModel(bm);
            }
            
            
            if (i == 1)
            {
                MessageBox.Show("Book Information Saved");

                ucListBooks booklist = new ucListBooks();
                booklist.setMainWindowRefrence(MainWindowObject);
                MainWindowObject.RequestContentChange(booklist);
                
                ParentWindowObject.Close();
            }
            else { 
                MessageBox.Show("Error in updating. Error code :: {0}", i.ToString());
            }
            
        }

        private void dgvListOfCopies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv == null)
                return;

            if (dgv.CurrentRow.Selected)
            {
                int _book_id = Convert.ToInt32(dgv.SelectedRows[0].Cells["Book ID"].Value);

                Book _book = EntityBroker.getBookByBookID(_book_id);

                if (_book.BookStatus == 1)
                {
                    try
                    {
                        Window_Popup_LendBook w = new Window_Popup_LendBook(_book_id);
                        w.setMainWindowRefrence(MainWindowObject);
                        w.Show();
                        winObj.Close();
                    }
                    catch {
                        MessageBox.Show("Please close the window manually");
                    }
                }
                else {
                    Window_Popup_ReturnBook w = new Window_Popup_ReturnBook(_book_id);
                    w.setMainWindowRefrence(MainWindowObject);
                    w.Show();
                    winObj.Close();
                }
            }   
        }

        Window_Popup_Details winObj = null;
        public void setWinObject(Window_Popup_Details obj)
        {
            winObj = obj;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.BookModelID = book_model_id;
            book.BookStatus = 1;
            int i = EntityBroker.createNewBook(book);
            if (i == 0)
            {
                return;
            }
            //refreshing book list
            //MessageBox.Show(book_model_id.ToString());
            ucDetailsBook ucdb = new ucDetailsBook(book_model_id);
            ucdb.setMainWindowRefrence(MainWindowObject);
            ucdb.setParentWindowRefrence(ParentWindowObject);
            ParentWindowObject.RequestContentChange(ucdb);

            //refreshing min window list
            ucListBooks booklist = new ucListBooks();
            booklist.setMainWindowRefrence(MainWindowObject);
            MainWindowObject.RequestContentChange(booklist);
            

        }

        private bool isNewBookModel() {
            if (book_model_id == 0) {
                return false;
            }
            return true;
        }
        

        
        

    }
}
