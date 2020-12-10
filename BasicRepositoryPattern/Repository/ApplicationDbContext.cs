using System.Data.Entity;

namespace BasicRepositoryPattern.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
            //this.Configuration.LazyLoadingEnabled = true;
            //this.Configuration.ProxyCreationEnabled = true;
        }

        #region COMMON TABLES


        #endregion

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}