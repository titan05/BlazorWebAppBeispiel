namespace BlazorApp42.Components.Models
{
    public class Artikel
    {
        public int Id { get; set; }
        public string Bezeichnung { get; set; }
        public int? ArtikelInventarId { get; set; }
        public ArtikelInventar? ArtikelInventar { get; set; }
    }
}
