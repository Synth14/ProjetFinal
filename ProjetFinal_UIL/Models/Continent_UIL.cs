using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetFinal_UIL.Models
{
    public partial class Continent_UIL
    {
         public Continent_UIL()
        {
            this.Pays = new HashSet<Pays_UIL>();
            this.Voyages = new HashSet<Voyage_UIL>();
        }

        public long IdContinent { get; set; }
        public string Nom { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pays_UIL> Pays { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Voyage_UIL> Voyages { get; set; }
    }
}
