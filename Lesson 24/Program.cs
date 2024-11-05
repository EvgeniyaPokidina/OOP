using System.Text.Json;
using System;
using System.Collections.Generic;

public class Book
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? Genre { get; set; }
    public int Year { get; set; }

    public Book(string? title, string? author, string? genre, int year)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Year = year;
    }
    public override string ToString()
    {
        return $"Название книги: {Title}, Автор: {Author}, Жанр: {Genre}, Год издания: {Year}";
    }
}
public class Library
{
    private List<Book> books = new List<Book>();
    public void AddBook(Book book)=>books.Add(book);
    public void DisplayBooks()
    {
        Console.WriteLine("Список книг в библиотеке:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
   
  public void SerializeBooks(string filePath)
    {
        string jsonList = JsonSerializer.Serialize(books);
        File.WriteAllText(filePath, jsonList);
    }
}
class Program
{
    public static void Main()
    {
        Library library = new Library();
        library.AddBook(new Book("Мастер и Маргарита", "Михаил Булгаков", "Роман", 1967));
        library.AddBook(new Book("Война и мир", "Лев Толстой", "Исторический роман", 1869));
        library.DisplayBooks();

        string filePath = "library.json";
        library.SerializeBooks(filePath);
    }
    
}
