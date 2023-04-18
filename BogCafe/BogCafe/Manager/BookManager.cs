using BookLibrary.model;

namespace BogCafe.Manager
{
    public class BookManager : IBook
    {
        private static List<Book> _books = new List<Book>()
        {
            new Book(1, "Harry potter and the chamber og secrets", "Rowling", "Fantasy", 2002, "Blue", "harry...", 250),
            new Book(2, "Throne of glass", "Maas", "crime", 2009, "Grenn", "Assassins", 300),
            new Book(3, "Fish", "D", "children", 2008, "Grenn", "Fish", 200),
            new Book(4, "Demon", "E", "Fantasy", 2011, "F", "Green", 250)
        };

        public List<Book> BookIndex(int? lowinterval, int highinterval)
        {
            throw new NotImplementedException();
        }

        public Book Create(Book newbook)
        {
            _books.Add(newbook);
            return newbook;
        }

        public Book Delete(int id)
        {
            Book del = Get(id);
            _books.Remove(del);
            return del;
        }

        public Book Get(int id)
        {
            if (!_books.Exists(b => b.Id == id))
            {
                throw new KeyNotFoundException();
            }
            return _books.Find(b => b.Id == id);
        }

        public List<Book> GetAll()
        {
            return _books;
        }

        public List<Book> GetBookByAuthor(string author)
        {
            return _books.FindAll(b => b.Author.Contains(author.ToLower()));
        }

        public List<Book> GetBooks(string genre)
        {
            return _books.FindAll(b => b.Genre.Contains(genre.ToLower()));
        }

        public List<Book> SearchYear(int? lowYear, int? highYear)
        {
            List<Book> bookyear = (lowYear is null) ? _books : _books.Where(b => b.Year >= lowYear).ToList();

            return (highYear is null) ? bookyear : bookyear.Where(b => b.Year <= highYear).ToList();
        }

        public Book Update(int id, Book updatebook)
        {
            Book upbook = Get(id);
            if (upbook is not null)
            {
                upbook.Id = updatebook.Id;
                upbook.Title = updatebook.Title;
                upbook.Author = updatebook.Author;
                upbook.Forlag = updatebook.Forlag;
                upbook.Resume = updatebook.Resume;
                upbook.Genre = updatebook.Genre;
                upbook.Price = updatebook.Price;
            }
            return upbook;
        }
    }
}
