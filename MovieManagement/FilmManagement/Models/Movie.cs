using System;

namespace FilmManagement.Models;

public class Movie: BaseEntity
{
  public string? Title { get; set; }
  public string? Director { get; set; }
  public string? Genre { get; set; }
  public int Duration { get; set; }
  public int ReleaseYear { get; set; }
  public double ImdbRating { get; set; }

  public Movie(int id, string Title, string Director, string Genre, int Duration, int ReleaseYear, double ImdbRating) 
    : base(id) 
  {
    this.Title = Title;
    this.Director = Director;
    this.Genre = Genre;
    this.Duration = Duration;
    this.ReleaseYear = ReleaseYear;
    this.ImdbRating = ImdbRating;
  }

  public string GetInfo()
  {
    return $"Id: {Id}, Title: {Title}, Director: {Director}, Genre: {Genre}, Duration: {Duration}, Release Year: {ReleaseYear}, ImdbRating: {ImdbRating}";
    
  }



}
