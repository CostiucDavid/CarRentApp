namespace CarRentApp.Migrations
{
    using CarRentApp.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    
    public partial class AddCars : DbMigration
    {
        public override void Up()
        {
            var dbContext = new CarRentDbContext();
            dbContext.TypesOfCars.Add(new TypesOfCar
            {
                Make = "Lada",
                Model = "2109",
                LicensePlateNumber = "123qwe",
                VIN = "hd9fhgu",
                Year = 2012,
                CarRentalRecord = new List<CarRentalRecord>()
            });
            dbContext.TypesOfCars.Add(new TypesOfCar
            {
                Make = "BMW",
                Model = "M5F90",
                LicensePlateNumber = "eBoys",
                VIN = "9a8shdf",
                Year = 2017,
            });
            dbContext.TypesOfCars.Add(new TypesOfCar
            {
                Make = "Mercedes",
                Model = "V-class",
                LicensePlateNumber = "niges",
                VIN = "here88re",
                Year = 2020,
                CarRentalRecord = new List<CarRentalRecord>()
            });
            dbContext.SaveChanges();
        }
        
        public override void Down()
        {
        }
    }
}
