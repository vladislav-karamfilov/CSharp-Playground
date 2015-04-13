namespace StudentInfoSystem.Data
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    using StudentInfoSystem.Data.Contracts;
    using StudentInfoSystem.Models;

    public class StudentsRepository : EfRepository<Student>, IStudentsRepository
    {
        public StudentsRepository(DbContext context) 
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
