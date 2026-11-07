using System;
using LibraryManagment.Data;
using LibraryManagment.Models;

namespace LibraryManagment.Services;

public class BookService
{
  private readonly AppDbContext _context;
  public Book[] books;
  public BookService()
  {
  _context  = new();
  books = _context.GetAllBooks();
  }

  public Book[] GetInfo()
  {
    foreach (var item in books)
    {
      System.Console.WriteLine($"id --> {item.Id}, Name --> {item.Name}, pages --> {item.PageCount}, price --> {item.Price}");
    }

    return books;
  }

  public Book[] GetBookById(int serchedId)
  {
    return books.Where(book => book.Id == serchedId).ToArray();
  }

  public Book[] AddBook(int id, string name, int pages, double price)
  {
   
    Book newBook = new Book(id, name, pages, price);

    books = books.Append(newBook).ToArray();

    System.Console.WriteLine("The book succesfully added!");

    return books;
  }

  public Book[] DeleteBookById(int idRemove)
  {
   
    books = books.Where(book => book.Id != idRemove).ToArray();

    GetInfo();

    return books;
  }

  public Book[] UpdateBook(int idToUpdate, string newName, int newPages, double newPrice)
  {
    
    for (int i = 0; i < books.Length; i++)
    {
        
        if (books[i].Id == idToUpdate)
        {
            books[i] = new Book(idToUpdate, newName, newPages, newPrice);
            
            System.Console.WriteLine($"\n--- The book with id: {idToUpdate} successfully added! ---");
            
            GetInfo(); 
            
            return books; 
        }
    }
    System.Console.WriteLine($"\n--- Error: The book with id: {idToUpdate} not found! ---");
    return books;
  }

  public Book[] SearchByName(string serchedName)
  {
    return books.Where(book => book.Name == serchedName).ToArray();;
  }
  
  public Book[] SortByAsc()
  {
    return books.OrderBy(book => book.Price).ToArray();
  }

  public Book[] SortByDesc()
  {
    return books.OrderByDescending(book => book.Price).ToArray();
  }

  public double TotalPrice()
  {
    return books.Sum(book => book.Price);
  }

  public Book MostExpensive()
  {
    return books.MaxBy(book => book.Price);
  }

}
