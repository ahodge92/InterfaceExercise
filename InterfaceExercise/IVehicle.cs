using System;

namespace InterfaceExercise
{
    partial class Program
    {
        interface IVehicle
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            public void DisplayGeneralInformation()
            {
                Console.WriteLine("General Information");
                Console.WriteLine($"Make: {Make}");
                Console.WriteLine($"Model: {Model}");
                Console.WriteLine($"Year: {Year}");
                Console.WriteLine($"Color: {Color}");
                Console.WriteLine("----------------------");
            }
            public void DisplaySpecificInformation();

        }
    }
}
