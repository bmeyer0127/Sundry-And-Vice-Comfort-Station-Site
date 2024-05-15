using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

[PrimaryKey(nameof(LocationID), nameof(PathToPicture))]
public class Gallery
{
  public int LocationID { get; set; }
  public string? PathToPicture { get; set; }

  public string? PictureDescription { get; set; }
}