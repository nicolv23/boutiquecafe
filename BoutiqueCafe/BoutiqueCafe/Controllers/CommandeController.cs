using BoutiqueCafe.Models;
using BoutiqueCafe.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BoutiqueCafe.Controllers
{
    public class CommandeController : Controller
    {
        private ICommandeRepository commandeRepository;
        private IPanierAchatRepository panierAchatRepository;
        public CommandeController(ICommandeRepository commandeRepository, IPanierAchatRepository panierAchatRepository)
        {
            this.commandeRepository = commandeRepository;
            this.panierAchatRepository = panierAchatRepository;
        }

        public IActionResult Paiement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Paiement(Commande commande)
        {
            commandeRepository.EffectuerCommande(commande);
            panierAchatRepository.SupprimerPanier();
            HttpContext.Session.SetInt32("CartCount", 0);
            return RedirectToAction("PaiementComplete");
        }

        public IActionResult PaiementComplete()
        {
            return View();
        }
    }
}
