using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team6A_LibraryManagementSystem
{
    class EntityBroker
    {
        //return the whole book model object
        public static IQueryable getBooksModels()
        {
            LibraryDBEntities entity = new LibraryDBEntities();

            var v = from bm in entity.BooksModels select bm;
            return v;
        }

        public static BooksModel getBookModelByID(int _book_model_id)
        {
            LibraryDBEntities entity = new LibraryDBEntities();

            BooksModel v = entity.BooksModels.Where(x => x.BookModelId == _book_model_id).First();
            return v;
        }
        
        public static IQueryable getBookModelByTitle(string _book_title) {
            LibraryDBEntities entity = new LibraryDBEntities();

            var v = entity.BooksModels.Where(x=> x.BookTitle.Contains(_book_title));
            return v;
        }

        //return the total number of a book
        public static int getNumberOfBooksInLibraryByBookModelID(int _book_model_id)
        {
            LibraryDBEntities entity = new LibraryDBEntities();

            int i = entity.Books.Where(x => x.BookModelID == _book_model_id).Count();
            return i;
        }

        //return the number of avaiable books to rent for a specific book
        public static int getNumberOfAvaiableBooksToRentInLibraryByBookModelID(int _book_model_id) {
            LibraryDBEntities entity = new LibraryDBEntities();

            int i = entity.Books.Where(x => x.BookModelID == _book_model_id).Where(x=> x.BookStatus == 1).Count();
            return i;
        }

        public static int updateBookModelEntity (BooksModel _book_model){
            LibraryDBEntities entity = new LibraryDBEntities();

            var book_model_row = (from bm in entity.BooksModels
                        where bm.BookModelId == _book_model.BookModelId
                        select bm).FirstOrDefault();

            book_model_row = _book_model;

            return entity.SaveChanges();
        }

        public static IQueryable getBooksByBookModelID(int _book_model_id) {
            LibraryDBEntities entity = new LibraryDBEntities();


            //var books = from b in entity.Books where b.BookModelID == _book_model_id select new { b.BookID , b.BookStatus,Status = (b.BookStatus == 0) ? "Rented" : (b.BookStatus == 1) ? "Avaiable" : "Not Avaiable" };
            var books = from b in entity.Books where b.BookModelID == _book_model_id select b;
            return books;
        }

        public static LibTran getLastTransationByBookID(int _book_id)
        {
            LibraryDBEntities entity = new LibraryDBEntities();

            var q = from t in entity.LibTrans
                    where t.BookID == _book_id
                    group t by t.BookID into g
                    select new
                    {
                        Max = g.Max(b => b.TransactionID),
                        
                    };
            
            int i = 0;
            foreach (var data in q)
            {
                i = data.Max;
                break;
            }
            LibTran tranObj = new LibTran();
            if (i > 1) {
                tranObj = entity.LibTrans.Where(x => x.TransactionID == i).First();
            }
            
            return tranObj;
        }

        public static Book getBookByBookID(int _book_id) {
            LibraryDBEntities entity = new LibraryDBEntities();

            Book b = entity.Books.Where(x => x.BookID == _book_id).SingleOrDefault();
            return b;
        }
        
        public static Member getMemberByMemberID(int _member_id) {
            LibraryDBEntities entity = new LibraryDBEntities();

            Member m = entity.Members.Where(x => x.MemberID == _member_id).SingleOrDefault();
            return m;
        }

        public static int updateBookModel(BooksModel bm) {
            LibraryDBEntities entity = new LibraryDBEntities();

            var book_model_row = entity.BooksModels.Where(x => x.BookModelId == bm.BookModelId).SingleOrDefault();

            book_model_row.BookTitle = bm.BookTitle;
            book_model_row.BookDescription = bm.BookDescription;
            book_model_row.Author = bm.Author;
            book_model_row.PublisherName = bm.PublisherName;
            book_model_row.PublishDate = bm.PublishDate;
            book_model_row.BookCategory = bm.BookCategory;
            book_model_row.MaxAvailableDayToRent = bm.MaxAvailableDayToRent;
            book_model_row.RentalPricePerDay = bm.RentalPricePerDay;

            int i = entity.SaveChanges();
            return i;
        }

        public static int updateTransaction(LibTran tran) {
            LibraryDBEntities entity = new LibraryDBEntities();

            var tran_row = entity.LibTrans.Where(x => x.TransactionID == tran.TransactionID).SingleOrDefault();

            tran_row.ReturnDate = tran.ReturnDate;
            tran_row.ChargeAmount = tran.ChargeAmount;

            int i = entity.SaveChanges();
            return i;    
        }

        public static int updateBook(Book book) {
            LibraryDBEntities entity = new LibraryDBEntities();

            var book_row = entity.Books.Where(x => x.BookID == book.BookID).SingleOrDefault();

            book_row.BookStatus = book.BookStatus;
            
            int i = entity.SaveChanges();
            return i;
        }

        public static int createNewBook(Book _book) {
            LibraryDBEntities entity = new LibraryDBEntities();
            Book book = new Book();
            book.BookModelID = _book.BookModelID;
            book.BookStatus = _book.BookStatus;
            entity.AddToBooks(book);
            int i = entity.SaveChanges();
            return i;
        }


        public static int createNewBookModel(BooksModel _book_model) {
            LibraryDBEntities entity = new LibraryDBEntities();
            BooksModel book_model = new BooksModel();
            
            book_model.BookTitle = _book_model.BookTitle;
            book_model.BookDescription = _book_model.BookDescription;
            book_model.Author = _book_model.Author;
            book_model.PublisherName = _book_model.PublisherName;
            book_model.BookCategory = _book_model.BookCategory;
            book_model.PublishDate = _book_model.PublishDate;
            book_model.RentalPricePerDay = _book_model.RentalPricePerDay;
            book_model.MaxAvailableDayToRent = _book_model.MaxAvailableDayToRent;

            entity.AddToBooksModels(book_model);
            
            int i = entity.SaveChanges();
            return i;
        }

        public static int updateMember(Member _member) {
            LibraryDBEntities entity = new LibraryDBEntities();
            var member_row = entity.Members.Where(x => x.MemberID == _member.MemberID).SingleOrDefault();

            member_row.MemberName = _member.MemberName;
            member_row.Address = _member.Address;
            member_row.PhoneNumber = _member.PhoneNumber;
            member_row.NIRC = _member.NIRC;
            member_row.Email = _member.Email;

            int i = entity.SaveChanges();
            return i;
        }

        public static int createMember(Member _member)
        {
            LibraryDBEntities entity = new LibraryDBEntities();
            
            Member mb = new Member();
            mb.MemberName = _member.MemberName;
            mb.Address = _member.Address;
            mb.PhoneNumber = _member.PhoneNumber;
            mb.NIRC = _member.NIRC;
            mb.Email = _member.Email;

            entity.AddToMembers(mb);

            int i = entity.SaveChanges();
            return i;
        }
    }
}
