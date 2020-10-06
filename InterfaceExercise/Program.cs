using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces


            //Create 2 Interfaces called IVehicle & ICompany
            //Create 3 classes called Car , Truck , & SUV
            //In your IVehicle
            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */
            //In ICompany
            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car myCar = new Car()
            {
                Color = "Red",
                EmployeeSize = 218674,
                HasTrunk = true,
                Hatchback = true,
                Make = "Honda",
                Model = "FIT",
                PubliclyTraded = true,
                Year = 2008
            };

            Truck myTruck = new Truck()
            {
                BedLengthFt = 8,
                Color = "Grey",
                EmployeeSize = 370870,
                Make = "Toyota",
                Model = "Tocoma",
                PubliclyTraded = true,
                TowingCapacityLb = 3500,
                Year = 2020
            };

            SUV wifeSUV = new SUV()
            {
                Color = "White",
                EmployeeSize = 218674,
                Make = "Honda",
                Model = "CRV",
                PubliclyTraded = true,
                ThirdRow = false,
                TrunkVolume = 35.7,
                Year = 2010
            };

            myCar.DisplayGeneralInformation();
            myCar.DisplaySpecificInformation();
            myCar.DisplayCompanyInformation();

            myTruck.DisplayGeneralInformation();
            myTruck.DisplaySpecificInformation();
            myTruck.DisplayCompanyInformation();
            
            wifeSUV.DisplayGeneralInformation();
            wifeSUV.DisplaySpecificInformation();
            wifeSUV.DisplayCompanyInformation();

        }
    }
}
