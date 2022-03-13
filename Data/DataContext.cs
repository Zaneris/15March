using Interview.Entities;
using Microsoft.EntityFrameworkCore;

namespace Interview.Data;

public class DataContext : DbContext
{
    /// <summary>
    /// All vehicle models in database.
    /// </summary>
    public DbSet<VehicleModel> VehicleModels => Set<VehicleModel>();

    public DataContext(DbContextOptions options) : base(options) { }
}