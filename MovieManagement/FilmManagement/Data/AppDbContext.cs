using System;
using FilmManagement.Models;

namespace FilmManagement.Data;

public class AppDbContext
{
  public Movie[] GetAllMovies()
  {
    Movie movie1 = new (1,"The Shawshank Redemption", "Frank Darabont", "Drama", 142, 1994, 9.3);
    Movie movie2 = new (2,"Inception", "Christopher Nolan", "Sci-Fi", 148, 2010, 8.8);
    Movie movie3 = new (3,"Interstellar", "Christopher Nolan", "Sci-Fi", 169, 2014, 8.7);
    Movie movie4 = new (4,"Pulp Fiction", "Quentin Tarantino", "Crime", 154, 1994, 8.9);
    Movie movie5 = new(5,"Django Unchained", "Quentin Tarantino", "Western", 165, 2012, 8.4);
    Movie movie6 = new(6, "Forrest Gump", "Robert Zemeckis", "Drama", 142, 1994, 8.8);
    Movie movie7 = new(7,"Back to the Future", "Robert Zemeckis", "Sci-Fi", 116, 1985, 8.5);
    Movie movie8 = new(8,"Gladiator", "Ridley Scott", "Action", 155, 2000, 8.5);
    Movie movie9 = new(9 , "The Lion King", "Roger Allers", "Animation", 88, 1994, 8.5);
    Movie movie10 = new(10,"Cats", "Tom Hooper", "Musical", 110, 2019, 2.8);

    return [movie1,movie2,movie3,movie4,movie5,movie6,movie7,movie8,movie9,movie10];
    

  }





}
