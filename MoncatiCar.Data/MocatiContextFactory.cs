using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MoncatiCar.Data
{
    public class MocatiContextFactory : IDesignTimeDbContextFactory<MocatiContext>
    {
        public MocatiContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                         .SetBasePath(Directory.GetCurrentDirectory())
                         .AddJsonFile("appsettings.Data.json")
                         .Build();
            var builder = new DbContextOptionsBuilder<MocatiContext>();
            builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            return new MocatiContext(builder.Options);
        }
    }
}
