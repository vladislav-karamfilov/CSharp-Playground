namespace StudentInfoSystem.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using StudentInfoSystem.Data.Contracts;
    using StudentInfoSystem.Models;

    public class StudentsRepository : DbRepository<Student>, IStudentsRepository
    {
        public StudentsRepository(IStudentInfoSystemDbContext context) 
            : base(context)
        {
        }

        public Student GetByFacultyNumber(string facultyNumber)
        {
            return this.All().FirstOrDefault(x => x.FacultyNumber == facultyNumber);
        }

        public IEnumerable<Student> GetStudentsByGroup(int group)
        {
            return this.All().Where(x => x.Group == group);
        }
    }
}
