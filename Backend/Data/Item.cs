using System.ComponentModel.DataAnnotations;

namespace Backend.Data;

public class Item
{
    public int Id { get; set; }
    
    [MaxLength(50)]
    public string? Name { get; set; } = string.Empty;
    public int Damage { get; set; }
    public int Defense { get; set; }
    [MaxLength(100)]
    public string ImageUrl { get; set; } = string.Empty;
    
}