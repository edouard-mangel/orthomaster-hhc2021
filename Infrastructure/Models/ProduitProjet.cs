using System;
using System.Collections.Generic;

#nullable disable

namespace Infrastructure.Models
{
    public partial class ProduitProjet
    {
        public long IdProjet { get; set; }
        public long IdProduit { get; set; }

        public virtual Produit IdProduitNavigation { get; set; }
        public virtual Projet IdProjetNavigation { get; set; }
    }
}
