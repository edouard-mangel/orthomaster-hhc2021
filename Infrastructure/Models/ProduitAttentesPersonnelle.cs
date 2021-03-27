using System;
using System.Collections.Generic;

#nullable disable

namespace Infrastructure.Models
{
    public partial class ProduitAttentesPersonnelle
    {
        public long IdProduit { get; set; }
        public long IdAttentesPersonnelles { get; set; }

        public virtual AttentesPersonnelle IdAttentesPersonnellesNavigation { get; set; }
        public virtual Produit IdProduitNavigation { get; set; }
    }
}
