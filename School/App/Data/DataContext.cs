using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace App
{
    public class DataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=app.db");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // var Grades1 = new Grade[] {
            //     new Grade { Id = 1, StudentId = 1, CourseName = "History 201", grade = 46} ,
            //     new Grade { Id = 2, StudentId = 1, CourseName = "Math 101", grade = 94} ,
            //     new Grade { Id = 3, StudentId = 1, CourseName = "Chem 302", grade = 75}
            // };
            // modelBuilder.Entity<Grade>().HasData(Grades1);
            // var Grades2 = new Grade[] {
            //     new Grade { Id = 4, StudentId = 2, CourseName = "History 201", grade = 46} ,
            //     new Grade { Id = 5, StudentId = 2, CourseName = "Math 101", grade = 94} ,
            //     new Grade { Id = 6, StudentId = 2, CourseName = "Chem 302", grade = 75}
            // };
            // modelBuilder.Entity<Grade>().HasData(Grades2);

            var Grade = new Grade[] {
                new Grade { Id = 7, StudentId = 1, CourseName = "History 301", grade = 46} ,
                new Grade { Id = 8, StudentId = 2, CourseName = "Math 201", grade = 94} ,
                new Grade { Id = 6, StudentId = 3, CourseName = "Chem 402", grade = 75},
                new Grade { Id = 9, StudentId = 2, CourseName = "Chem 201", grade = 84} 
            };
            modelBuilder.Entity<Grade>().HasData(Grade);            

            var students = new Student[] {
                new Student { Id = 1, FirstName = "Lassy", LastName="Jones", Age=20, classification= Student.Classification.Freshman} ,
                new Student { Id = 2, FirstName = "Molly", LastName="Rogers", Age=30, classification= Student.Classification.Sophomore},
                new Student { Id = 3, FirstName = "Frank", LastName="Smith", Age=40, classification= Student.Classification.Freshman}
            };
            modelBuilder.Entity<Student>().HasData(students);



            base.OnModelCreating(modelBuilder);
        }
    }
}