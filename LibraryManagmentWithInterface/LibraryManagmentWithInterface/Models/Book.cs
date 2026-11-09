using System;

namespace LibraryManagmentWithInterface.Models;

public class Book
{
  public int Id { get; set; }
  public string? Title { get; set; }
  public string?  Author { get; set; }
  public string? Genre { get; set; }
  public double Price { get; set; }
  public int PageCount { get; set; }
  public int PublishYear { get; set; }
  public double Rating { get; set; }

  public Book(int Id, string Title, string Author, string Genre, double Price, int PageCount, int PublishYear, double Rating)
  {
    this.Id = Id;
    this.Title = Title;
    this.Author = Author;
    this.Genre = Genre;
    this.Price = Price;
    this.PageCount = PageCount;
    this.PublishYear = PublishYear;
    this.Rating = Rating;
    
  }

}
