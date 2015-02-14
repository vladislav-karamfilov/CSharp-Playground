namespace StudentInfoSystem.Controllers.ViewModels
{
    using System;
    using System.Linq.Expressions;

    using StudentInfoSystem.Models;

    public class StudentInfoViewModel
    {
        public static Expression<Func<Student, StudentInfoViewModel>> ViewModel
        {
            get
            {
                return x =>
                    new StudentInfoViewModel
                    {
                        Course = x.Course,
                        FacultyNumber = x.FacultyNumber,
                        Faculty = x.Faculty,
                        Group = x.Group,
                        LastName = x.LastName,
                        SecondName = x.SecondName,
                        Degree = x.Degree,
                        Potok = x.Potok,
                        Speciality = x.Speciality,
                        FirstName = x.FirstName,
                        Status = x.StudentStatus
                    };
            }
        }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public string Faculty { get; set; }

        public Degree Degree { get; set; }

        public StudentStatus Status { get; set; }

        public string Speciality { get; set; }

        public string FacultyNumber { get; set; }

        public byte Course { get; set; }

        public string Potok { get; set; }

        public int Group { get; set; }
    }
}
