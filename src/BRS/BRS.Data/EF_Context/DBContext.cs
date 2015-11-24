using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using BRS.Core.Models;

namespace BRS.Data.EF_Context {

  public class DBContext : DbContext {
    // Your context has been configured to use a 'DBContext' connection string from your application's 
    // configuration file (App.config or Web.config). By default, this connection string targets the 
    // 'BRS.Data.EF_Context.DBContext' database on your LocalDb instance. 
    // 
    // If you wish to target a different database and/or database provider, modify the 'DBContext' 
    // connection string in the application configuration file.
    public DBContext()
      : base("name=DBContext") {
    }

    // Add a DbSet for each entity type that you want to include in your model. For more information 
    // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

    public virtual DbSet<Route> Routes { get; set; }
    public virtual DbSet<Destination> Destinations { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
      modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
      modelBuilder.Entity<Route>().HasRequired(d => d.Pickup).WithMany().WillCascadeOnDelete(false);
      modelBuilder.Entity<Route>().HasRequired(d => d.DropOff).WithMany().WillCascadeOnDelete(false);
    }

    

  }
}