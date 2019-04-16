using System;
using System.Collections.Generic;
using Assignment01.Models;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1
            Console.WriteLine("Student: John Cummins");
            Console.WriteLine("Student Num: Lakehead - 0883640, Georgian - 200416926");

            //Step 2
            Console.ReadKey();

            //Step 3
            /**
             * Step 3 pt. 2
             * 
             **/

            /// <summary>
            /// Step 3 pt. 3 - A show of XML doccument comments, in C sharp.
            /// </summary>
            /// 

            /*
             * Step 5: 
             * Adding items to a list of vehicles.
             * 
             * These next 25-or-so line both create a list and add twenty new Vehicle objects to 
             * 
             */ 

            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Vehicle("Poniac", "Vibe", 2009, 4, 5));
            vehicles.Add(new Vehicle("BMW", "430i", 2014, 4, 4));
            vehicles.Add(new Vehicle("Ram", "1500", 2017, 4, 4));
            vehicles.Add(new Vehicle("Toyota", "Matrix XR", 2004, 4, 4));
            vehicles.Add(new Vehicle( "Kia", "Sorento", 2019, 4, 5));
            vehicles.Add(new Vehicle("Chevrolet", "Impala", 2016, 4, 4));
            vehicles.Add(new Vehicle( "Dodge", "Grand Caravan", 2017, 4, 5));
            vehicles.Add(new Vehicle( "Toyota", "Avalon", 2014, 4, 4));
            vehicles.Add(new Vehicle( "Mazda", "CX-5", 2015, 4, 5));
            vehicles.Add(new Vehicle( "Poniac", "Firebird", 1994, 4, 2));
            vehicles.Add(new Vehicle( "Kia", "Stinger", 2019, 4, 4));
            vehicles.Add(new Vehicle( "Mercedes-Benz", "280 Series", 1984, 4, 4));
            vehicles.Add(new Vehicle( "Porche", "911", 1960, 4, 2));
            vehicles.Add(new Vehicle( "Dodge", "Dakoda", 2000, 4, 5));
            vehicles.Add(new Vehicle( "Ford", "Ranger", 2011, 4, 4));
            vehicles.Add(new Vehicle( "Ram", "1500", 2019, 4, 5));
            vehicles.Add(new Vehicle( "Land Rover", "Ranger Rover", 2018, 4, 5));
            vehicles.Add(new Vehicle( "Hyundai", "Elantra GT GLS", 2018, 4, 4));
            vehicles.Add(new Vehicle( "Chevrolet", "Silverado", 2018, 4, 4));
            vehicles.Add(new Vehicle( "Ford", "Transit", 2017, 4, 3));

            
            foreach (var vehicle in vehicles)
            {
                String VehId = vehicle.VehicleID.ToString();
                String Make = vehicle.Make.ToString();
                String Model = vehicle.Model.ToString();
                String Year = vehicle.Year.ToString();
                String NumberOfWheels = vehicle.NumberOfWheels.ToString();
                String NumberOfDoors = vehicle.NumberOfDoors.ToString();
                Console.WriteLine(VehId + ", " + Make + ", " + Model + ", " + Year + ", " + NumberOfWheels + ", " + NumberOfDoors);
            }

            Console.ReadKey();


        }
    }
}
