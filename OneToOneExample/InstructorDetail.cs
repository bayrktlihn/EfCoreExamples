using System;
using System.ComponentModel.DataAnnotations;

namespace OneToOneExample
{
    public class InstructorDetail
    {
        public int Id { get; set; }
        [MaxLength(128)]
        public String YoutubeChannel { get; set; }
        [MaxLength(45)]
        public String Hobby { get; set; }
        public Instructor Instructor { get; set; }
    }
}