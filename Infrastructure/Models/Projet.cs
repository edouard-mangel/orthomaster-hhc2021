using System;
using System.Collections.Generic;

#nullable disable

namespace Infrastructure.Models
{
    public partial class Projet
    {
        public Projet()
        {
            ProduitProjets = new HashSet<ProduitProjet>();
        }

        public long Id { get; set; }
        public string Label { get; set; }

        public virtual ICollection<ProduitProjet> ProduitProjets { get; set; }
    }
}
