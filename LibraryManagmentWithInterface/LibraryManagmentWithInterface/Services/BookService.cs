using System;
using LibraryManagmentWithInterface.Data;
using LibraryManagmentWithInterface.Models;

namespace LibraryManagmentWithInterface.Services;

public class BookService : IBookService
{
  private readonly AppDbContext _context;
  private readonly Book[] books;

  public BookService()
  {
    _context = new();
    books = _context.GetAllBooks();
  }

  
  public Book[] GetInfo(Book[] booksToPrint = null)
  {
    Book[] targetBooks = booksToPrint ?? books;

    foreach (var item in targetBooks)
    {
        System.Console.WriteLine($"id : {item.Id}, title : {item.Title}, author : {item.Author}, genre : {item.Genre}, price : {item.Price}, pagecount : {item.PageCount}, publish year : {item.PublishYear}, rating : {item.Rating}");
    }
    
    return targetBooks;
  }

  public double GetSumOfBooks()
  {
    return books.Sum(book => book.Price);
  }

  public double GetDivededPrice()
  {
    int count = books.Length;
    double sum = books.Sum(book => book.Price);
    return sum/count;
  }

  public Book[] SortByAsc()
  {
    return books.OrderBy(book => book.Price).ToArray();
  }

  public Book[] SortByDesc()
  {
    return books.OrderByDescending(book => book.Price).ToArray();
  }

  public Book[] GetGenre(string searchedGenre)
  {
    return books.Where(book => book.Genre.ToLower() == searchedGenre.ToLower()).ToArray();
  }

  public Book[] GetTitle(string searchedTitle)
  {
    return books.Where(book => book.Title.ToLower() == searchedTitle.ToLower()).ToArray();
  }

  public Book[] GetSortedBooksByAuthor(string searchedAuthor)
  {
    return books.Where(book => book.Author == searchedAuthor).OrderBy(book => book.Title).ToArray();
  }
  
  public double GetPageSumMultipliedByAverage()
  {
    int pageSum = books.Sum(book => book.PageCount);
    double pageAvarage = books.Average(book => book.PageCount);
    return pageSum*pageAvarage;
  }

  public Book[] GetTop3()
  {
    return books.OrderByDescending(book => book.Rating).Take(3).ToArray();

  }


}
