using System;

namespace InterfaceExercise
{
    partial class Program
    {
        public class Car : IVehicle, ICompany
        {
            public int EmployeeSize { get; set; }
            public bool PubliclyTraded { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }
            public bool HasTrunk { get; set; }
            public bool Hatchback { get; set; }

            public void DisplayCompanyInformation()
            {
                Console.WriteLine($"Car Company Information on {Make}");
                Console.WriteLine($"Employee Size: {EmployeeSize}");
                Console.WriteLine($"Publicly Traded: {PubliclyTraded}");
                Console.WriteLine("----------------------");
            }

            public void DisplayGeneralInformation()
            {
                Console.WriteLine("General Information");
                Console.WriteLine($"Make: {Make}");
                Console.WriteLine($"Model: {Model}");
                Console.WriteLine($"Year: {Year}");
                Console.WriteLine($"Color: {Color}");
                Console.WriteLine("----------------------");
            }

            public void DisplaySpecificInformation()
            {
                Console.WriteLine($"Specific Information on {Model}");
                Console.WriteLine($"Has Trunk: {HasTrunk}");
                Console.WriteLine($"Is Hatchback: {Hatchback}");
                Console.WriteLine("----------------------");
            }

        }
    }
}
