using BasicRepositoryPattern.Models;
using System.Collections.Generic;

namespace BasicRepositoryPattern.BL
{
    public class StudentManager : IStudentManager
    {
        public Student FindById()
        {
            throw new System.NotImplementedException();
        }

        public List<Student> GetAll()
        {
            //Inhere write your business logic & communicating Database with repository pattern
            #region DatabaseData
            var students = new List<Student>();

            //Single values assign into list object
            var cseStudent = new List<Student>()
            {
                new Student(){FirstName="Mr ", LastName="Shohag", DeptName="CSE"},
                new Student(){FirstName="Mr ", LastName="Dineth", DeptName="CSE"}
            };

            var mrJon = new Student();
            mrJon.FirstName = "Mr Jon";
            mrJon.LastName = "Doe";
            mrJon.DeptName = "CSE";

            //Single values assign into list object
            cseStudent.Add(mrJon);


            //List of values assign into list object
            students.AddRange(cseStudent);

            #endregion

            //Example- You need minumum 3 records retun othewise retun null
            if (students.Count >= 3)
                return students;
            return null;
        }
    }
}