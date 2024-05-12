using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

public class ItemIngredient
{
  //ItemID + IngredientID = PK
  public int ItemID { get; set; }
  public int IngredientID { get; set; }

  public int MeasurementID { get; set; }
}