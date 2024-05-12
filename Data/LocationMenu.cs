using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

public class LocationMenu
{
  // LocationID + ItemID = PK
  public int LocationID { get; set; }
  public int ItemID { get; set; }

  [Required]
  public bool HasEgg { get; set; }

  [Required]
  public bool HasDairy { get; set; }
}