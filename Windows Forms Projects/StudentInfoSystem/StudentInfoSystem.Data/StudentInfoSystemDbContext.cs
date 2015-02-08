namespace StudentInfoSystem.Data
{
    using System.Data.Entity;

    using StudentInfoSystem.Data.Contracts;
    using StudentInfoSystem.Models;

    public class StudentInfoSystemDbContext : DbContext, IStudentInfoSystemDbContext
    {
        public StudentInfoSystemDbContext()
            : this("StudentInfoSystemDb")
        {
        }

        public StudentInfoSystemDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public IDbSet<User> Users { get; set; }

        public IDbSet<Student> Students { get; set; }

        public DbContext DbContext
        {
            get
            {
                return this;
            }
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}
