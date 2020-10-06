using System;

namespace InterfaceExercise
{
    partial class Program
    {
        interface ICompany
        {
            public int EmployeeSize { get; set; }
            public bool PubliclyTraded { get; set; }

            public void DisplayCompanyInformation()
            {
                Console.WriteLine("Car Company Information");
                Console.WriteLine($"Employee Size: {EmployeeSize}");
                Console.WriteLine($"Publicly Traded: {PubliclyTraded}");
                Console.WriteLine("----------------------");
            }
        }
    }
}
