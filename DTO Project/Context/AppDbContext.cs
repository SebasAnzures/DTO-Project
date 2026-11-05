using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DTO_Project.Modelo;

namespace DTO_Project.Context
{
    internal class AppDbContext: DbContext
    {
        public DbSet<Element> Elements { get; set; }
        public DbSet<Characters> Characters { get; set; }
        public DbSet<Enemy> Enemies { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<Moves> Moves { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=rpg.db");
        }
    }
}
