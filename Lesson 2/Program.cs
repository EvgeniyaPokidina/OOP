
using Lesson_2;
using System.Threading.Channels;
//1
//DynamicArray array = new DynamicArray();
//array.Print();
//array.Arrange();
//array.Print();

//2
Library library = new Library();
library.AddBook(new Book("Война и мир", "Лев Толстой", 1869));
library.AddBook(new Book("Собачье сердце", "Михаил Булгаков", 1925));
library.Print();
library.SortBooks();
Console.Write("Книги после сортировки");
library.Print();
library.RemoveBook("Война и мир");






