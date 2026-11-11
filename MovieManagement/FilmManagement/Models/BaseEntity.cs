using System;

namespace FilmManagement.Models;

public class BaseEntity
{
  public int Id { get; set; }
  public BaseEntity(int id)
  { 
    this.Id = id;
    
  }

}
