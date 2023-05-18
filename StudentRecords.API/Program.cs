using Microsoft.EntityFrameworkCore;
using StudentRecords.API.Data;

namespace StudentRecords.API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = "Server=10.211.55.2;Port=3306;Database=student;Uid=root;Pwd=RandomPassword!123;";

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddDbContext<StudentDbContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString),
                    builder => builder.MigrationsAssembly(typeof(StudentDbContext).Assembly.FullName)));

            builder.Services.AddScoped<IDbContext>(provider => provider.GetRequiredService<StudentDbContext>());

            builder.Services.AddScoped<StudentDbContextInitialiser>();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var initialiser = scope.ServiceProvider.GetRequiredService<StudentDbContextInitialiser>();
                await initialiser.InitialiseAsync();
            }

            // Configure the HTTP request pipeline.

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}