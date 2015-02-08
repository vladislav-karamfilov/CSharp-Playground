namespace StudentInfoSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string SecondName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(10)]
        public string Faculty { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Speciality { get; set; }

        [Required]
        [MinLength(7)]
        [MaxLength(20)]
        public string FacultyNumber { get; set; }

        public int Group { get; set; }

        public Oks Oks { get; set; }

        public StudentStatus StudentStatus { get; set; }

        public byte Course { get; set; }

        [MaxLength(5)]
        public string Potok { get; set; }
    }
}
