namespace ConsoleApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConsoleApp.EF_fundamentalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ConsoleApp.EF_fundamentalContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            // !! Thi is the correct method / place to seed the database with dummy data. Not to populate it (like adding categories)
            // Population must be done using an empty migration and adding sql statements into the "up" method

            context.Person.AddOrUpdate(

                new Person
                {
                    Name = "Jonathan2",
                    Surname = "Coombes"
                },
                new Person { 
                
                    Name = "Jamie2",
                    Surname = "Coombes"
                }

                );
            
        }
    }
}
