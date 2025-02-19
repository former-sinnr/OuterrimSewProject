using Microsoft.EntityFrameworkCore;
using Database.Entities;

namespace Database.Context;

public class AircraftContext:DbContext
{
    public DbSet<Aircraft> Aircrafts { get; set; }
    public DbSet<AircraftSpecification> AircraftSpecifications { get; set; }
    public DbSet<Compartment> Compartments { get; set; }
    public DbSet<Machinery> Machineries { get; set; }
    public DbSet<Weapon> Weapons { get; set; }
    public DbSet<EnvironmentalSystem> EnvironmentalSystems { get; set; }
    public DbSet<Mercenary> Mercenaries { get; set; }
    public DbSet<AircraftCrew> AircraftCrews { get; set; }
    public DbSet<CrimeSyndicate> CrimeSyndicates { get; set; }
    public DbSet<MercenaryReputation> MercenaryReputations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AircraftCrew>()
            .HasKey(ac => new { ac.AircraftId, ac.MercenaryId });
        
        modelBuilder.Entity<MercenaryReputation>()
            .HasKey(mr => new {mr.SyndicateId, mr.MercenaryId});
    }
}