using System;
using System.Collections.Generic;

#nullable disable

namespace Infrastructure.Models
{
    public partial class ProduitMorphologie
    {
        public long IdProduit { get; set; }
        public long IdMorphologie { get; set; }

        public virtual Morphologie IdMorphologieNavigation { get; set; }
        public virtual Produit IdProduitNavigation { get; set; }
    }
}
