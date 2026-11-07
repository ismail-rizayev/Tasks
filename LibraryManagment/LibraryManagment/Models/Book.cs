using System;

namespace LibraryManagment.Models;

public class Book: BaseEntity
{
  public string Name { get; set; }
  public int PageCount { get; set; }
  public double Price { get; set; }

  public Book(int id,string Name, int PageCount, double Price)
  {
    Id = id;
    this.Name = Name;
    this.PageCount = PageCount;
    this.Price = Price;
  }

}
