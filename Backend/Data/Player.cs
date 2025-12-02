using System.ComponentModel.DataAnnotations;

namespace Backend.Data;

public class Player
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    [MaxLength(100)]
    public string ImageUrl { get; set; } = string.Empty;

    public ICollection<PlayerHero> PlayerHeroes { get; set; } = new List<PlayerHero>();
    public ICollection<PlayerSoldier> PlayerSoldiers { get; set; } = new List<PlayerSoldier>();
    public ICollection<PlayerItem> Inventory { get; set; } = new List<PlayerItem>();
}

public class PlayerHero
{
    public int PlayerId { get; set; }
    public Player Player { get; set; } = null!;
    public int HeroId { get; set; }
    public Hero Hero { get; set; } = null!;
}

public class PlayerSoldier
{
    public int PlayerId { get; set; }
    public Player Player { get; set; } = null!;
    public int SoldierId { get; set; }
    public Soldier Soldier { get; set; } = null!;
}

public class PlayerItem
{
    public int PlayerId { get; set; }
    public Player Player { get; set; } = null!;
    public int ItemId { get; set; }
    public Item Item { get; set; } = null!;
}