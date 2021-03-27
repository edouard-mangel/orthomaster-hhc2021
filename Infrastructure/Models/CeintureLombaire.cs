
namespace Infrastructure.Models
{
    public partial class CeintureLombaire
    {
        public long Id { get; set; }
        public long IdProduit { get; set; }
        public string Reference { get; set; }
        public string Couleur { get; set; }
        public string Taille { get; set; }
        public int? MesureMin { get; set; }
        public int? MesureMax { get; set; }
        public decimal? HauteurDorsale { get; set; }
        public decimal? HauteurVentrale { get; set; }
        public bool? CompatiblePetiteTaille { get; set; }

        public virtual Produit IdProduitNavigation { get; set; }
    }
}
