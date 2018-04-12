using ProjetFinal_UIL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;

public partial class Voyage_UIL
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Voyage_UIL()
    {
        this.Commandes = new HashSet<Commande_UIL>();
    }

    public long IdVoyage { get; set; }
    [DisplayName("Titre du voyage")]
    public string Titre { get; set; }
    public string DescCourte { get; set; }
    public string DescLongue { get; set; }
    public Nullable<double> Prix { get; set; }
    public long IdContinent { get; set; }
    [DisplayName("Place disponible")]
    public Nullable<int> NbPlaceDisponible { get; set; }
    public string photo { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Commande_UIL> Commandes { get; set; }
    public virtual Continent_UIL Continent { get; set; }
}