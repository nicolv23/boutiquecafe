namespace BoutiqueCafe.Models
{
    public class CommandeDetail
    {
        public int CommandeDetailId { get; set; }
        public int ProduitId { get; set; }
        public Produit? Produit { get; set; }
        public int CommandeId { get; set; }
        public Commande? Commande { get; set; }
        public int Quantite { get; set; }
        public decimal Prix { get; set; }
    }
}
