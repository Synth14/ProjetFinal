using System;

public class Region_UIL
{
   
        public long IdRegions { get; set; }
        public Nullable<long> IdPays { get; set; }
        public string Nom { get; set; }

        public virtual Pays_UIL Pay { get; set; }
    
}