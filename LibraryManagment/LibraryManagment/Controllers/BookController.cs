using System;
using LibraryManagment.Data;
using LibraryManagment.Models;
using LibraryManagment.Services;

namespace LibraryManagment.Controllers;

public class BookController
{
  private readonly BookService _bookservice;

  public BookController()
  {
    _bookservice = new();
  }

  public void ExecuteGetInfo()
  {
    _bookservice.GetInfo();
  }

  public void ExecuteGetBookById()
  {
    System.Console.Write("Enter the id -->");
    int id = int.Parse(Console.ReadLine());

    System.Console.WriteLine(_bookservice.GetBookById(id));
    
  }

  public void ExecuteAddBook()
  {
    System.Console.Write("Enter Book Id: ");
    int id = int.Parse(System.Console.ReadLine()); 

    System.Console.Write("Enter name of book: ");
    string? name = System.Console.ReadLine();

    System.Console.Write("Enter the count of pages: ");
    int pages = int.Parse(System.Console.ReadLine());

    System.Console.Write("Enter price: ");
    double price = double.Parse(System.Console.ReadLine());

    System.Console.WriteLine(_bookservice.AddBook(id,name,pages,price));

  }

  public void ExecuteDeleteBookById()
  {
    System.Console.Write("Enter the id -->");
    int a = int.Parse(Console.ReadLine());

    System.Console.WriteLine(_bookservice.DeleteBookById(a));
  }

  public void ExecuteUpdateBook()
  {
    System.Console.Write("Enter the id -->");
    int idToupdate = int.Parse(Console.ReadLine());

    System.Console.Write("Enter the new Name -->");
    string newName = Console.ReadLine();

    System.Console.Write("Enter the new amount of pages -->");
    int newPages = int.Parse(Console.ReadLine());

    System.Console.Write("Enter the new price -->");
    double newPrice = double.Parse(Console.ReadLine());

    System.Console.WriteLine(_bookservice.UpdateBook(idToupdate, newName, newPages, newPrice));

  }

  public void ExecuteSearchByName()
  {
    string SearchedName = Console.ReadLine();
    System.Console.WriteLine(_bookservice.SearchByName(SearchedName));
  }

  public void ExecuteSortByAsc()
  {
    System.Console.WriteLine(_bookservice.SortByAsc());
  }

  public void ExecuteSortByDesc()
  {
    System.Console.WriteLine(_bookservice.SortByDesc());
  }

  public void ExecuteTotalAge()
  {
    System.Console.WriteLine(_bookservice.TotalPrice());
  }

  public void ExecuteMostExpensive()
  {
    
    Book expensiveBook = _bookservice.MostExpensive();
    
    System.Console.WriteLine($"id --> {expensiveBook.Id}, Name --> {expensiveBook.Name}, price --> {expensiveBook.Price}");
  }


}
