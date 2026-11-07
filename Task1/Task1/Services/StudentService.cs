using System;
using System.Security.Cryptography.X509Certificates;
using Task1.Data;
using System.Linq;
using Task1.Services.Interfaces;

namespace Task1.Services;

public class StudentService: IStudentservice
{
  private readonly AppDbContext _context;
  private readonly Student[] _students;
  public StudentService()
  {

    _context = new AppDbContext();
    _students = _context.GetAllStudent();
    
  }

  public Student[] GetStudents()
  {
    
    return _students;
  }

  public int GetStudentsTotalAge()
  {
    return _students.Sum(student => student.Age);
  }

  public double GetStudentsDivdedAge()
  {
    int totalAge = _students.Sum(students => students.Age);
    int count = _students.Length;
    return totalAge/count;
  }

  public Student[] GetSortedListByAsc()
  {
    return _students.OrderBy(student => student.Age).ToArray();
    
  }
  public Student[] GetSortedListByDesc()
  {
    return _students.OrderByDescending(student => student.Age).ToArray();
    
  }

  public Student[] GetStudentsById(int a)
  {
    return _students.Where(student => student.Id == a).ToArray();
  }

  public Student[] GetStudentsByName(string serchedName)
  {
    return _students.Where(student => student.FullName.Contains(serchedName)).ToArray();
  }

  public Student[] GetSortedListById()
  {
    return _students.OrderBy(student => student.Id).ToArray();
    
  }

  public int GetResultOfStudents()
  {
    int age = _students.Sum(students => students.Age);
    int count = _students.Length;
    int dividedAge = age/count;
    return age*dividedAge;
  }

  public Student[] GetTop5()
  {
    return _students.OrderByDescending(students => students.Age).Take(5).ToArray();
  }

  



  
}
