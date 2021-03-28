using System;
using System.Collections.Generic;

#nullable disable

namespace Infrastructure.Models
{
    public partial class Produit
    {
        public Produit()
        {
            ProduitActivites = new HashSet<ProduitActivite>();
            ProduitAttentesPersonnelles = new HashSet<ProduitAttentesPersonnelle>();
            ProduitMorphologies = new HashSet<ProduitMorphologie>();
            ProduitProjets = new HashSet<ProduitProjet>();
            ProduitSymptomatologies = new HashSet<ProduitSymptomatologie>();
        }

        public long Id { get; set; }
        public string Nom { get; set; }
        public string Fabricant { get; set; }

        public virtual ICollection<ProduitActivite> ProduitActivites { get; set; }
        public virtual ICollection<ProduitAttentesPersonnelle> ProduitAttentesPersonnelles { get; set; }
        public virtual ICollection<ProduitMorphologie> ProduitMorphologies { get; set; }
        public virtual ICollection<ProduitProjet> ProduitProjets { get; set; }
        public virtual ICollection<ProduitSymptomatologie> ProduitSymptomatologies { get; set; }
    }
}
