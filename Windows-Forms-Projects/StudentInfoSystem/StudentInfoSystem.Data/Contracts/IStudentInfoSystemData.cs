namespace StudentInfoSystem.Data.Contracts
{
    using System.Data.Entity;

    public interface IStudentInfoSystemData
    {
        IUsersRepository Users { get; }

        IStudentsRepository Students { get; }

        DbContext Context { get; }

        int SaveChanges();
    }
}
