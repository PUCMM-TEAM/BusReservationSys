namespace BRS.Data.Migrations
{
    using Core.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BRS.Data.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //ContextKey = "BRS.Data.Context";
        }

        protected override void Seed(BRS.Data.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Roles.AddOrUpdate(

                new Role { Name = "Operator", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Deleted = false },
                new Role { Name = "Administrator", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Deleted = false },
                new Role { Name = "Customer", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Deleted = false },
                new Role { Name = "Guest", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Deleted = false }

                );
            context.SaveChanges();
            Role admin = context.Roles.Where(x => x.Name.Contains("Admin")).First();
            Role op = context.Roles.Where(x => x.Name.Contains("Operator")).First();
            Role customer = context.Roles.Where(x => x.Name.Contains("Customer")).First();

            context.Users.AddOrUpdate(

               new User { Username="admin",Email="admin@admin.com",Password="admin",Role=admin, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Deleted = false},
                new User { Username = "operator", Email = "op@op.com", Password = "operator", Role = op, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Deleted = false },
                 new User { Username = "rafael", Email = "rafael@gmail.com", Password = "1234", Role = customer, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Deleted = false }


               );

            context.SaveChanges();
        }
    }
}
