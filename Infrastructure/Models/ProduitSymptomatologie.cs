using System;
using System.Collections.Generic;

#nullable disable

namespace Infrastructure.Models
{
    public partial class ProduitSymptomatologie
    {
        public long IdProduit { get; set; }
        public long IdSymptomatologie { get; set; }

        public virtual Produit IdProduitNavigation { get; set; }
        public virtual Symptomatologie IdSymptomatologieNavigation { get; set; }
    }
}
