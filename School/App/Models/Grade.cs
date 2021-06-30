using System;
using System.Collections.Generic;

namespace App
{
    public class Grade
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string CourseName { get; set; }
        public float grade {get; set;}
        public Student Student { get; set; }
    }
}