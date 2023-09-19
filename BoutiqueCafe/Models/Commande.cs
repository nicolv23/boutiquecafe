namespace BoutiqueCafe.Models
{
    public class Commande
    {
        public int Id { get; set; }
        public string? Prenom { get; set; }
        public string? Nom { get; set; }
        public string? Email { get; set; }
        public string? Numero { get; set; }
        public string? Adresse { get; set; }
        public decimal CommandeTotal { get; set; }
        public DateTime CommandeEffectue { get; set; }

        public List<CommandeDetail>? CommandeDetails {  get; set; } 
    }
}
