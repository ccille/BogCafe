using BookLibrary.model;

namespace BogCafe.Manager
{
    public interface IBook
    {
        List<Book> GetAll();

        Book Get(int id);

        Book Create(Book newbook);

        Book Delete(int id);

        Book Update(int id, Book updatebook);

        List<Book> GetBooks(string genre);

        List<Book> GetBookByAuthor(string author);

        List<Book> SearchYear(int? lowYear, int? highYear);

        List<Book> BookIndex(int? lowinterval, int highinterval);

    }
}
