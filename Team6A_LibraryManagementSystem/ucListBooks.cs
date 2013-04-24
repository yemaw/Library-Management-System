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
    public partial class ucListBooks : ucList
    {
        LibraryDBEntities entity;
        DataTable dt;
        Window_Master MainWindowObject;
        
        public ucListBooks()
        {
            InitializeComponent();

            entity = new LibraryDBEntities();
            dt = new DataTable();

            dt.Columns.Add("Book Title", typeof(string));
            dt.Columns.Add("Number of Books", typeof(string));
            dt.Columns.Add("Avaiable to Rent", typeof(string));
            dt.Columns.Add("Author", typeof(string));
            dt.Columns.Add("Book Category", typeof(string));
            dt.Columns.Add("Max Available Days To Rent", typeof(string));
            dt.Columns.Add("Book Model ID", typeof(int));
        }

        public void setMainWindowRefrence(Window_Master window)
        {
            MainWindowObject = window;
        }
        
        private void ucListBooks_Load(object sender, EventArgs e)
        {    
            var bookmodels = EntityBroker.getBooksModels();
            dt.Rows.Clear();
            foreach (BooksModel bookmodel in bookmodels)
            {
                dt.Rows.Add(
                    bookmodel.BookTitle,
                    EntityBroker.getNumberOfBooksInLibraryByBookModelID(bookmodel.BookModelId),
                    EntityBroker.getNumberOfAvaiableBooksToRentInLibraryByBookModelID(bookmodel.BookModelId),
                    bookmodel.Author,
                    bookmodel.BookCategory,
                    bookmodel.MaxAvailableDayToRent,
                    bookmodel.BookModelId
                    );    
            }
            
            dgvBooksList.DataSource = dt;
            dgvBooksList.Refresh();   
        }

        private void dgvBooksList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                int book_model_id = Convert.ToInt32(dgv.SelectedRows[0].Cells["Book Model ID"].Value);
                
                ucDetailsBook ucdb = new ucDetailsBook(book_model_id);
                Window_Popup_Details pd = new Window_Popup_Details(ucdb);
                ucdb.setWinObject(pd);
                ucdb.setMainWindowRefrence(MainWindowObject);
                ucdb.setParentWindowRefrence(pd);
                pd.ShowDialog();
            }
        }

        private void btnSearchByBookID_Click(object sender, EventArgs e)
        {
            int _book_id = 0;
            try
            {
                _book_id = Convert.ToInt32(txtSearchByBookID.Text);
            }
            catch {
                MessageBox.Show("Book ID you entered is not valid type.");
                return;
            }
            
            Book _book = new Book();

            _book = EntityBroker.getBookByBookID(_book_id);

            if(_book == null) {
                MessageBox.Show("Book ID you entered is not in the library.");
                return;
            }

            if (_book.BookStatus == 1)
            {
                Window_Popup_LendBook w = new Window_Popup_LendBook(_book_id);
                w.setMainWindowRefrence(MainWindowObject);
                w.ShowDialog();
            }
            else if (_book.BookStatus == 0)
            {
                Window_Popup_ReturnBook w = new Window_Popup_ReturnBook(_book_id);
                w.setMainWindowRefrence(MainWindowObject);
                w.ShowDialog();
            }
        }

        private void btnSearchByBookTitle_Click(object sender, EventArgs e)
        {
            var bookmodels = EntityBroker.getBookModelByTitle(txtSearchByBookTitle.Text);
            dt.Rows.Clear();
            foreach (BooksModel bookmodel in bookmodels)
            {
                dt.Rows.Add(
                    bookmodel.BookTitle,
                    EntityBroker.getNumberOfBooksInLibraryByBookModelID(bookmodel.BookModelId),
                    EntityBroker.getNumberOfAvaiableBooksToRentInLibraryByBookModelID(bookmodel.BookModelId),
                    bookmodel.Author,
                    bookmodel.BookCategory,
                    bookmodel.MaxAvailableDayToRent,
                    bookmodel.BookModelId
                    );
            }
            
            dgvBooksList.DataSource = dt;
        }

        private void llbClearSearchBookByTitle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtSearchByBookTitle.Text = "";
            try
            {
                ucListBooks booklist = new ucListBooks();
                booklist.setMainWindowRefrence(MainWindowObject);

                MainWindowObject.RequestContentChange(booklist);
            }
            catch { }
        }

        private void llbClearSearchByBookID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtSearchByBookID.Text = "";
        }
    }
}
