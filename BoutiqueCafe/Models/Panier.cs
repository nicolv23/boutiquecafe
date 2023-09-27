namespace BoutiqueCafe.Models
{
    public class Panier
    {
        public int Id { get; set; }
        public Produit? Produit { get; set; }
        public int Quantite { get; set; }
        public string? PanierAchatId { get; set; }
    }
}
