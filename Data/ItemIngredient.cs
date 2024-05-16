using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

[PrimaryKey(nameof(MenuItemID), nameof(IngredientID))]
public class ItemIngredient
{
    public int MenuItemID { get; set; }
    public int IngredientID { get; set; }
    public int MeasurementID { get; set; }

    public virtual List<MenuItem>? MenuItems { get; set; } = new List<MenuItem>();
    public virtual List<Ingredient>? Ingredients { get; set; } = new List<Ingredient>();
    public virtual List<Measurement>? Measurements { get; set; } = new List<Measurement>();
    public virtual Ingredient? Ingredient { get; set; }
    public virtual Measurement? Measurement { get; set; }
}