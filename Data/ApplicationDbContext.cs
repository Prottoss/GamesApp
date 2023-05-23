using System;
using System.Collections.Generic;
using System.Text;
using GamesWebAppDB.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GamesWebAppDB.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<AppUser> Applicationusers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            //seed Genres
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 1, name = "Action" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 2, name = "RPG" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 3, name = "Adventure" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 4, name = "Survival" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 5, name = "FPS" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 6, name = "Racing" });

            //seed Games
            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 10,
                name = "Cyberpunk 2077",
                developer = "CD Project Red",
                multiplayer = false,
                price = 59,
                release = 2020,
                GenreId = 2,
                imgurl = "4fa3dcb2-a0e3-4a84-891b-6368a9d1b667_co4hk8.png"
            }) ;

            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 11,
                name = "Lost Ark",
                developer = "Smilegate",
                price = 14,
                multiplayer = true,
                release = 2022,
                GenreId = 2,
                imgurl = "83885bc8-aaef-4f39-a09c-292dce442bdc_co4hb5.png"
            }) ;

            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 12,
                name = "DayZ",
                developer = "Bohemia Interactive",
                price = 39,
                multiplayer = true,
                release = 2014,
                GenreId = 4,
                imgurl = "86c62277-6cf4-4b61-a426-4cc632485523_co2dhb.png"
            }) ;

            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 13,
                name = "Sea of Thieves",
                developer = "Rare",
                price = 29,
                multiplayer = true,
                release = 2018,
                GenreId = 3,
                imgurl = "b8eb6138-17ea-49c5-975b-1f3598d4c91f_co2558.png"
            }) ;

            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 14,
                name = "Valheim",
                developer = "Iron Gate",
                price = 19,
                multiplayer = true,
                release = 2021,
                GenreId = 4,
                imgurl = "53598ccb-fda5-4f0d-ab35-25e3b4d1cbc0_co2x61.png"
            });

            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 15,
                name = "Doom",
                developer = "Bethesda Software",
                price = 49,
                multiplayer = true,
                release = 2018,
                GenreId = 5,
                imgurl = "443124b2-e794-4b89-a207-4e541b59e3b2_co1v7g.png"
            });

            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 16,
                name = "Valorant",
                developer = "Riot Games",
                price = 0,
                multiplayer = true,
                release = 2020,
                GenreId = 5,
                imgurl = "2c349b4e-0bb4-4189-b1ce-3e48402764cc_co2mvt.png"
            });

            modelBuilder.Entity<Game>().HasData(new Game
            {
                Id = 17,
                name = "Monster Hunter: World",
                developer = "Capcom",
                price = 39,
                multiplayer = true,
                release = 2018,
                GenreId = 3,
                imgurl = "71815838-9931-442c-9bca-b720cbf3d988_co1rst.png"
            });
        }
    }
}
