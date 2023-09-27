using BoutiqueCafe.Migrations;

namespace BoutiqueCafe.Models.Interfaces
{
    public interface IPanierAchatRepository
    {
        void AjouterAuPanier(Produit produit);
        int RetirerDuPanier(Produit produit);
        List<Panier> GetPanierArticles();
        void SupprimerPanier();
        decimal GetPanierAchatTotal();
        public List<Panier>? PanierArticlesRecuperes { get; set; }
    }
}
