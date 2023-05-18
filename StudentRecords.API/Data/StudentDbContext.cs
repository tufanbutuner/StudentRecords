using Microsoft.EntityFrameworkCore;
using StudentRecords.API.Models;
using System.Reflection.Emit;

namespace StudentRecords.API.Data
{
    public class StudentDbContext : DbContext, IDbContext
    {

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Degree> Degrees => Set<Degree>();
        public DbSet<Modules> Modules => Set<Modules>();
        public DbSet<Module> Module => Set<Module>();
        public DbSet<Address> Address => Set<Address>();

        public async Task SaveChangesAsync()
        {
            await base.SaveChangesAsync();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=10.211.55.2;Port=3306;Database=student;Uid=root;Pwd=RandomPassword!123;";

            // Configure the database provider and connection string
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), builder => builder.MigrationsAssembly(typeof(StudentDbContext).Assembly.FullName));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Modules>()
                .HasNoKey();
        }
    }
}
