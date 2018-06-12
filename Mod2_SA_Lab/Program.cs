using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SA_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an object of Car() Class by using Type Inference called Car1
            var UProgram1 = new UProgram();
            // Using dot notation to call members on Car1
            UProgram1.Name = "Information Technology";


            var Degree1 = new Degree();
            Degree1.Name = "Bachelor";

            var Course1 = new Course();
            Course1.Name = "Programming with C#";

            var Student1 = new Student();
            Student1.Name = "Joe";
            Student1.Year = "2020";

            var Student2 = new Student();
            Student1.Name = "Sarah";
            Student1.Year = "2020";

            var Student3 = new Student();
            Student1.Name = "Mary";
            Student1.Year = "2020";

            var Teacher1 = new Teacher();
            Teacher.Name = "Dr. Codegood";
            Teacher.Year = "2020";

            // Access static members
            int studentCount = UProgram1.CountStudents();

            // Access static members
            int teacherCount = UProgram1.CountTeachers();

            // Output to the console window
            Console.WriteLine($"The name of the program is {UProgram1.Name} and the degree is {Degree1.Name}");
            Console.WriteLine($"The name of the course is {Course1.Name}");
            Console.WriteLine($"The count of the number of students in the course is {studentCount}");

        }
    }
}