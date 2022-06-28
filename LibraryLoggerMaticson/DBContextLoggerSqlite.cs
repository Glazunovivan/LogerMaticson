using Microsoft.EntityFrameworkCore;
using LibraryLoggerMaticson.Models;

namespace LibraryLoggerMaticson
{
    internal class DBContextLoggerSqlite : DbContext 
    {
        public DbSet<Log> Logs { get; set; }

        public DBContextLoggerSqlite()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Log.db;");
        }
    }

}
