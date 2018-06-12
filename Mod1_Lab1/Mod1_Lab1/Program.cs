using System;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an Object of Car() Class by using Type Inference called Carl
            var Carl = new Car();

            // Using dot notation to call members on Carl /Users/patrickthesailorman/Dev/edx_Microsoft_DEV204.2x/Mod1_Lab1/Mod1_Lab1/Program.cs
            Carl.Color = "White";
            Carl.Year = 2010;
            Carl.Mileage = 11000;

            // Output to the console window
            Console.WriteLine($"This car is painted {Carl.Color}, was built in {Carl.Year}, and has {Carl.Mileage} miles on it.");
        }
    }
    // Declaring the Car() Class
    // This class has 3 properties: Color, Year, and Mileage
    public class Car
    {
        // Defining properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
    }
}
