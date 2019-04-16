using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01.Models
{
    /// <summary>
    /// Build a class that represents a Vehicle
    ///
    ///Add this Vehicle class to the Models folder
    /// Add properties
    ///    VehicleId - string type of(Guid)
    ///   Make - string
    ///   Model - string
    ///    Year - int
    ///    NumberOfWheels - int
    ///   NumberOfDoors - int
    ///    ToString() override
    /// </summary>
    

    
    class Vehicle
    {
        public Guid VehicleID { get; set; }

        public String Make { get; set; }

        public String Model { get; set; }

        public int Year { get; set; }

        public int NumberOfWheels { get; set; }

        public int NumberOfDoors { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

        /// <summary>
        /// Vehicle structure class
        /// </summary>
        /// <param name="vehicleID"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="numberOfWheels"></param>
        /// <param name="numberOfDoors"></param>
        /// 
        public Vehicle()
        {

        }

        public Vehicle(Guid vehicleID, String make, String model, int year, int numberOfWheels, int numberOfDoors)
        {
            VehicleID = vehicleID;
            Make = make;
            Model = model;
            Year = year;
            NumberOfWheels = numberOfWheels;
            NumberOfDoors = numberOfDoors;
        }

        public Vehicle(String make, String model, int year, int numberOfWheels, int numberOfDoors) : this(Guid.NewGuid(), make, model, year, numberOfWheels, numberOfDoors)
        {

        }

        

    }
}
