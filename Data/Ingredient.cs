using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

public class Ingredient
{
    public int IngredientID { get; set; }
    [Required]
    public string? IngredientName { get; set; }
}