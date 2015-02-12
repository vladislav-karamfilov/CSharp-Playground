namespace StudentInfoSystem.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using StudentInfoSystem.Controllers.ViewModels;
    using StudentInfoSystem.Data.Contracts;
    using StudentInfoSystem.Models;

    public class StudentsController
    {
        private readonly IStudentInfoSystemData data;

        public StudentsController(IStudentInfoSystemData data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data", "An instance of IStudentInfoSystemData is required to use this controller!");
            }

            this.data = data;
        }

        public StudentInfoViewModel GetStudentInfo(string facultyNumber)
        {
            var studentInfo = this.data.Students.GetByFacultyNumber(facultyNumber);
            if (studentInfo == null)
            {
                return null;
            }

            return new StudentInfoViewModel
            {
                FirstName = studentInfo.FirstName,
                SecondName = studentInfo.SecondName,
                LastName = studentInfo.LastName,
                Faculty = studentInfo.Faculty,
                FacultyNumber = studentInfo.FacultyNumber,
                Course = studentInfo.Course,
                Degree = studentInfo.Degree,
                Potok = studentInfo.Potok,
                Speciality = studentInfo.Speciality,
                Status = studentInfo.StudentStatus,
                Group = studentInfo.Group
            };
        }

        public void AddStudent(StudentInfoViewModel studentInfo)
        {
            this.ValidateStudentInfo(studentInfo);

            this.data.Students.Add(new Student
            {
                Course = studentInfo.Course,
                Faculty = studentInfo.Faculty,
                FacultyNumber = studentInfo.FacultyNumber,
                LastName = studentInfo.LastName,
                SecondName = studentInfo.SecondName,
                Group = studentInfo.Group,
                Degree = studentInfo.Degree,
                Potok = studentInfo.Potok,
                Speciality = studentInfo.Speciality,
                FirstName = studentInfo.FirstName,
                StudentStatus = studentInfo.Status,
            });

            this.data.SaveChanges();
        }

        public IEnumerable<StudentInfoViewModel> GetStudentsInGroup(int? group = null)
        {
            if (group.HasValue)
            {
                return this.data.Students.GetStudentsByGroup(group.Value).AsQueryable().Select(StudentInfoViewModel.ViewModel);
            }
            
            return this.data.Students.All().Select(StudentInfoViewModel.ViewModel);
        }

        private void ValidateStudentInfo(StudentInfoViewModel studentInfo)
        {
            var errors = new StringBuilder();

            if (studentInfo.FirstName == null)
            {
                errors.AppendLine("Първото име е задължително!");
            }
            else
            {
                if (studentInfo.FirstName.Length < 2 || studentInfo.FirstName.Length > 20)
                {
                    errors.AppendLine("Първото име трябва да е с дължина между 2 и 20 символа!");
                }
            }

            if (studentInfo.SecondName == null)
            {
                errors.AppendLine("Второто име е задължително!");
            }
            else
            {
                if (studentInfo.SecondName.Length < 2 || studentInfo.SecondName.Length > 20)
                {
                    errors.AppendLine("Второто име трябва да е с дължина между 2 и 20 символа!");
                }
            }

            if (studentInfo.LastName == null)
            {
                errors.AppendLine("Третото име е задължително!");
            }
            else
            {
                if (studentInfo.LastName.Length < 2 || studentInfo.LastName.Length > 20)
                {
                    errors.AppendLine("Третото име трябва да е с дължина между 2 и 20 символа!");
                }
            }

            if (studentInfo.Faculty == null)
            {
                errors.AppendLine("Факултетът е задължителен!");
            }
            else
            {
                if (studentInfo.FacultyNumber.Length < 2 || studentInfo.FacultyNumber.Length > 10)
                {
                    errors.AppendLine("Факултетът трябва да е с дължина между 2 и 10 символа!");
                }
            }

            if (studentInfo.Speciality == null)
            {
                errors.AppendLine("Специалността е задължителна!");
            }
            else
            {
                if (studentInfo.Speciality.Length < 2 || studentInfo.Speciality.Length > 50)
                {
                    errors.AppendLine("Специалността трябва да е с дължина между 2 и 50 символа!");
                }
            }

            if (studentInfo.FacultyNumber == null)
            {
                errors.AppendLine("Факултетният номер е задължителен!");
            }
            else
            {
                if (studentInfo.FacultyNumber.Length < 7 || studentInfo.FacultyNumber.Length > 20)
                {
                    errors.AppendLine("Факултетният номер трябва да е с дължина между 7 и 20 символа!");
                }
            }

            if (studentInfo.Potok != null && studentInfo.Potok.Length > 5)
            {
                errors.AppendLine("Потокът трябва да е с дължина поне 5 символа!");
            }

            if (errors.Length > 0)
            {
                throw new ArgumentException(errors.ToString());
            }
        }
    }
}
