namespace StudentInfoSystem.Data
{
    using StudentInfoSystem.Data.Contracts;

    public class StudentInfoSystemData : IStudentInfoSystemData
    {
        private readonly IStudentInfoSystemDbContext context;

        public StudentInfoSystemData()
            : this(new StudentInfoSystemDbContext())
        {
        }

        public StudentInfoSystemData(IStudentInfoSystemDbContext context)
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

        public IStudentInfoSystemDbContext Context
        {
            get { return this.context; }
        }

        public int SaveChanges()
        {
            return this.Context.SaveChanges();
        }
    }
}
