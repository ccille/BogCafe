using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.model
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }

        public int Year { get; set; }

        public string Forlag { get; set; }

        public string Resume { get; set; }

        public int Price { get; set; }

        public Book(int id, string title, string author, string genre,int year, string forlag, string resume, int price)
        {
            Id = id;
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
            Forlag = forlag;
            Resume = resume;
            Price = price;
        }

        public Book()
        {

        }

        public override string ToString()
        {
            return $"Id = {Id}, Title = {Title}, Author = {Author}, Genre = {Genre}, Year = {Year}, Forlag = {Forlag}, Resume = {Resume}, Price = {Price}";
        }
    }
}
