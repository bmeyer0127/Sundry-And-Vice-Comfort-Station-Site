using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

[PrimaryKey(nameof(MenuItemID), nameof(IngredientID))]
public class ItemIngredient
{
    public int MenuItemID { get; set; }
    public int IngredientID { get; set; }
    public int MeasurementID { get; set; }
    public int MeasurementAmount { get; set; }

    public virtual Measurement? Measurement { get; set; }
    public virtual Ingredient? Ingredient { get; set; }
    public virtual MenuItem? MenuItem { get; set; }
}