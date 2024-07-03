using Microsoft.EntityFrameworkCore;

namespace Getpass.Components.Data
{
    public class AppDb:DbContext
    {
        private readonly string MySQLConnectionString = "Server=localhost; Database=gatepass; Uid=root; Pwd=Dakshina@123@345;";

        public DbSet<Tables> Tables { get; set; }
        public DbSet<DriverPool> DriverPool { get; set; }
        public DbSet<Vnum> Vnum {  get; set; } 
  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(MySQLConnectionString, ServerVersion.AutoDetect(MySQLConnectionString));

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder
                .Entity<Tables>(
                eb =>
                {
                    eb.HasKey("VRn");
                });


            modelBuilder
                .Entity<DriverPool>(
                eb =>
                {
                    eb.HasKey("EPF");
                });

            modelBuilder
      .Entity<Vnum>(
      eb =>
      {
          eb.HasNoKey();
      });

        }

    }
}
