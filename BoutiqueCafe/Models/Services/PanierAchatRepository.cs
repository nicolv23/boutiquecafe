using BoutiqueCafe.Data;
using BoutiqueCafe.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BoutiqueCafe.Models.Services
{
    public class PanierAchatRepository : IPanierAchatRepository
    {
        private BoutiqueCafeDbContext dbContext;
        public PanierAchatRepository(BoutiqueCafeDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Panier>? PanierArticles { get; set; }
        public string? PanierArticlesId { get; set; }
        List<Panier>? IPanierAchatRepository.PanierArticlesRecuperes { get; set; }

        public static PanierAchatRepository GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;

            BoutiqueCafeDbContext context = services.GetService<BoutiqueCafeDbContext>() ?? throw new Exception("Error initializing boutiquecafedbcontext");

            string panierId = session?.GetString("PanierId") ?? Guid.NewGuid().ToString();

            session?.SetString("PanierId", panierId);

            return new PanierAchatRepository(context) { PanierArticlesId = panierId };
        }

        public void AjouterAuPanier(Produit produit)
        {
            var PanierItem = dbContext.PanierArticles.FirstOrDefault(s => s.Produit.Id == produit.Id && s.PanierAchatId == PanierArticlesId);
            if (PanierItem == null)
            {
                PanierItem = new Panier()
                {
                    PanierAchatId = PanierArticlesId,
                    Produit = produit,
                    Quantite = 1
                };
                dbContext.PanierArticles.Add(PanierItem);
            }
            else
            {
                PanierItem.Quantite++;
            }
            dbContext.SaveChanges();
        }

        public decimal GetPanierAchatTotal()
        {
            var coutTotal = dbContext.PanierArticles.Where(s => s.PanierAchatId == PanierArticlesId)
        .Select(s => s.Produit.Prix * s.Quantite).Sum();
            return coutTotal;
        }

        public List<Panier> GetPanierArticles()
        {
            return PanierArticles ??= dbContext.PanierArticles.Where(s => s.PanierAchatId == PanierArticlesId)
         .Include(p => p.Produit).ToList();
        }

        public int RetirerDuPanier(Produit produit)
        {
            var PanierItem = dbContext.PanierArticles.FirstOrDefault(s => s.Produit.Id == produit.Id && s.PanierAchatId == PanierArticlesId);
            var quantite = 0;
            if (PanierItem != null)
            {
                if (PanierItem.Quantite > 1)
                {
                    PanierItem.Quantite--;
                    quantite = PanierItem.Quantite;
                }
                else
                {
                    dbContext.PanierArticles.Remove(PanierItem);
                }
            }
            dbContext.SaveChanges();
            return quantite;
        }

        public void SupprimerPanier()
        {
            var panierArticles = dbContext.PanierArticles.Where(s => s.PanierAchatId == PanierArticlesId);
            dbContext.PanierArticles.RemoveRange(panierArticles);
            dbContext.SaveChanges();
        }
    }
}
