using System;
using System.Linq;

namespace CodeFirstStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    EnrollmentDate = DateTime.Now
                };

                context.Students.Add(student);
                context.SaveChanges();

                var students = context.Students.ToList();
                foreach (var s in students)
                {
                    Console.WriteLine($"ID: {s.StudentId}, Name: {s.FirstName} {s.LastName}, Enrolled: {s.EnrollmentDate}");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
