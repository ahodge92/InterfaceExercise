namespace InterfaceExercise
{
    partial class Program
    {
        public class SUV : IVehicle, ICompany
        {
            public int EmployeeSize { get; set; }
            public bool PubliclyTraded { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }
            public double TrunkVolume { get; set; }
            public bool ThirdRow { get; set; }
        }
    }
}
