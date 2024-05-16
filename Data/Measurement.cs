using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

public class Measurement
{
    public int MeasurementID { get; set; }
    [Required]
    public string? MeasurementDescription { get; set; }
}