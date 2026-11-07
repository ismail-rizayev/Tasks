public class Student
{
  public int Id { get; set; }
  public string FullName { get; set; }
  public int Age { get; set; }
  public string Address { get; set; }
  public double Grade { get; set; }
  public string Email { get; set; }

  public Student(int id, string fullname, int age, string address, double grade, string email)
  {
    this.Id = id;
    this.FullName = fullname;
    this.Age = age;
    this.Address = address;
    this.Grade = grade;
    this.Email = email;


  }

  public string GetInfo()
  {
    return $"{Id}, {FullName}, {Age}, {Address}, {Grade}, {Email}";
  }

}