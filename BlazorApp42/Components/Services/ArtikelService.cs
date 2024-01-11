using BlazorApp42.Components.Core;
using BlazorApp42.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp42.Components.Services
{
    public class ArtikelService
    {
        private readonly MyAppContext _appContext;

        public ArtikelService(MyAppContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<List<Artikel>> GetAllArtikel() => await _appContext.Artikels.Include(a => a.ArtikelInventar).ToListAsync();

        public async Task CreateArtikel(string newArtikel,int? artikelInventarId)
        {
            _appContext.Artikels.Add(new() { 
                Bezeichnung = newArtikel, 
                ArtikelInventarId = artikelInventarId 
            });
            await _appContext.SaveChangesAsync();
        }
        public async Task DeleteArtikel(int artikelId)
        {
            var artikelFromDb = await _appContext.Artikels.FindAsync(artikelId);
            _appContext.Artikels.Remove(artikelFromDb);
            await _appContext.SaveChangesAsync();
        }
    }
}
