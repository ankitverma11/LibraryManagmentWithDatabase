using LibraryManagment.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagmentWithDB.Data.DataContext
{
    public class LibraryDBContext : DbContext
    { 

        // For Migration Use Command add-Migration intialMigration   and After this update-database
        public LibraryDBContext(DbContextOptions<LibraryDBContext>options) : base(options)
        {

        }

        //DbSet  A set for the given entity type.
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Login> Login { get; set; }

        /// <summary>
        //In order to access data objects from SQL database via custom queries, store procedures or direct query from tables,
        //you need to register your target custom objects with the model builder inside your "OnModelCreating(...)" method of "LibraryDbContext.cs" database context class.
        //As shown below I will not do any direct table query so, I have commented out my table entity object Login pre-build registration with the model builder and since, 
        //I am using the result of my SQL server database store procedure, therefore, I have registered my custom store procedure data returining object with the model builder:
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////modelBuilder.Entity<Login>(entity =>  
            ////{  
            ////    entity.Property(e => e.Id).HasColumnName("id");  

            ////    entity.Property(e => e.Password)  
            ////        .IsRequired()  
            ////        .HasColumnName("password")  
            ////        .HasMaxLength(50)  
            ////        .IsUnicode(false);  

            ////    entity.Property(e => e.Username)  
            ////        .IsRequired()  
            ////        .HasColumnName("username")  
            ////        .HasMaxLength(50)  
            ////        .IsUnicode(false);  
            ////});  

            // []: Query for store procedure.  
            modelBuilder.Query<LoginByUsernamePassword>();
        }

    }
}
