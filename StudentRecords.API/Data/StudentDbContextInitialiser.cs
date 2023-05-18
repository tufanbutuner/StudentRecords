using Microsoft.EntityFrameworkCore;

namespace StudentRecords.API.Data
{
    public class StudentDbContextInitialiser
    {
        private readonly StudentDbContext _context;
        private readonly ILogger<StudentDbContextInitialiser> _logger;

        public StudentDbContextInitialiser(StudentDbContext context, ILogger<StudentDbContextInitialiser> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task InitialiseAsync()
        {
            try
            {
                if (_context.Database.IsMySql())
                {
                    _logger.LogInformation("SQL Server found. Migrating...");
                    await _context.Database.MigrateAsync();
                }
                else
                {
                    _logger.LogInformation("In Memory DB found. Migrating...");
                    await _context.Database.EnsureCreatedAsync();
                }

                _logger.LogInformation("Migration Complete!");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while initialising the database.");
                throw;
            }
        }
    }
}
