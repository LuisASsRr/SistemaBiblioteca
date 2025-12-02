using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SistemaBiblioteca.Data 
{
    
    public class BibliotecaContextFactory : IDesignTimeDbContextFactory<BibliotecaContext>
    {
        public BibliotecaContext CreateDbContext(string[] args)
        {
            
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            
            var optionsBuilder = new DbContextOptionsBuilder<BibliotecaContext>();

            
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            
            optionsBuilder.UseSqlServer(connectionString);

            
            return new BibliotecaContext(optionsBuilder.Options);
        }
    }
}