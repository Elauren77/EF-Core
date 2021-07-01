using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new DataContext();
            var students = database.Students.ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id} : {student.FirstName} {student.LastName}");
            }
            
        }
    }
}
