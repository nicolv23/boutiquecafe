using BoutiqueCafe.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BoutiqueCafe.Controllers
{
    public class PanierAchatController : Controller
    {
        private IPanierAchatRepository panierAchatRepository;
        private IProduitRepository produitRepository;
        public PanierAchatController(IPanierAchatRepository panierAchatRepository, IProduitRepository produitRepository)
        {
            this.panierAchatRepository = panierAchatRepository;
            this.produitRepository = produitRepository;
        }

        public IActionResult Index()
        {
            var articles = panierAchatRepository.GetPanierArticles();
            panierAchatRepository.PanierArticlesRecuperes = articles;
            ViewBag.TotalPanier = panierAchatRepository.GetPanierAchatTotal();
            return View(articles);
        }

        public RedirectToActionResult AjouterAuPanierAchat(int Id)
        {
            var produit = produitRepository.GetAllProduits().FirstOrDefault(p => p.Id == Id);
            if(produit != null)
            {
                panierAchatRepository.AjouterAuPanier(produit);
                int cartCount = panierAchatRepository.GetPanierArticles().Count;
                HttpContext.Session.SetInt32("CartCount", cartCount);
            }
            return RedirectToAction("Index");

        }

        public RedirectToActionResult RetirerDuPanierAchat(int Id)
        {
            var produit = produitRepository.GetAllProduits().FirstOrDefault(p => p.Id == Id);
            if (produit != null)
            {
                panierAchatRepository.RetirerDuPanier(produit);
                int cartCount = panierAchatRepository.GetPanierArticles().Count;
                HttpContext.Session.SetInt32("CartCount", cartCount);
            }
            return RedirectToAction("Index");
        }
    }
}
