namespace BoutiqueCafe.Models
{
    public class Produit
    {
        public int Id { get; set;}
        public string? Nom { get; set;}
        public string? Description { get; set;}
        public string? ImageUrl { get; set;}
        public decimal Prix { get; set;}
        public bool EstPopulaire { get; set;}
    }
}
