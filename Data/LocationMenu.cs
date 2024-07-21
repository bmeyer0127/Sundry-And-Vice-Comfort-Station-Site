using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

[PrimaryKey(nameof(LocationID), nameof(MenuItemID))]
public class LocationMenu
{
    public int LocationID { get; set; }
    public int MenuItemID { get; set; }
    [Required]
    public int Price { get; set; }
    public bool HasEgg { get; set; }
    [Required]
    public bool HasDairy { get; set; }

    public virtual MenuItem? MenuItem { get; set; }
    public virtual Location? Location { get; set; }
}