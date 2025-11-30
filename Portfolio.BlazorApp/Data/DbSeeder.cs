using Microsoft.EntityFrameworkCore;

namespace Portfolio.BlazorApp.Data;

internal class DbSeeder
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>().HasData(
            new Item {Id = 1, Name = "Iron Sword", Damage = 10, Defense = 0},
            new Item {Id = 2, Name = "Longbow", Damage = 8, Defense = 0},
            new Item {Id = 3, Name = "Fire Staff", Damage = 12, Defense = 0},
            new Item {Id = 4, Name = "Dagger", Damage = 6, Defense = 0},
            new Item {Id = 5, Name = "War Axe", Damage = 14, Defense = 0},
            new Item {Id = 6, Name = "Leather Armor", Damage = 0, Defense = 5},
            new Item {Id = 7, Name = "Iron Shield", Damage = 0, Defense = 8},
            new Item {Id = 8, Name = "Chainmail", Damage = 0, Defense = 10},
            new Item {Id = 9, Name = "Magic Cloak", Damage = 0, Defense = 7},
            new Item {Id = 10, Name = "Tower Shield", Damage = 0, Defense = 12}
        );

        modelBuilder.Entity<Player>().HasData(
            new Player {Id = 1, Name = "Demo Player"}
        );

        modelBuilder.Entity<Hero>().HasData(
            new Hero {Id = 1, Name = "Arthas", Level = 5, BaseDamage = 12, BaseDefense = 6},
            new Hero {Id = 2, Name = "Lyra", Level = 4, BaseDamage = 10, BaseDefense = 8}
        );

        modelBuilder.Entity<Soldier>().HasData(
            new Soldier {Id = 1, Name = "Footman", Level = 2, BaseDamage = 6, BaseDefense = 4},
            new Soldier {Id = 2, Name = "Archer", Level = 2, BaseDamage = 7, BaseDefense = 3}
        );

        modelBuilder.Entity<PlayerHero>().HasData(
            new PlayerHero {PlayerId = 1, HeroId = 1},
            new PlayerHero {PlayerId = 1, HeroId = 2}
        );

        modelBuilder.Entity<PlayerSoldier>().HasData(
            new PlayerSoldier {PlayerId = 1, SoldierId = 1},
            new PlayerSoldier {PlayerId = 1, SoldierId = 2}
        );

        modelBuilder.Entity<PlayerItem>().HasData(
            new PlayerItem {PlayerId = 1, ItemId = 1},
            new PlayerItem {PlayerId = 1, ItemId = 2},
            new PlayerItem {PlayerId = 1, ItemId = 6},
            new PlayerItem {PlayerId = 1, ItemId = 7}
        );

        modelBuilder.Entity<HeroItem>().HasData(
            new HeroItem {HeroId = 1, ItemId = 1}, // Arthas with Iron Sword
            new HeroItem {HeroId = 1, ItemId = 7}, // shield
            new HeroItem {HeroId = 2, ItemId = 2}, // Lyra with Longbow
            new HeroItem {HeroId = 2, ItemId = 6} // leather armor
        );
    }
}