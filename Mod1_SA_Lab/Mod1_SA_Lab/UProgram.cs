using System;

namespace Mod1_Lab3
{
    // Declaring the UProgram() Class
    // This class has 1 property: Name
    public class UProgram
    {
        // Defining properties
        public string Name { get; set; }

        public class Degree
        {
            // Defining properties
            public string Name { get; set; }

            public class Course
            {
                // Defining properties
                public string Name { get; set; }


                // Adding a Constructor 
                // This constructor instantiates a Car() object while only having the car's color and year information available
                public Student(string name, int year)
                {
                    this.Name = name;
                    this.Year = year;
                    // Every time the constructor runs, increment "instances"
                    instances++;
                }

                //Adding another Constructor
                // This constructor instantiates a Car() object while only having the car's year and mileage information available
                public Teacher(string name, int year)
                {
                    this.Year = year;
                    this.Name = name;
                    // Every time the constructor runs, increment "instances"
                    instances++;
                }

                // Creates integer variable called "instances" and assigns value to 0
                private static int instances = 0;

                //
                public Students()
                {
                    // Every time the constructor runs, increment "instances"
                    instances++;
                }

                public Teachers()
                {
                    // Every time the constructor runs, increment "instances"
                    instances++;
                }

                //
                public static int CountStudents()
                {
                    return instances;
                }
                //
                public static int CountTeachers()
                {
                    return instances;
                }
            }
        }
    }
}
