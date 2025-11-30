using Microsoft.EntityFrameworkCore;

namespace Portfolio.BlazorApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    
    public DbSet<Item> Items => Set<Item>();
    public DbSet<Player> Players => Set<Player>();
    public DbSet<Hero> Heroes => Set<Hero>();
    public DbSet<Soldier> Soldiers => Set<Soldier>();
    public DbSet<PlayerHero> PlayerHeroes => Set<PlayerHero>();
    public DbSet<PlayerSoldier> PlayerSoldiers => Set<PlayerSoldier>();
    public DbSet<PlayerItem> PlayerItems => Set<PlayerItem>();
    public DbSet<HeroItem> HeroItems => Set<HeroItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<PlayerHero>()
            .HasKey(ph => new { ph.PlayerId, ph.HeroId });

        modelBuilder.Entity<PlayerSoldier>()
            .HasKey(ps => new { ps.PlayerId, ps.SoldierId });

        modelBuilder.Entity<PlayerItem>()
            .HasKey(pi => new { pi.PlayerId, pi.ItemId });

        modelBuilder.Entity<HeroItem>()
            .HasKey(hi => new { hi.HeroId, hi.ItemId });
        
        DbSeeder.SeedData(modelBuilder);
    }
}