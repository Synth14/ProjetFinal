using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal_BOL
{
    public partial class Pays_BOL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pays_BOL()
        {
            this.Regions = new HashSet<Region_BOL>();
        }

        public long IdPays { get; set; }
        public string Nom { get; set; }
        public long IdContinent { get; set; }

        public virtual Continent_BOL Continent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Region_BOL> Regions { get; set; }
    }
}
