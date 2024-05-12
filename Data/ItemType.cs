using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

public class ItemType
{
  public int ItemTypeID { get; set; }

  [Required]
  public string? ItemTypeDescription { get; set; }
}