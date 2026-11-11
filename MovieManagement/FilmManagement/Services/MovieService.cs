using System;
using FilmManagement.Data;
using FilmManagement.Models;
using FilmManagement.Services.Interface;

namespace FilmManagement.Services;

public class MovieService : IMovieService
{
  private readonly AppDbContext _context;
  private Movie[] movies;

  public MovieService()
  {
    _context = new();
    movies = _context.GetAllMovies();
  }

  public Movie[] GetMovieList()
  {
    return movies.ToArray();
  }

  public void AddMovie(Movie movie)
{
    Array.Resize(ref movies, movies.Length + 1);
    movies[movies.Length - 1] = movie;
}

  public int getCount()
  {
    return movies.Length;
  }

  public bool ChangeMovie(int id, string title, string director, string genre, int duration, int releaseYear, double imdbRating)
{
    
    int index = Array.FindIndex(movies, m => m.Id == id);

    
    if (index == -1)
    {
        Console.WriteLine($"Movie with ID {id} not found!");
        return false;
    }

    movies[index].Title = title;
    movies[index].Director = director;
    movies[index].Genre = genre;
    movies[index].Duration = duration;
    movies[index].ReleaseYear = releaseYear;
    movies[index].ImdbRating = imdbRating;

    return true;
}
  public bool DeleteBook(int id)
  {
    if (!movies.Any(m => m.Id == id))
    {
        return false; 
    }

    movies = movies.Where(m => m.Id != id).ToArray();
    return true;
  }

  public int GetTotalDuration()
  {
    return movies.Sum(movie => movie.Duration);
  }

  public double GetTotalAvarageDuration()
  {
    return movies.Average(movie => movie.Duration);
  }

  public Movie[] GetMoviesByGenre(string serchedGenre)
  {
    return movies.Where(movie => movie.Genre == serchedGenre).ToArray();
  }

  public Movie[] GetMoviesByTitle(string serchedTitle)
  {
    return movies.Where(movie => movie.Title== serchedTitle).ToArray();
  }

  public Movie[] GetMoviesByReleaseYear(int minYear, int MaxYear)
  {
    return movies.Where(movie => movie.ReleaseYear>=minYear && movie.ReleaseYear<=MaxYear).ToArray();
  }

  public Movie[] GetTop5()
  {
    return movies.OrderByDescending(movie =>movie.ImdbRating).Take(5).ToArray();
  }

  public Movie GetMoviesMoreThanTwoHours()
  {
    return movies.FirstOrDefault(movie => movie.Duration >= 120);
  }

  public Movie[] MoviePages(int pageNumber, int pageSize = 3)
  {
    if (pageNumber < 1)  pageNumber = 1;
    return movies.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToArray();
  }


}
