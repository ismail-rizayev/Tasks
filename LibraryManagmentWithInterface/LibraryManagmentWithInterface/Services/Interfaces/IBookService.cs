using System;

namespace LibraryManagmentWithInterface.Models;

public interface IBookService
{
  Book[] GetInfo(Book[] booksToPrint = null);
  double GetSumOfBooks();
  double GetDivededPrice(); 
  Book[] SortByAsc();
  Book[] SortByDesc();
  Book[] GetGenre(string searchedGenre);
  Book[] GetTitle(string searchedTitle);
  Book[] GetSortedBooksByAuthor(string searchedAuthor);
  double GetPageSumMultipliedByAverage();
  Book[] GetTop3();
  Book[] GetBookById(int searchedid);
  void AddBook(Book book);
  int getCount();

}
