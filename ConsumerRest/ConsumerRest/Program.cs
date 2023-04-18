// See https://aka.ms/new-console-template for more information
using BookLibrary.model;
using ConsumerRest;

Console.WriteLine("Hello, World!");

Consumer consumer = new Consumer();

List<Book> book = await consumer.GetAllAsync();

Console.WriteLine("All books");
foreach (Book b in book)
{
    Console.WriteLine(b);
}

Console.WriteLine("Changed book with id 1");
Book modifyBook = new Book() 
    { Id = 1, Title = "Harry potter and the chamber og secrets", Author = "Rowling", Genre = "Fantasy", Year = 2002, Forlag = "Green", Resume = "SSS", Price = 300 };

Book returB = await consumer.PutAsync(1, modifyBook);

Console.WriteLine(returB);

Console.WriteLine("delete book with id 3");
Book delete = new Book();

Book deleteb = await consumer.DeleteAsync(3);

Console.WriteLine(deleteb);

Console.WriteLine("Create new book");
Book newbook = new Book()
    { Id = 7, Title = "Blood and ash", Author = "J", Genre = "Fantasy", Year = 2015, Forlag = "Red", Resume = "SS", Price = 350 };

Book newb = await consumer.PostAsync(newbook);

Console.WriteLine(newb);