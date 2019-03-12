using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using EndGameEntityDB.Models;
namespace EndGameEntityDB.DAL
{
    public class SuperModel : DbContext
    {
        // Your context has been configured to use a 'SuperModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Assignment05-A-VictorBesson.SuperModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SuperModel' 
        // connection string in the application configuration file.
        public SuperModel()
            : base("data source=localhost;initial catalog=EndGameChatRoom;user id=sa;password=password;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
