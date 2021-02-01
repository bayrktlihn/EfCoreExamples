using System;
using System.Collections.Generic;


namespace ManyToManyExample
{
    public class Course
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
    }
}