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
        }
    }
}
