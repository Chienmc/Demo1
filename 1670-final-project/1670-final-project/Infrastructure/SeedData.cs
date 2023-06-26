using _1670_final_project.Models;
using Microsoft.EntityFrameworkCore;

namespace _1670_final_project.Infrastructure
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();

            if (!context.Products.Any())
            {
                Category roadbikes = new Category { Name = "Road Bikes", Slug = "road-bikes"};
                Category mountainbikes = new Category { Name = "Mountain Bikes", Slug = "mountain-bikes" };

                context.Products.AddRange(
                        new Product
                        {
                            Name = "Preamble Drop Bar",
                            Slug = "preamble-drop-bar",
                            Description = "Designed to introduce unfamiliar riders to Surly’s pavement and gravel line, Preamble highlights Surly’s most essential features: Durable custom steel tubing, a renowned ride feel, and just the right mounts for running racks, fenders, and bottle cages.", 
                            Price = 1199.00M,
                            Category = roadbikes
                        },
                        new Product
                        {
                            Name = "2023 Synapse 2",
                            Slug = "2023-synapse-2",
                            Description = "Roll smooth, roll fast, roll confident. Wherever the road takes you, roll with Synapse – our most comfortable, all-around, up-for-anything, pure road machine.",
                            Price = 1800.00M,
                            Category = roadbikes
                        },
                        new Product
                        {
                            Name = "2023 CAAD OPTIMO 3",
                            Slug = "2023-caad-optimo-3",
                            Description = "A true performance road bike with race-winning DNA – delivering champagne experience for lemonade money.",
                            Price = 1300.00M,
                            Category = roadbikes
                        },
                        new Product
                        {
                            Name = "Hook EXT TI",
                            Slug = "hook-ext-ti",
                            Description = "HOOK EXT TI The versatile Hook EXT TI distills the rough-and-ready yet comfortable nature of the Hook collection.",
                            Price = 5039.00M,
                            Category = roadbikes
                        },
                        new Product
                        {
                            Name = "2022 Scalpel Carbon SE 2",
                            Slug = "hook-ext-ti",
                            Description = "Scalpel SE is the ultimate marathon racer and high-speed trail slayer. World Cup fast and all-mountain fierce – this is next-level cross-country mountain bike performance.",
                            Price = 3999.00M,
                            Category = mountainbikes
                        },
                        new Product
                        {
                            Name = "Wednesday Fat Bike - Shangri-La Green",
                            Slug = "wednesday-fat-bike-shangri-la-green",
                            Description = "The Wednesday is Surly's all-terrain fat bike. The frame features trail-ready geometry, 4.6\" of tire clearance, provides lots of cargo carrying capabilities and is paired with a 100mm suspension-corrected fork.",
                            Price = 1849.00M,
                            Category = mountainbikes
                        },
                        new Product
                        {
                            Name = "2022 Cinder Cone",
                            Slug = "wednesday-fat-bike-shangri-la-green",
                            Description = "Much like its larger-wheeled sibling, the Mahuna, the Cinder Cone is the perfect all-rounder for the person looking to ride off-road or cruise around the backwoods bike paths.",
                            Price = 959.00M,
                            Category = mountainbikes
                        },
                        new Product
                        {
                            Name = "2021 Scalpel Carbon LTD",
                            Slug = "2021-scalpel-crb-ltd",
                            Description = "This is the ultimate XC race bike. Ground-breaking suspension, aggressive geometry and feathery weight let you go full gas from the gun.",
                            Price = 6995.00M,
                            Category = mountainbikes
                        }
                );
                context.SaveChanges();
            }
        }
    }
}