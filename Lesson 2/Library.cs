using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }
    }
    internal class Library
    {
        private List<Book> books;
        public Library()
        {
            books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Книга {book.Title} добавлена в библиотеку");
        }
        public void RemoveBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title.ToLower() == title.ToLower())
                {
                    books.RemoveAt(i);
                    Console.WriteLine($"Книга {title} удалена из библиотеки.");
                    return;
                }
            }
            Console.WriteLine($"Книга {title} не найдена в библиотеке.");
        }
        public void SortBooks()
        {
            books = books.OrderBy(b => b.Year).ToList();
        }
        public void Print()
        {
            Console.WriteLine("Книги в библиотеке:");
            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
              
            }
        }
    }
}


   

    

    



