namespace InterfaceExercise
{
    partial class Program
    {
        interface ICompany
        {
            public int EmployeeSize { get; set; }
            public bool PubliclyTraded { get; set; }
        }
    }
}
