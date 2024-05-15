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
}