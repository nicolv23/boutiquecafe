using BoutiqueCafe.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BoutiqueCafe.Controllers
{
    public class ProduitController : Controller
    {
        private IProduitRepository produitRepository;
        public ProduitController(IProduitRepository produitRepository)
        {
            this.produitRepository = produitRepository;
        }

        public IActionResult Boutique()
        {
            return View(produitRepository.GetAllProduits());
        }

        public IActionResult Detail(int id)
        {
            var produit = produitRepository.GetDetailProduit(id);
            if(produit == null)
            {
                return NotFound();
            }
            return View(produit);
        }
       
    }
}
