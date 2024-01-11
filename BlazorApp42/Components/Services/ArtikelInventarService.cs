using BlazorApp42.Components.Core;
using BlazorApp42.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp42.Components.Services
{
    public class ArtikelInventarService
    {
        private readonly MyAppContext _appContext;

        public ArtikelInventarService(MyAppContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<List<ArtikelInventar>> GetAllArtikelInventar() => await _appContext.ArtikelInventar.ToListAsync();

    }
}
