using Domain.Entities;
using Infrastructure.Dal.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Dal;

public class DrugsBotDbContext:DbContext
{
    public DrugsBotDbContext(DbContextOptions<DrugsBotDbContext> options) : base(options)
    {
        
    }

    public DbSet<Drug> Drugs { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<DrugItem> DrugItems { get; set; }
    public DbSet<DrugsStore> DrugsStores { get; set; }
    public DbSet<FavoriteDrug> FavoriteDrugs { get; set; }
    public DbSet<Profile> Profiles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new DrugConfiguration());
    }
}