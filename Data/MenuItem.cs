using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

public class MenuItem
{
    public int MenuItemID { get; set; }
    [Required]
    public int ItemTypeID { get; set; }
    public int LocationID { get; set; }
    [Required]
    public string? ItemName { get; set; }
    public string? ItemDescription { get; set; }
    public string? CreatorName { get; set; }

    public virtual List<Location>? Locations { get; set; } = new List<Location>();
    public virtual List<ItemIngredient>? ItemIngredients { get; set; } = new List<ItemIngredient>();
    public virtual Location? Location { get; set; }
    public virtual ItemType? ItemType { get; set; }
}