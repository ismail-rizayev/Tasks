using System;
using System.Runtime.CompilerServices;
using LibraryManagmentWithInterface.Models;
using LibraryManagmentWithInterface.Services;

namespace LibraryManagmentWithInterface.Controllers;

public class BookController
{
  private readonly BookService _bookservice;

  public BookController()
  {
    _bookservice = new();
  }
  
  public void showMenu()
  {
    string answer = "";
    int input;
    do
    {
      System.Console.WriteLine("WELCOME TO THE LIBRARY MANAGMENT MENU");
      System.Console.WriteLine(@"
      Get information of all books: 1 
      Get summ of books price: 2 
      Get avarage of books price: 3
      Get sorted books by ascending price: 4 
      Get sorted books by descending price: 5 
      Get books by Genre: 6
      Get books by Title: 7
      Get sorted books by Author: 8
      Get multiply of books pageCount and avarage of books pageCount: 9
      Get the top 3 books: 10
      Get Book By Id: 11
      Add Book: 12
      ");

      System.Console.Write("Choose the option -->");

      if (int.TryParse(Console.ReadLine(), out input))
      {
        switch (input)
        {
          case 1:
            _bookservice.GetInfo();
            break;
          case 2:
            Console.WriteLine(_bookservice.GetSumOfBooks());
            break;
          case 3:
            Console.WriteLine(_bookservice.GetDivededPrice());
            break;
          case 4:
            _bookservice.GetInfo(_bookservice.SortByAsc());
            break;
          case 5:
            _bookservice.GetInfo(_bookservice.SortByDesc());
            break;
          case 6:
            System.Console.Write("Please enter the genre -->");
            string genre = Console.ReadLine();
            _bookservice.GetInfo(_bookservice.GetGenre(genre));
            break;
          case 7:
            System.Console.Write("Please enter the title -->");
            string title = Console.ReadLine();
            _bookservice.GetInfo(_bookservice.GetTitle(title));
            break;
          case 8:
            System.Console.Write("Please enter the author -->");
            string author = Console.ReadLine();
            _bookservice.GetInfo(_bookservice.GetSortedBooksByAuthor(author));
            break;
          case 9:
            Console.WriteLine(_bookservice.GetPageSumMultipliedByAverage());
            break;
          case 10:
            _bookservice.GetInfo(_bookservice.GetTop3());
            break;
          case 11:
            System.Console.Write("Enter the id -->");
            if (int.TryParse(Console.ReadLine(), out int searchedId))
            {
              Book[] book = _bookservice.GetBookById(searchedId);
              if (book != null)
              {
                System.Console.WriteLine(_bookservice.GetInfo(book));
              }
              else
              {
                System.Console.WriteLine("Didn't find a book with this id");
              }
            }
            else
            {
              System.Console.WriteLine("Invalid input! ID must be a number.");
            }
            break;
          case 12:
            System.Console.Write("Enter Title of book --> ");
            string Title = Console.ReadLine();

            System.Console.Write("Enter Author --> ");
            string Author = Console.ReadLine();

            System.Console.Write("Enter Genre --> ");
            string Genre = Console.ReadLine();

            System.Console.Write("Enter price --> ");
            if (double.TryParse(Console.ReadLine(), out double price))
            {
                System.Console.Write("Enter Page Count --> ");
                int.TryParse(Console.ReadLine(), out int pageCount);

                System.Console.Write("Enter Publish Year --> ");
                int.TryParse(Console.ReadLine(), out int publishYear);

                System.Console.Write("Enter Rating --> ");
                double.TryParse(Console.ReadLine(), out double rating);

                int id = _bookservice.getCount()+ 1;
                Book newBook = new Book(id, Title, Author, Genre, price, pageCount, publishYear, rating);
                _bookservice.AddBook(newBook);
            }
            else
            {
              System.Console.WriteLine("Your input is invalid, please try again");
            }
            _bookservice.GetInfo();
            break;
        }
      } 
      else
      {
        System.Console.WriteLine("Invalid input! Option must be a number.");
      }

      do
      {
        System.Console.Write("Do you want to continue (y/n) --> ");
        answer = Console.ReadLine()?.Trim().ToLower();
      } 
      while (answer != "y" && answer != "n");

    } 
    while (answer == "y");

  } 
}