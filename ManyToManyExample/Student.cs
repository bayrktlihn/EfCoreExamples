using System;
using System.Collections.Generic;


namespace ManyToManyExample
{
    public class Student
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
    }
}