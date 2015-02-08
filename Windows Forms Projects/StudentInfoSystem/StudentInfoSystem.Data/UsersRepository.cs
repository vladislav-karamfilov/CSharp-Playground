namespace StudentInfoSystem.Data
{
    using System.Linq;

    using StudentInfoSystem.Data.Contracts;
    using StudentInfoSystem.Models;

    public class UsersRepository : DbRepository<User>, IUsersRepository
    {
        public UsersRepository(IStudentInfoSystemDbContext context)
            : base(context)
        {
        }

        public User GetByUsernameAndPassword(string username, string password)
        {
            return this.All().FirstOrDefault(x => x.Username == username && x.Password == password);
        }

        public bool UsernameIsTaken(string username)
        {
            return this.All().Any(x => x.Username == username);
        }
    }
}
