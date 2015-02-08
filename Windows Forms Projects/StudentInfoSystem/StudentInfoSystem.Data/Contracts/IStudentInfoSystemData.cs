namespace StudentInfoSystem.Data.Contracts
{
    public interface IStudentInfoSystemData
    {
        IUsersRepository Users { get; }

        IStudentsRepository Students { get; }

        IStudentInfoSystemDbContext Context { get; }

        int SaveChanges();
    }
}
