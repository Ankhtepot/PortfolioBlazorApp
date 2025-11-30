namespace Portfolio.BlazorApp.Data;

public class Soldier
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Level { get; set; }
    public int BaseDamage { get; set; }
    public int BaseDefense { get; set; }

    public ICollection<PlayerSoldier> PlayerSoldiers { get; set; } = new List<PlayerSoldier>();
}