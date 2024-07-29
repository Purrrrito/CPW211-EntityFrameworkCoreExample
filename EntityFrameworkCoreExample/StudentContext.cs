using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreExample
{
	// EF Core getting started
	// https://learn.microsoft.com/en-us/ef/core/get-started/overview/install
	public class StudentContext : DbContext
	{
        public StudentContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Database = desired name for the database
            // Server = The server we are connection to. LocalDB is included with VS
            // Trusted_Connection - indicates that out windows account should be used
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExample;Trusted_Connection=True;");
        }

        // Tell EF Core to track Students in the database
        public DbSet<Student> Students { get; set; }
    }
}
