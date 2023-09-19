using BoutiqueCafe.Data;
using BoutiqueCafe.Models.Interfaces;

namespace BoutiqueCafe.Models.Services
{
    public class ProduitRepository : IProduitRepository
    {
        private BoutiqueCafeDbContext dbContext;
        public ProduitRepository(BoutiqueCafeDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Produit> GetAllProduits()
        {
            return dbContext.Produits;
        }

        public Produit? GetDetailProduit(int id)
        {
            return dbContext.Produits.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Produit> GetPopulaireProduits()
        {
            return dbContext.Produits.Where(p => p.EstPopulaire);
        }
    }
}
