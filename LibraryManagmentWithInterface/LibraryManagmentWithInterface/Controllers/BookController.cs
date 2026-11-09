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
    string answer;
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
        }
      }
      else
      {
        System.Console.WriteLine("Your input is invalid, please try again");
      }

      do
      {
        System.Console.Write("Do you want to continue (y/n) -->");
        answer = Console.ReadLine();
      }while(answer != "y" || answer != "n");

    }while(answer == "y");
    
  }
}
