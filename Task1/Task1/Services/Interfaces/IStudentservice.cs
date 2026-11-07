using System;
using Task1.Services;

namespace Task1.Services.Interfaces;

public interface IStudentservice
{
  Student[] GetStudents();
  int GetStudentsTotalAge();
  double GetStudentsDivdedAge();
  Student[] GetSortedListByAsc();
  Student[] GetSortedListByDesc();
  Student[] GetStudentsById(int a);
  Student[] GetStudentsByName(string serchedName);
  Student[] GetSortedListById();
  int GetResultOfStudents();
  Student[] GetTop5();

  

}
