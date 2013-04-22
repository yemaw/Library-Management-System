using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team6A_LibraryManagementSystem
{
    class EntityBroker
    {
        public static LibraryDBEntities entity = new LibraryDBEntities();
        
        //return the whole book model object
        public static IQueryable getBooksModels()
        {
            var v = from bm in entity.BooksModels select bm;
            return v;
        }

        //#TODO::
        public static BooksModel getBookModelByID(int _book_model_id)
        {
            BooksModel v = entity.BooksModels.Where(x => x.BookModelId == _book_model_id).First();
            return v;
        }
        
        public static IQueryable getBookModelByTitle(string _book_title) {
            var v = entity.BooksModels.Where(x=> x.BookTitle.Contains(_book_title));
            return v;
        }

        //return the total number of a book
        public static int getNumberOfBooksInLibraryByBookModelID(int _book_model_id)
        {
            int i = entity.Books.Where(x => x.BookModelID == _book_model_id).Count();
            return i;
        }

        //return the number of avaiable books to rent for a specific book
        public static int getNumberOfAvaiableBooksToRentInLibraryByBookModelID(int _book_model_id) {
            int i = entity.Books.Where(x => x.BookModelID == _book_model_id).Where(x=> x.BookStatus == 1).Count();
            return i;
        }

        public static int updateBookModelEntity (BooksModel _book_model){
            var book_model_row = (from bm in entity.BooksModels
                        where bm.BookModelId == _book_model.BookModelId
                        select bm).FirstOrDefault();

            book_model_row = _book_model;

            return entity.SaveChanges();
        }

        public static IQueryable getBooksByBookModelID(int _book_model_id) {

            //var books = from b in entity.Books where b.BookModelID == _book_model_id select new { b.BookID , b.BookStatus,Status = (b.BookStatus == 0) ? "Rented" : (b.BookStatus == 1) ? "Avaiable" : "Not Avaiable" };
            var books = from b in entity.Books select b;
            return books;
        }

        //public static LibTran getTransationByBookID(int _book_id){
        //    LibTran lt = from t in LibTran
        //                orderby t.LendDate descending, t.Book descending
        //                select person.Name;
        //    return lt;
        //}


    }
}
