using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

public class MenuItem
{
    public int MenuItemID { get; set; }
    [Required]
    public int ItemTypeID { get; set; }
    [Required]
    public string? ItemName { get; set; }
    public string? ItemDescription { get; set; }
    public string? CreatorName { get; set; }
    public bool HasEgg { get; set; } = false;
    public bool HasDairy { get; set; } = false;

    public virtual ItemType? ItemType { get; set; }
}