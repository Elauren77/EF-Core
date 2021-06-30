using System;
using System.Collections.Generic;

namespace App
{
    public class Student
    {
        public enum Classification {
            Freshman = 0,
            Sophomore = 1,
            Junior = 2,
            Senior = 3
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age {get; set;}
        public Classification classification;
        
        public ICollection<Grade> GPA {get; set;}
    }
}