using System;
using System.Collections.Generic;

#nullable disable

namespace Infrastructure.Models
{
    public partial class ProduitActivite
    {
        public long IdProduit { get; set; }
        public long IdActivite { get; set; }

        public virtual Activite IdActiviteNavigation { get; set; }
        public virtual Produit IdProduitNavigation { get; set; }
    }
}
