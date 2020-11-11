using System.Linq;

namespace RpgTenebraV4.Models.DataManager
{
    public class BookDataManager
    {
        BookStoreContext _bookStoreContext = new BookStoreContext();
        public Book Get(long id)
        {
            _bookStoreContext.ChangeTracker.LazyLoadingEnabled = false;

            var book = _bookStoreContext.Book
                  .SingleOrDefault(b => b.Id == id);

            if (book == null)
            {
                return null;
            }

            _bookStoreContext.Entry(book)
                .Collection(b => b.BookAuthors)
                .Load();

            _bookStoreContext.Entry(book)
                .Reference(b => b.Publisher)
                .Load();

            return book;
        }
    }
}
