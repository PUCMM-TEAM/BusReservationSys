using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BRS.Core.Models;

namespace BRS.Data {
  public class Context : DbContext {
    // Your context has been configured to use a 'DbContext' connection string from your application's 
    // configuration file (App.config or Web.config). By default, this connection string targets the 
    // 'BRS.Data.DbContext' database on your LocalDb instance. 
    // 
    // If you wish to target a different database and/or database provider, modify the 'DbContext' 
    // connection string in the application configuration file.
    public Context()
      : base("name=DbContext") {
    }

    // Add a DbSet for each entity type that you want to include in your model. For more information 
    // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

    public virtual DbSet<Destination> Destinations { get; set; }
    public virtual DbSet<Route> Routes { get; set; }
    public virtual DbSet<Vehicle> Vehicles { get; set; }
    public virtual DbSet<Trip> Trips { get; set; }
    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<CreditCard> CreditCards { get; set; }
    public virtual DbSet<Reservation> Reservations { get; set; }
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
      modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
      modelBuilder.Entity<Route>().Ignore(t => t.RouteName);
      base.OnModelCreating(modelBuilder);
    }
  }
}