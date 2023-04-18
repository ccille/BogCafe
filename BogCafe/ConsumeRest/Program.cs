// See https://aka.ms/new-console-template for more information
using BookLibrary.model;
using ConsumeRest;

Console.WriteLine("Hello, World!");

Consumer consumer = new Consumer();

List<Book> book = await consumer.GetAllAsync();
Console.WriteLine(book);