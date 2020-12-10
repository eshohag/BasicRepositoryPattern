namespace BasicRepositoryPattern.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DeptName { get; set; }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}