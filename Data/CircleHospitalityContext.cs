using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

public class CircleHospitalityContext : DbContext
{
    public IConfiguration _config {  get; set; }
    public CircleHospitalityContext(IConfiguration config)
    {
        _config = config;
    }

    public DbSet<Location> Locations { get; set; }
    public DbSet<MenuItem> MenuItems { get; set; }
    public DbSet<ItemType> ItemTypes { get; set; }
    public DbSet<ItemIngredient> ItemIngredients { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Measurement> Measurements { get; set; }
    public DbSet<LocationMenu> LocationMenus { get; set; }

    // Data seeding
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // LOCATION
        modelBuilder.Entity<Location>().HasData(
            new Location
            { LocationID = 1, LocationName = "Sundry and Vice - Indy", LocationAddress = "850 Massachusetts Ave, Indianapolis, IN 46204" },
            new Location
            { LocationID = 2, LocationName = "Sundry and Vice - Cincy", LocationAddress = "18 W 13th St, Cincinnati, OH 45202" },
            new Location
            { LocationID = 3, LocationName = "Comfort Station - Cincy", LocationAddress = "793 E McMillan St, Cincinnati, OH 45206" }
        );

        // MENUITEM
        modelBuilder.Entity<MenuItem>().HasData(
            new MenuItem
            { MenuItemID = 1, ItemTypeID = 2, ItemName = "Night Cure", ItemDescription = "Curing" },
            new MenuItem
            { MenuItemID = 2, ItemTypeID = 1, ItemName = "Gimlet", ItemDescription = "Refreshing" },
            new MenuItem
            { MenuItemID = 3, ItemTypeID = 2, ItemName = "Persephone's Papercut", ItemDescription = "Sweet and evil", CreatorName = "Brett" },
            new MenuItem
            { MenuItemID = 4, ItemTypeID = 1, ItemName = "Whiskey Sour", ItemDescription = "You know" },
            new MenuItem
            { MenuItemID = 5, ItemTypeID = 1, ItemName = "Daiquiri", ItemDescription = "You need one" },
            new MenuItem
            { MenuItemID = 6, ItemTypeID = 4, ItemName = "Narraganset", ItemDescription = "Taste the East Coast" },
            new MenuItem
            { MenuItemID = 7, ItemTypeID = 4, ItemName = "PBR", ItemDescription = "I want it so bad" },
            new MenuItem
            { MenuItemID = 8, ItemTypeID = 3, ItemName = "Draft Old Fashioned", ItemDescription = "It's fine" },
            new MenuItem
            { MenuItemID = 9, ItemTypeID = 5, ItemName = "Cabernet", ItemDescription = "Dry and fine" },
            new MenuItem
            { MenuItemID = 10, ItemTypeID = 5, ItemName = "Chenin Blanc", ItemDescription = "Extremely mid" }
        );

        // ITEMTYPE
        modelBuilder.Entity<ItemType>().HasData(
            new ItemType
            { ItemTypeID = 1, ItemTypeDescription = "Classic" },
            new ItemType
            { ItemTypeID = 2, ItemTypeDescription = "House" },
            new ItemType
            { ItemTypeID = 3, ItemTypeDescription = "Draft" },
            new ItemType
            { ItemTypeID = 4, ItemTypeDescription = "Beer" },
            new ItemType
            { ItemTypeID = 5, ItemTypeDescription= "Wine" }
        );

        // ITEMINGREDIENT
        modelBuilder.Entity<ItemIngredient>().HasData(
            new ItemIngredient
            { MenuItemID = 1, IngredientID = 1, MeasurementID = 1, MeasurementAmount = 0.75f},
            new ItemIngredient
            { MenuItemID = 1, IngredientID = 7, MeasurementID = 1, MeasurementAmount = 0.75f},
            new ItemIngredient
            { MenuItemID = 1, IngredientID = 15, MeasurementID = 1, MeasurementAmount = 2},
            new ItemIngredient
            { MenuItemID = 1, IngredientID = 24, MeasurementID = 5, MeasurementAmount = 1},
            new ItemIngredient
            { MenuItemID = 2, IngredientID = 2, MeasurementID = 1, MeasurementAmount = 1},
            new ItemIngredient
            { MenuItemID = 2, IngredientID = 6, MeasurementID = 1, MeasurementAmount = 0.75f},
            new ItemIngredient
            { MenuItemID = 2, IngredientID = 12, MeasurementID = 1, MeasurementAmount = 2},
            new ItemIngredient
            { MenuItemID = 3, IngredientID = 1, MeasurementID = 1, MeasurementAmount = 0.75f},
            new ItemIngredient
            { MenuItemID = 3, IngredientID = 7, MeasurementID = 1, MeasurementAmount = 0.25f},
            new ItemIngredient
            { MenuItemID = 3, IngredientID = 10, MeasurementID = 1, MeasurementAmount = 0.5f},
            new ItemIngredient
            { MenuItemID = 3, IngredientID = 18, MeasurementID = 1, MeasurementAmount = 1.5f},
            new ItemIngredient
            { MenuItemID = 3, IngredientID = 22, MeasurementID = 6, MeasurementAmount = 1},
            new ItemIngredient
            { MenuItemID = 3, IngredientID = 23, MeasurementID = 4, MeasurementAmount = 6},
            new ItemIngredient
            { MenuItemID = 4, IngredientID = 1, MeasurementID = 1, MeasurementAmount = 0.75f},
            new ItemIngredient
            { MenuItemID = 4, IngredientID = 6, MeasurementID = 1, MeasurementAmount = 0.75f},
            new ItemIngredient
            { MenuItemID = 4, IngredientID = 15, MeasurementID = 1, MeasurementAmount = 2},
            new ItemIngredient
            { MenuItemID = 5, IngredientID = 2, MeasurementID = 1, MeasurementAmount = 1},
            new ItemIngredient
            { MenuItemID = 5, IngredientID = 6, MeasurementID = 1, MeasurementAmount = 0.75f},
            new ItemIngredient
            { MenuItemID = 5, IngredientID = 13, MeasurementID = 1, MeasurementAmount = 2},
            new ItemIngredient
            { MenuItemID = 5, IngredientID = 25, MeasurementID = 3, MeasurementAmount = 1}
        );

        // INGREDIENT
        modelBuilder.Entity<Ingredient>().HasData(
            // JUICES
            new Ingredient
            { IngredientID = 1,  IngredientName = "Lemon Juice" },
            new Ingredient
            { IngredientID = 2, IngredientName = "Lime Juice" },
            new Ingredient
            { IngredientID = 3, IngredientName = "Pineapple Juice" },
            new Ingredient
            { IngredientID = 4, IngredientName = "Grapefruit Juice" },
            new Ingredient
            { IngredientID = 5, IngredientName = "Orange Juice" },
            // SYRUPS
            new Ingredient
            { IngredientID = 6, IngredientName = "Simple Syrup" },
            new Ingredient
            { IngredientID = 7, IngredientName = "Honey Syrup" },
            new Ingredient
            { IngredientID = 8, IngredientName = "Ginger Syrup" },
            new Ingredient
            { IngredientID = 9, IngredientName = "Demerara Syrup" },
            // LIQUEURS
            new Ingredient
            { IngredientID = 10, IngredientName = "Passionfruit Liqueur" },
            // SPIRITS
            new Ingredient
            { IngredientID = 11, IngredientName = "Vodka (Non-Specific)" },
            new Ingredient
            { IngredientID = 12, IngredientName = "Gin (Non-Specific)" },
            new Ingredient
            { IngredientID = 13, IngredientName = "Rum (Non-Specific)" },
            new Ingredient
            { IngredientID = 14, IngredientName = "Tequila (Non-Specific)" },
            new Ingredient
            { IngredientID = 15, IngredientName = "Bourbon (Non-Specific)" },
            new Ingredient
            { IngredientID = 16, IngredientName = "Rye (Non-Specific)" },
            new Ingredient
            { IngredientID = 17, IngredientName = "Scotch (Non-Specific)" },
            new Ingredient
            { IngredientID = 18, IngredientName = "New Riff Kentucky Wild Gin" },
            // BITTERS
            new Ingredient
            { IngredientID = 19, IngredientName = "Angostura Bitters" },
            new Ingredient
            { IngredientID = 20, IngredientName = "Orange Bitters" },
            new Ingredient
            { IngredientID = 21, IngredientName = "Peychaud's Bitters" },
            // MISC
            new Ingredient
            { IngredientID = 22, IngredientName = "Serrano Pepper" },
            new Ingredient
            { IngredientID = 23, IngredientName = "Fresh Mint" },
            new Ingredient
            { IngredientID = 24, IngredientName = "Grapefruit Peel" },
            new Ingredient
            { IngredientID = 25, IngredientName = "Saline" }
        );

        // MEASUREMENT
        modelBuilder.Entity<Measurement>().HasData(
            new Measurement
            { MeasurementID = 1, MeasurementDescription = "oz"},
            new Measurement
            { MeasurementID = 2, MeasurementDescription = "ml" },
            new Measurement
            { MeasurementID = 3, MeasurementDescription = "dash(es)" },
            new Measurement
            { MeasurementID = 4, MeasurementDescription = "leaf/leaves" },
            new Measurement
            { MeasurementID = 5, MeasurementDescription = "peel(s)" },
            new Measurement
            { MeasurementID = 6, MeasurementDescription = "slice(s)" }
        );

        // LOCATIONMENU
        modelBuilder.Entity<LocationMenu>().HasData(
            new LocationMenu
            { LocationID = 1, MenuItemID = 1, Price = 14 },
            new LocationMenu
            { LocationID = 1, MenuItemID = 2, Price = 15 },
            new LocationMenu
            { LocationID = 1, MenuItemID = 3, Price = 12 },
            new LocationMenu
            { LocationID = 1, MenuItemID = 5, Price = 6 },
            new LocationMenu
            { LocationID = 1, MenuItemID = 6, Price = 5 },
            new LocationMenu
            { LocationID = 1, MenuItemID = 7, Price = 6 },
            new LocationMenu
            { LocationID = 1, MenuItemID = 8, Price = 4 },
            new LocationMenu
            { LocationID = 1, MenuItemID = 9, Price = 12 },
            new LocationMenu
            { LocationID = 1, MenuItemID = 10, Price = 11 },
            new LocationMenu
            { LocationID = 2, MenuItemID = 1, Price = 13 },
            new LocationMenu
            { LocationID = 2, MenuItemID = 2, Price = 16 },
            new LocationMenu
            { LocationID = 2, MenuItemID = 5, Price = 7 },
            new LocationMenu
            { LocationID = 2, MenuItemID = 9, Price = 12 },
            new LocationMenu
            { LocationID = 2, MenuItemID = 10, Price = 11 },
            new LocationMenu
            { LocationID = 2, MenuItemID = 6, Price = 5 },
            new LocationMenu
            { LocationID = 2, MenuItemID = 7, Price = 6 },
            new LocationMenu
            { LocationID = 2, MenuItemID = 8, Price = 7 },
            new LocationMenu
            { LocationID = 3, MenuItemID = 2, Price = 15 },
            new LocationMenu
            { LocationID = 3, MenuItemID = 4, Price = 16 },
            new LocationMenu
            { LocationID = 3, MenuItemID = 5, Price = 12 },
            new LocationMenu
            { LocationID = 3, MenuItemID = 8, Price = 4 },
            new LocationMenu
            { LocationID = 3, MenuItemID = 9, Price = 12 },
            new LocationMenu
            { LocationID = 3, MenuItemID = 10, Price = 10 }
        );
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer(_config.GetConnectionString("DBConnection"));
}