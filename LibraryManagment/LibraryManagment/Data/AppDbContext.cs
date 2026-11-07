using System;
using LibraryManagment.Models;
using Microsoft.VisualBasic;

namespace LibraryManagment.Data;

public class AppDbContext
{
  public Book[] GetAllBooks()
  {
    Book book1 = new(1, "Fire and Water", 320, 15.90);
    Book book2 = new(2, "The Great Gatsby", 218, 10.99);
    Book book3 = new(3, "1984", 328, 12.50);
    Book book4 = new(4, "To Kill a Mockingbird", 281, 14.20);
    Book book5 = new(5, "Pride and Prejudice", 432, 9.99);
    Book book6 = new(6, "The Hobbit", 310, 18.00);
    Book book7 = new(7, "Dune", 412, 22.50);
    Book book8 = new(8, "Fahrenheit 451", 249, 11.99);
    Book book9 = new(9, "The Catcher in the Rye", 234, 10.50);
    Book book10 = new(10, "Animal Farm", 112, 8.99);
    
    return [book1, book2, book3,book4, book5, book6, book7, book8, book9, book10];
    
  }

}
