namespace CarRentApp.Migrations
{
    using CarRentApp.Entities;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public partial class AddUser : DbMigration
    {
        public override void Up()
        {
            var dbContext = new CarRentDbContext();
            dbContext.Users.Add(
                new User
                {
                    UserName = "David",
                    Password = "6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b",
                    IsActive = true
                });
            dbContext.Roles.Add(
               new Role
               {
                   Name = "Administrator",
                   ShortName = "Admin",
               });
            dbContext.UserRoles.Add(
                new Entities.UserRole
                {
                    UserId = 1,
                    RoleId = 1,
                });
            //var UserId = dbContext.Users.FirstOrDefault(x => x.UserName == "David").Id;
            dbContext.UserRoles.Add(
              new Entities.UserRole
              {
                  UserId = 1,
                  RoleId = 1,
              });
            dbContext.SaveChanges();
        }
        
        public override void Down()
        {
        }
    }
}
