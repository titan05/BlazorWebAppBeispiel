using BlazorApp42.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp42.Components.Core
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<Artikel> Artikels { get; set; }
        public DbSet<ArtikelInventar> ArtikelInventar { get; set; }

    }
}
