namespace StudentInfoSystem.Data.Contracts
{
    using System.Collections.Generic;

    using StudentInfoSystem.Models;

    public interface IStudentsRepository : IRepository<Student>
    {
        Student GetByFacultyNumber(string facultyNumber);

        IEnumerable<Student> GetStudentsByGroup(int group);
    }
}