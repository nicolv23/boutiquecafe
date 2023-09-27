using BoutiqueCafe.Data;
using BoutiqueCafe.Models.Interfaces;

namespace BoutiqueCafe.Models.Services
{
    public class CommandeRepository : ICommandeRepository
    {
        private BoutiqueCafeDbContext dbContext;
        private IPanierAchatRepository panierAchatRepository;
        public CommandeRepository(BoutiqueCafeDbContext dbContext, IPanierAchatRepository panierAchatRepository)
        {
            this.dbContext = dbContext;
            this.panierAchatRepository = panierAchatRepository;
        }

        public void EffectuerCommande(Commande commande)
        {
            var panierAchats = panierAchatRepository.GetPanierArticles();
            commande.CommandeDetails = new List<CommandeDetail>();
            foreach (var item in panierAchats)
            {
                var produitId = item.Produit.Id;
                var commandeDetail = new CommandeDetail
                {
                    Quantite = item.Quantite,
                    ProduitId = produitId,
                    Prix = item.Produit.Prix
                };
                commande.CommandeDetails.Add(commandeDetail);
            }
            commande.CommandeEffectue = DateTime.Now;
            commande.CommandeTotal = panierAchatRepository.GetPanierAchatTotal();
            dbContext.Commandes.Add(commande);
            dbContext.SaveChanges();
        }
    }
}
