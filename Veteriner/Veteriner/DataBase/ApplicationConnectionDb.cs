using Microsoft.EntityFrameworkCore;

namespace Veteriner.DataBase
{
    public class ApplicationConnectionDb : DbContext
    {
       public DbSet<Kisi> Kisi { get; set; }
       public DbSet<Kategori> Kategori { get; set; }
       public DbSet<Hayvan> Hayvan { get; set; }



        ServerVersion ServerVersion { get; set; }   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySql("server=localhost;port=3306;user=root;password=;database=Veteriner;", new MySqlServerVersion(new Version(8,2,0)), null)
                .UseLoggerFactory(LoggerFactory.Create(b => b
                .AddConsole()
                .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
    }
}
