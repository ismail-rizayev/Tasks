using System;

namespace Task1.Data;

public class AppDbContext
{
    public Student[] GetAllStudent()
  {
    Student student1 = new(1, "Ismail", 19, "Garayev", 99, "ismail@gmail.com");
    Student student2 = new(2, "Farid", 18, "Ehmdeli", 98, "farid@gmail.com");
    Student student3 = new(3, "Emil", 20, "Xalqlar", 97, "emil@gmail.com");
    return [student1, student2, student3];
  }


}
