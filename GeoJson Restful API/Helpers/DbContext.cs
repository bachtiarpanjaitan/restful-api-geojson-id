namespace GeoJson_Restful_API.Helpers;

using GeoJson_Restful_API.Entities;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to mysql with connection string from app settings
        var connectionString = Configuration.GetConnectionString("Default");
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }

    public DbSet<Adm1> Adm1 { get; set; }
}