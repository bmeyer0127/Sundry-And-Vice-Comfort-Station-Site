using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

public class Location
{
  public int LocationID { get; set; }

  [Required]
  public string? LocationName { get; set; }

  [Required]
  public string? LocationAddress { get; set; }
}