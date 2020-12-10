using BasicRepositoryPattern.Models;
using System.Collections.Generic;

namespace BasicRepositoryPattern.BL
{
    public interface IStudentManager
    {
        List<Student> GetAll();
    }
}
