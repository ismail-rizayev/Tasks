using System;
using LibraryManagmentWithInterface.Models;

namespace LibraryManagmentWithInterface.Data;

public class AppDbContext
{
  public Book[] GetAllBooks()
  {
    Book book1 = new(1, "1984", "George Orwell", "Dystopian", 15.99, 328, 1949, 4.8);
    Book book2 = new(2, "The Master and Margarita", "Mikhail Bulgakov", "Fantasy", 12.50, 448, 1967, 4.9);
    Book book3 = new(3, "Clean Code", "Robert C. Martin", "Programming", 45.00, 464, 2008, 4.9);
    Book book4 = new(4, "Harry Potter", "J.K. Rowling", "Fantasy", 20.99, 332, 1997, 4.8);
    Book book5 = new(5, "The Lord of the Rings", "J.R.R. Tolkien", "Fantasy", 25.50, 423, 1954, 4.9);
    Book book6 = new(6, "Murder on the Orient Express", "Agatha Christie", "Mystery", 14.20, 256, 1934, 4.6);
    Book book7 = new(7, "Dune", "Frank Herbert", "Science Fiction", 18.90, 412, 1965, 4.7);
    Book book8 = new(8, "The Alchemist", "Paulo Coelho", "Adventure", 10.99, 197, 1988, 4.5);
    Book book9 = new(9, "Design Patterns", "Erich Gamma", "Programming", 55.00, 366, 1994, 4.8);
    Book book10 = new(10, "Rich Dad Poor Dad", "Robert Kiyosaki", "Business", 16.50, 336, 1997, 4.6);

    return [book1, book2, book3, book4, book5, book6, book7, book8, book9, book10];
  }

}
