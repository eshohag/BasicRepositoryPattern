using BasicRepositoryPattern.Models;
using System.Collections.Generic;

namespace BasicRepositoryPattern.BL
{
    public class StudentManager : IStudentManager
    {
        public List<Student> GetAll()
        {
            //Inhere write your business logic & communicating Database with repository pattern
            var student = new Student();
            student.FirstName = "Mr Jon";
            student.LastName = "Doe";
            student.DeptName = "CSE";

            throw new System.NotImplementedException();
        }
    }
}