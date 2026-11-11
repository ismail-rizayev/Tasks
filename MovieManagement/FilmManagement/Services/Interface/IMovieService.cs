using System;
using FilmManagement.Models;

namespace FilmManagement.Services.Interface;

public interface IMovieService
{
  Movie[] GetMovieList();
  void AddMovie(Movie movie);
  int getCount();
  bool ChangeMovie(int id, string Title, string Director, string Genre, int Duration, int ReleaseYear, double ImdbRating);
  bool DeleteBook(int id);
  int GetTotalDuration();
  double GetTotalAvarageDuration();
  Movie[] GetMoviesByGenre(string serchedGenre);
  Movie[] GetMoviesByTitle(string serchedTitle);
  Movie[] GetMoviesByReleaseYear(int minYear, int MaxYear);
  Movie[] GetTop5();
  Movie GetMoviesMoreThanTwoHours();
  Movie[] MoviePages(int pageNumber, int pageSize = 3);

  


}
