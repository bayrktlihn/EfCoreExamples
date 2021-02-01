using System;

namespace InstructorCourseExample
{
    public class Course
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public Instructor Instructor { get; set; }
    }
}