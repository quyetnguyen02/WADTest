namespace TestMVC.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity.EntityFramework;
    using TestMVC.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TestMVC.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TestMVC.Models.ApplicationDbContext context)
        {
            List<IdentityRole> role = new List<IdentityRole>
            {
            new IdentityRole{Id="0",Name="Admin"},
            new IdentityRole { Id = "1", Name = "User" },
            new IdentityRole { Id = "2", Name = "Employee" },
            };

            role.ForEach(s => context.Roles.Add(s)) ; 
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
