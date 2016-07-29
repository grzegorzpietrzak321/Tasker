namespace Tasker
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TaskerDataModel : DbContext
    {
        // Your context has been configured to use a 'TaskerDataModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Tasker.TaskerDataModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TaskerDataModel' 
        // connection string in the application configuration file.
        public TaskerDataModel()
            : base("name=TaskerDataModel")
        {
            Database.SetInitializer(new TaskerDataInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
            public DbSet<Task> Tasks { get; set; }
        //TODO seed bazy

        //TODO connection string
        
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