namespace StudentInfoSystem.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;
    using StudentInfoSystem.Models;

    public sealed class DefaultConfiguration : DbMigrationsConfiguration<StudentInfoSystemDbContext>
    {
        public DefaultConfiguration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(StudentInfoSystemDbContext context)
        {
            if (!context.Users.Any())
            {
                var testUser = new User
                {
                    Username = "TestUser",
                    Password = "pa$$w0rd",
                    Role = Role.Administrator
                };

                var newTestUser = new User
                {
                    Username = "TestUser2",
                    Password = "password",
                    Role = Role.Administrator
                };

                context.Users.Add(testUser);
                context.Users.Add(newTestUser);

                context.SaveChanges();
            }
        }
    }
}
