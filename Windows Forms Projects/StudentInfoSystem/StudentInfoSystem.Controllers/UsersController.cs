namespace StudentInfoSystem.Controllers
{
    using System;
    using StudentInfoSystem.Controllers.ViewModels;
    using StudentInfoSystem.Data.Contracts;
    using StudentInfoSystem.Models;

    public class UsersController
    {
        private const int UsernameMinLength = 5;
        private const int PasswordMinLength = 6;

        private readonly IStudentInfoSystemData data;

        public UsersController(IStudentInfoSystemData data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data", "An instance of IStudentInfoSystemData is required to use this controller!");
            }

            this.data = data;
        }

        public UserViewModel LoginUser(string username, string password)
        {
            ValidateUsername(username);
            ValidatePassword(password);

            var userEntity = this.data.Users.GetByUsernameAndPassword(username, password);
            if (userEntity == null)
            {
                throw new ArgumentException("Въвели сте грешно потребителско име или парола.");
            }

            return new UserViewModel
            {
                FacultyNumber = userEntity.FacultyNumber,
                Role = userEntity.Role
            };
        }

        public void RegisterUser(string username, string password, string facultyNumber, Role role)
        {
            ValidateUsername(username);
            ValidatePassword(password);
            ValidateFacultyNumber(facultyNumber);

            if (this.data.Users.UsernameIsTaken(username))
            {
                throw new ArgumentException("Потрeбителското име вече е заето!");
            }

            this.data.Users.Add(new User
            {
                Username = username,
                FacultyNumber = string.IsNullOrWhiteSpace(facultyNumber) ? null : facultyNumber,
                Password = password,
                Role = role
            });

            this.data.SaveChanges();
        }

        private static void ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Паролата е задължителнa.");
            }

            if (password.Length < PasswordMinLength)
            {
                throw new ArgumentException(
                    string.Format("Паролата трябва да е поне {0} символа дълга.", PasswordMinLength));
            }
        }

        private static void ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Потребителското име е задължително.");
            }

            if (username.Length < UsernameMinLength)
            {
                throw new ArgumentException(
                    string.Format("Потребителското име трябва да е поне {0} символа дълго.", UsernameMinLength));
            }
        }

        private static void ValidateFacultyNumber(string facultyNumber)
        {
            if (!string.IsNullOrWhiteSpace(facultyNumber))
            {
                if (facultyNumber.Length < 7 || facultyNumber.Length > 20)
                {
                    throw new ArgumentException("Факултетният номер трябва да е между 7 и 20 симовола дълъг.");
                }
            }
        }
    }
}
