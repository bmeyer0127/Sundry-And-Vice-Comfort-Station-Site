using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class CircleHospitalityContext : DbContext
{
  public DbSet<Location> Locations { get; set; }
  public DbSet<LocationMenu> LocationMenus { get; set; }
  public DbSet<MenuItem> MenuItems { get; set; }
  public DbSet<ItemType> ItemTypes { get; set; }
  public DbSet<ItemIngredient> ItemIngredients { get; set; }
  public DbSet<Ingredient> Ingredients { get; set; }
  public DbSet<Measurement> Measurements { get; set; }
  public DbSet<HoursOpen> HoursOpens { get; set; }
  public DbSet<Gallery> Galleries { get; set; }
}