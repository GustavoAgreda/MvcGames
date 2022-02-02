using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcGames.Data;
using System;
using System.Linq;

namespace MvcGames.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcGamesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcGamesContext>>()))
            {
                // Look for any games.
                if (context.Games.Any())
                {
                    return;   // DB has been seeded
                }

                context.Games.AddRange(
                    new Games
                    {
                        Title = "Horizon Zero Dawn",
                        ReleaseDate = DateTime.Parse("2070-2-28"),
                        Genre = "RPG",
                        Price = 38.99M,
                        Clasification = "16",
                        Size = "33.22 GB",
                        Company = "Guerrilla Games"
                    },

                    new Games
                    {
                        Title = "God of war",
                        ReleaseDate = DateTime.Parse("2018-4-20"),
                        Genre = "RPG Hack and Slash",
                        Price = 20.00M,
                        Clasification = "18",
                        Size = "28.80 GB",
                        Company = "Sony Interactive Entertainment"
                    },

                    new Games
                    {
                        Title = "Nioh",
                        ReleaseDate = DateTime.Parse("2017-2-7"),
                        Genre = "Hack and Slash",
                        Price = 18.99M,
                        Clasification = "18",
                        Size = "27.07 GB",
                        Company = "Team Ninja"
                    },

                    new Games
                    {
                        Title = "Control",
                        ReleaseDate = DateTime.Parse("2019-8-27"),
                        Genre = "Shooter",
                        Price = 11.99M,
                        Clasification = "18",
                        Size = "32.90 GB",
                        Company = "Remedy Entertainment"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}