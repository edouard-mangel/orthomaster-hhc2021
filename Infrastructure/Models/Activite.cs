using System;
using System.Collections.Generic;

#nullable disable

namespace Infrastructure.Models
{
    public partial class Activite
    {
        public Activite()
        {
            ProduitActivites = new HashSet<ProduitActivite>();
        }

        public long Id { get; set; }
        public string Label { get; set; }

        public virtual ICollection<ProduitActivite> ProduitActivites { get; set; }
    }
}
