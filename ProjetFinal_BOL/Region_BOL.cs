using System;

namespace ProjetFinal_BOL
{
    public partial class Region_BOL
    {
        public long IdRegions { get; set; }
        public Nullable<long> IdPays { get; set; }
        public string Nom { get; set; }

        public virtual Pays_BOL Pay { get; set; }
    }
}