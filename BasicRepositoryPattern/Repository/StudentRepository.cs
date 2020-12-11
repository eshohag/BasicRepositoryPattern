using BasicRepositoryPattern.Models;
using System.Data.Entity;

namespace BasicRepositoryPattern.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(DbContext context) : base(context)
        {
        }
    }
}