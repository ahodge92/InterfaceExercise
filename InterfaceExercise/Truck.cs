namespace InterfaceExercise
{
    partial class Program
    {
        public class Truck : IVehicle, ICompany
        {
            public int EmployeeSize { get; set; }
            public bool PubliclyTraded { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }
            public int BedLengthFt { get; set; }
            public int TowingCapacityLb { get; set; }
        }
    }
}
