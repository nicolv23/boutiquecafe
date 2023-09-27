namespace BoutiqueCafe.Models.Interfaces
{
    public interface IProduitRepository
    {
        IEnumerable<Produit> GetAllProduits();
        IEnumerable<Produit> GetPopulaireProduits();
        Produit? GetDetailProduit(int id);
    }
}
