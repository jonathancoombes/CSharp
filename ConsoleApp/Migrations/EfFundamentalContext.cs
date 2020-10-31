using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Text;
using static System.Console;

namespace ConsoleApp
{

    public class EF_fundamentalContext : DbContext
    {

        //  Constructor to initialise the context, passing in the connection string directly (must never be done in production!)..
        public EF_fundamentalContext() : base("Server = DESKTOP-R4NHDH9\\SQLEXPRESS;Initial Catalog=EFdb;Integrated Security=True;User ID='';Password='';")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EF_fundamentalContext, Migrations.Configuration>());
        }

        //  Setting one DBSet property to track by the context
        public DbSet<Person> Person { get; set; }

        //  Used to configure entities specifically without overriding the default behaviour
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
       

    // The following should not be located the "context class" but its just placed here for easy reference / demonstration
    // This will generally be located  in the app and implemented as follows:

    public class Person : EF_fundamentalContext
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }


        //Implementation example that uses the "using(){}" block when instantiating and using the context 

        public static void ApplyChanges()
        {
            // !! NOTE!! : Instead of wrapping the entire code block in a using statement you can just add the "using" keyword to front of the
            // EF context you are instantiating as follows:

            using var context = new EF_fundamentalContext();


            Person newPerson1 = new Person();

            newPerson1.Name = "Jonathan";
            newPerson1.Surname = "Coombes";

            Person newPerson2 = new Person();

            newPerson2.Name = "Leeann";
            newPerson2.Surname = "Coombes";

            Person newPerson3 = new Person();

            newPerson3.Name = "Jamie";
            newPerson3.Surname = "Coombes";

            context.Person.Add(newPerson1);
            context.Person.Add(newPerson2);
            context.Person.Add(newPerson3);

            context.SaveChanges();
        }

    }
}








