using System;
using Task1.Data;
using Task1.Services;
using Task1.Services.Interfaces;

namespace Task1.Controllers;

public sealed class StudentController
{
  public readonly IStudentservice _studentService;
  public StudentController(IStudentservice studentservice)
  {
    _studentService = studentservice;
 
  }

  public void ExecuteGetStudents()
  {

    foreach (var student in _studentService.GetStudents())
    {
      System.Console.WriteLine($"ID: {student.Id}, Name: {student.FullName}, Age: {student.Age}");
    }
  }

  public void ExecuteGetStudentsTotalAge()
  {
    System.Console.WriteLine(_studentService.GetStudentsTotalAge());
  }
  
  public void ExecuteGetStudentsDivdedAge()
  {
    System.Console.WriteLine(_studentService.GetStudentsDivdedAge());

  }

  public void ExecuteGetSortedListByAsc()
  {
    foreach (var item in _studentService.GetSortedListByAsc())
    {
      System.Console.WriteLine(item.GetInfo());
      
    }
    

  }

  public void ExecuteGetSortedListByDesc()
  {
    System.Console.WriteLine(_studentService.GetSortedListByDesc());

  }

  public void ExecuteGetStudentsById()
  {
    System.Console.Write("Enter your id -->");
    int a = int.Parse(Console.ReadLine());
    System.Console.WriteLine(_studentService.GetStudentsById(a));

  }

  public void ExecuteGetStudentsByName()
  {
    string searchedName = Console.ReadLine();
    foreach (var student in _studentService.GetStudents())
    {
      System.Console.WriteLine(_studentService.GetStudentsByName(searchedName));
    }
  }

  public void ExecuteGetSortedListById()
  {
    System.Console.WriteLine(_studentService.GetSortedListById());
    
  }





}
