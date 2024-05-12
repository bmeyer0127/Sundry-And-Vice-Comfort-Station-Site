using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

public class HoursOpen
{
  public int LocationID { get; set; }

  [Required]
  public string? DayOfWeek { get; set; }

  [Required]
  public DateTime? OpenTime { get; set; }

  [Required]
  public DateTime? CloseTime { get; set; }
}