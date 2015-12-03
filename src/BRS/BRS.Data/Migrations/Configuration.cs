using System;
using System.Data.Entity.Migrations;
using System.Linq;
using BRS.Core.Models;

namespace BRS.Data.Migrations {
  internal sealed class Configuration : DbMigrationsConfiguration<Context> {
    public Configuration() {
      AutomaticMigrationsEnabled = true;
      //ContextKey = "BRS.Data.Context";
      AutomaticMigrationDataLossAllowed = true;
    }

    protected override void Seed(Context context) {
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
      Role op = new Role { Name = "Operator", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Deleted = false };
      Role admin = new Role { Name = "Administrator", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Deleted = false };
      Role customer = new Role { Name = "Customer", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Deleted = false };
      Role guest = new Role { Name = "Guest", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Deleted = false };

      context.Users.AddOrUpdate(
         new User { Username = "admin", Email = "admin@admin.com", Password = "admin", Role = admin, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Deleted = false },
         new User { Username = "operator", Email = "op@op.com", Password = "operator", Role = op, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Deleted = false },
         new User { Username = "rafael", Email = "rafael@gmail.com", Password = "1234", Role = customer, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Deleted = false },
         new User { Username = "guest", Email = "guest@guest.com", Password = "guest", Role = guest, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, Deleted = false }
         );

      context.SaveChanges();
    }
  }
}
