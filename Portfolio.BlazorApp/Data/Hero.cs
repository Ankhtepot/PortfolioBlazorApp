namespace Portfolio.BlazorApp.Data;

public class Hero
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Level { get; set; }
    public int BaseDamage { get; set; }
    public int BaseDefense { get; set; }
    public int HealthByLevel { get; set; }

    public ICollection<PlayerHero> PlayerHeroes { get; set; } = new List<PlayerHero>();
    public ICollection<HeroItem> EquippedItems { get; set; } = new List<HeroItem>();
}

public class HeroItem
{
    public int HeroId { get; set; }
    public Hero Hero { get; set; } = null!;
    public int ItemId { get; set; }
    public Item Item { get; set; } = null!;
}