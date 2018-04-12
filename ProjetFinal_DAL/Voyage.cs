//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetFinal_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Voyage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Voyage()
        {
            this.Commandes = new HashSet<Commande>();
        }
    
        public long IdVoyage { get; set; }
        public string Titre { get; set; }
        public string DescCourte { get; set; }
        public string DescLongue { get; set; }
        public Nullable<double> Prix { get; set; }
        public long IdContinent { get; set; }
        public Nullable<int> NbPlaceDisponible { get; set; }
        public string photo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commande> Commandes { get; set; }
        public virtual Continent Continent { get; set; }
    }
}
