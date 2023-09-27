using BoutiqueCafe.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BoutiqueCafe.Controllers
{
    public class HomeController : Controller
    {
        private IProduitRepository produitRepository;

        public HomeController (IProduitRepository produitRepository)
        {
            this.produitRepository = produitRepository;
        }
        public IActionResult Index()
        {
            return View(produitRepository.GetPopulaireProduits());
        }    
    }
}
