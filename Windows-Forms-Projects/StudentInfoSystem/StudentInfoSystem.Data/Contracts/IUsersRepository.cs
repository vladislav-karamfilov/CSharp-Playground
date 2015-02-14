namespace StudentInfoSystem.Data.Contracts
{
    using StudentInfoSystem.Models;

    public interface IUsersRepository : IRepository<User>
    {
        User GetByUsernameAndPassword(string username, string password);

        bool UsernameIsTaken(string username);
    }
}