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

        private void ucListBooks_Load(object sender, EventArgs e)
        {
            

           // var query = from bm in entity.BooksModels
           //             select new {bm.BookTitle};

           //int i = entity.BooksModels.Where(x => x.BookModelId == 1).First().Books.Count;

           //txtSearchByBookID.Text = i.ToString();
            
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

                ucDetailsBook ucObj = new ucDetailsBook(book_model_id);
                Window_Popup_Details pd = new Window_Popup_Details(ucObj);
                ucObj.setWinObject(pd);
                pd.Show();
            }
        }

        private void btnSearchByBookID_Click(object sender, EventArgs e)
        {
            
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
                    bookmodel.MaxAvailableDayToRent
                    );
            }
            
            dgvBooksList.DataSource = dt;
        }


















        //-----------------------------------------------------------------------------------------------------
        private void llbClearSearchBookByTitle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtSearchByBookTitle.Text = "";

            //BooksModel bm = new BooksModel();
            //bm.BookTitle = "Hello Buddy";
            //bm.BookCategory = "Lit";
            //bm.Author = "Someone";
            //entity.AddToBooksModels(bm);
            //entity.SaveChanges();

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
                    bookmodel.MaxAvailableDayToRent
                    );
            }
            dgvBooksList.DataSource = dt;
        }

       

        

        

        


    }
}
