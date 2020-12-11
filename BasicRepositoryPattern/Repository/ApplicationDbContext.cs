using BasicRepositoryPattern.Models;
using System.Data.Entity;

namespace BasicRepositoryPattern.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
            //this.Configuration.LazyLoadingEnabled = false;
            //this.Configuration.ProxyCreationEnabled = true;
        }

        #region COMMON TABLES
        public DbSet<Student> Students { get; set; }

        #endregion

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}