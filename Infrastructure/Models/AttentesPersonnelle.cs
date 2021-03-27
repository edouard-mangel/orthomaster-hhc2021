using System;
using System.Collections.Generic;

#nullable disable

namespace Infrastructure.Models
{
    public partial class AttentesPersonnelle
    {
        public AttentesPersonnelle()
        {
            ProduitAttentesPersonnelles = new HashSet<ProduitAttentesPersonnelle>();
        }

        public long Id { get; set; }
        public string Label { get; set; }

        public virtual ICollection<ProduitAttentesPersonnelle> ProduitAttentesPersonnelles { get; set; }
    }
}
