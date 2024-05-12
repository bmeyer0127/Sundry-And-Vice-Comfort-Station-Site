using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

public class Gallery
{
  // LocationID + PathToPicture = PK
  public int LocationID { get; set; }
  public string? PathToPicture { get; set; }

  public string? PictureDescription { get; set; }
}