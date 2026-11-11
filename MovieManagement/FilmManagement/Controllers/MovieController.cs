using System;
using FilmManagement.Models;
using FilmManagement.Services;

namespace FilmManagement.Controllers;

public class MovieController
{
  public readonly MovieService movieService;
  public MovieController()
  {
    movieService = new();
  }

   public void showMenu()
  {
    string answer = "";
    int input;
    do
    {
      System.Console.WriteLine("WELCOME TO THE MOVIE MANAGMENT MENU");
      System.Console.WriteLine(@"
      Add a movie: 1 
      Change the movie's info: 2 
      Delete movie: 3
      Get movies: 4 
      Get movies total duration: 5 
      Get movies avarage duration: 6
      Get movies by genre: 7
      Get movies by title: 8
      Get movies by date time: 9
      Get the top 5 movies: 10
      Get movies that duration is more than 120 min: 11
      Get movies by page: 12
      ");

      System.Console.Write("Choose the option -->");

      if (int.TryParse(Console.ReadLine(), out input))
      {
        switch (input)
        {
          case 1:
          ExecuteNew();
          break;

          case 2:
            ExecuteChangeMovie();
            break;
          case 3:
            ExecuteDeleteMovie();
            break;
          case 4:
            ExecuteGetInfo();
            break;
          case 5:
            ExecuteGetTotaDuration();
            break;
          // case 6:
          //   System.Console.Write("Please enter the genre -->");
          //   string genre = Console.ReadLine();
          //   _bookservice.GetInfo(_bookservice.GetGenre(genre));
          //   break;
          // case 7:
          //   System.Console.Write("Please enter the title -->");
          //   string title = Console.ReadLine();
          //   _bookservice.GetInfo(_bookservice.GetTitle(title));
          //   break;
          // case 8:
          //   System.Console.Write("Please enter the author -->");
          //   string author = Console.ReadLine();
          //   _bookservice.GetInfo(_bookservice.GetSortedBooksByAuthor(author));
          //   break;
          // case 9:
          //   Console.WriteLine(_bookservice.GetPageSumMultipliedByAverage());
          //   break;
          // case 10:
          //   _bookservice.GetInfo(_bookservice.GetTop3());
          //   break;
          // case 11:
          //   System.Console.Write("Enter the id -->");
          //   if (int.TryParse(Console.ReadLine(), out int searchedId))
          //   {
          //     Book[] book = _bookservice.GetBookById(searchedId);
          //     if (book != null)
          //     {
          //       System.Console.WriteLine(_bookservice.GetInfo(book));
        //       }
        //       else
        //       {
        //         System.Console.WriteLine("Didn't find a book with this id");
        //       }
        //     }
        //     else
        //     {
        //       System.Console.WriteLine("Invalid input! ID must be a number.");
        //     }
        //     break;
        //   case 12:
        //     System.Console.Write("Enter Title of book --> ");
        //     string Title = Console.ReadLine();

        //     System.Console.Write("Enter Author --> ");
        //     string Author = Console.ReadLine();

        //     System.Console.Write("Enter Genre --> ");
        //     string Genre = Console.ReadLine();

        //     System.Console.Write("Enter price --> ");
        //     if (double.TryParse(Console.ReadLine(), out double price))
        //     {
        //         System.Console.Write("Enter Page Count --> ");
        //         int.TryParse(Console.ReadLine(), out int pageCount);

        //         System.Console.Write("Enter Publish Year --> ");
        //         int.TryParse(Console.ReadLine(), out int publishYear);

        //         System.Console.Write("Enter Rating --> ");
        //         double.TryParse(Console.ReadLine(), out double rating);

        //         int id = _bookservice.getCount()+ 1;
        //         Book newBook = new Book(id, Title, Author, Genre, price, pageCount, publishYear, rating);
        //         _bookservice.AddBook(newBook);
        //     }
        //     else
        //     {
        //       System.Console.WriteLine("Your input is invalid, please try again");
        //     }
        //     _bookservice.GetInfo();
        //     break;
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

  private void ExecuteNew()
  {
    
    System.Console.Write("Enter Title -->");
    string Title = Console.ReadLine();
    System.Console.Write("Enter Director -->");
    string Director = Console.ReadLine();
    System.Console.Write("Enter Genre -->");
    string Genre = Console.ReadLine();
    System.Console.Write("Enter Duration -->");
    int Duration = int.Parse(Console.ReadLine());
    System.Console.Write("Enter Release Year -->");
    int ReleaseYear = int.Parse(Console.ReadLine());
    System.Console.Write("Enter ImdbRating -->");
    double ImdbRating = double.Parse(Console.ReadLine());

    int newId = movieService.getCount()+1;
    Movie newMovie = new Movie(newId,Title, Director, Genre, Duration, ReleaseYear, ImdbRating);

    
    movieService.AddMovie(newMovie);
    
  }

  private void ExecuteChangeMovie()
  {
    System.Console.Write("Enter movie id to change -->");
    int.TryParse(Console.ReadLine(), out int id);

    System.Console.Write("Enter Title -->");
    string Title = Console.ReadLine();
    System.Console.Write("Enter Director -->");
    string Director = Console.ReadLine();
    System.Console.Write("Enter Genre -->");
    string Genre = Console.ReadLine();
    System.Console.Write("Enter Duration -->");
    int Duration = int.Parse(Console.ReadLine());
    System.Console.Write("Enter Release Year -->");
    int ReleaseYear = int.Parse(Console.ReadLine());
    System.Console.Write("Enter ImdbRating -->");
    double ImdbRating = double.Parse(Console.ReadLine());

    movieService.ChangeMovie(id,Title,Director,Genre,Duration,ReleaseYear,ImdbRating);

  }

  public void ExecuteDeleteMovie()
  {
    System.Console.Write("Enter book's id you want to delete -->");
    int.TryParse(Console.ReadLine(), out int id);

    movieService.DeleteBook(id);
    
  }

  public void ExecuteGetInfo()
  {
   foreach (var item in movieService.GetMovieList())
   {
    System.Console.WriteLine(item.GetInfo());
   }
  }

  public void ExecuteGetTotaDuration()
  {
    Console.WriteLine(movieService.GetTotalDuration());
  }

  public void ExecuteGetAverageDuration()
  {
    Console.WriteLine(movieService.GetTotalAvarageDuration());
  }

  public void ExecuteGetByGenre()
  {
    Console.Write("Enter Genre -->");
    string genre = Console.ReadLine();
    System.Console.WriteLine(movieService.GetMoviesByGenre(genre));
  }

  public void ExecuteGetByTitle()
  {
    Console.Write("Enter Tite -->");
    string title = Console.ReadLine();
    System.Console.WriteLine(movieService.GetMoviesByTitle(title));
  }

  public void ExecuteGetByDateTime()
  {
    System.Console.Write("Enter the start year: ");
    int.TryParse(Console.ReadLine(), out int start);
    System.Console.Write("Enter the end year: ");
    int.TryParse(Console.ReadLine(), out int end);

    foreach (var item in movieService.GetMoviesByReleaseYear(start,end))
    {
      System.Console.WriteLine(item.GetInfo());
    }
    
  }

  public void ExecuteGetTop5()
  {
    foreach (var item in movieService.GetTop5() )
    {
      System.Console.WriteLine(item.GetInfo());
    }
  }

  



  

  

}





  
