using ProjetFinal_UIL.Models;
using System.Collections.Generic;

public partial class Pays_UIL
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Pays_UIL()
    {
        this.Regions = new HashSet<Region_UIL>();
    }

    public long IdPays { get; set; }
    public string Nom { get; set; }
    public long IdContinent { get; set; }

    public virtual Continent_UIL Continent { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Region_UIL> Regions { get; set; }
}