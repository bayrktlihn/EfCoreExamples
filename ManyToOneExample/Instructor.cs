using System;
using System.Collections.Generic;

namespace InstructorCourseExample
{
    public class Instructor
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public List<Course> Courses { get; set; }
    }
}