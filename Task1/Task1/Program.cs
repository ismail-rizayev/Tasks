using Task1.Controllers;
using Task1.Services;
using Task1.Services.Interfaces;

IStudentservice studentservice = new StudentService();
StudentController studentController = new(studentservice);
studentController.ExecuteGetSortedListByAsc();