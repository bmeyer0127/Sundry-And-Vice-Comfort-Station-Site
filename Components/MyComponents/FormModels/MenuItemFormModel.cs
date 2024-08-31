using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

namespace MyComponents.FormModels.MenuItemFormModel;

public class MenuItemFormModel
{
    // MenuItem columns
    [Required]
    public int ItemTypeID { get; set; }
    [Required]
    public string? ItemName { get; set; }
    public string? ItemDescription { get; set; }
    public string? CreatorName { get; set; }

    // LocationMenu columns
    public int Price { get; set; }
    public bool HasEgg { get; set; }
    public bool HasDairy { get; set; }
}
