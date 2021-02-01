using System;
using System.ComponentModel.DataAnnotations;

namespace OneToOneExample
{
    public class Instructor
    {
        public int Id { get; set; }
        [MaxLength(45)]
        public String FirstName { get; set; }
        [MaxLength(45)]
        public String LastName { get; set; }
        [MaxLength(45)]
        public String Email { get; set; }
        public InstructorDetail InstructorDetail { get; set; }
        public int InstructorDetailId { get; set; }
    }
}