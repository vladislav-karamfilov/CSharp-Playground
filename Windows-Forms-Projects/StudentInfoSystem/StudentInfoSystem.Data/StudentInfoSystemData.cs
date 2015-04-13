namespace StudentInfoSystem.Data
{
    using System.Data.Entity;

    using StudentInfoSystem.Data.Contracts;

    public class StudentInfoSystemData : IStudentInfoSystemData
    {
        private readonly DbContext context;

        public StudentInfoSystemData()
            : this(new StudentInfoSystemDbContext())
        {
        }

        public StudentInfoSystemData(DbContext context)
        {
            this.context = context;
        }

        public IUsersRepository Users
        {
            get
            {
                return new UsersRepository(this.Context);
            }
        }

        public IStudentsRepository Students
        {
            get { return new StudentsRepository(this.Context); }
        }

        public DbContext Context
        {
            get { return this.context; }
        }

        public int SaveChanges()
        {
            return this.Context.SaveChanges();
        }
    }
}
