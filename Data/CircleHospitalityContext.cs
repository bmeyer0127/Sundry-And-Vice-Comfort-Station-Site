using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class CircleHospitalityContext : DbContext
{
    public IConfiguration _config {  get; set; }
    public CircleHospitalityContext(IConfiguration config)
    {
        _config = config;
    }

    // Change the Connection string depending on whether I am on my laptop or desktop for SQL Server connection
    // Desktop Connection
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer(_config.GetConnectionString("DesktopDatabaseConnection"));
    //XPS Connection
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
    //    optionsBuilder.UseSqlServer(_config.GetConnectionString("XPSConnection"));


    public DbSet<Location> Locations { get; set; }
    public DbSet<MenuItem> MenuItems { get; set; }
    public DbSet<ItemType> ItemTypes { get; set; }
    public DbSet<ItemIngredient> ItemIngredients { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Measurement> Measurements { get; set; }
    public DbSet<LocationMenu> LocationMenus { get; set; }
}