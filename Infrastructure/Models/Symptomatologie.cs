using System;
using System.Collections.Generic;

#nullable disable

namespace Infrastructure.Models
{
    public partial class Symptomatologie
    {
        public Symptomatologie()
        {
            ProduitSymptomatologies = new HashSet<ProduitSymptomatologie>();
        }

        public long Id { get; set; }
        public string Label { get; set; }

        public virtual ICollection<ProduitSymptomatologie> ProduitSymptomatologies { get; set; }
    }
}
