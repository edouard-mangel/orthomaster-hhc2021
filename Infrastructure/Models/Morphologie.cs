using System;
using System.Collections.Generic;

#nullable disable

namespace Infrastructure.Models
{
    public partial class Morphologie
    {
        public Morphologie()
        {
            ProduitMorphologies = new HashSet<ProduitMorphologie>();
        }

        public long Id { get; set; }
        public string Label { get; set; }

        public virtual ICollection<ProduitMorphologie> ProduitMorphologies { get; set; }
    }
}
