using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal_BOL
{
    public partial class Commande_BOL
    {
        public long IdCommande { get; set; }
        [DisplayName("Place demandée")]
        public Nullable<int> NbPlaceDemande { get; set; }
        [DisplayName("Total de la commande")]
        public Nullable<double> TotalCommande { get; set; }
        [DisplayName("Solvabilité")]
        public Nullable<int> Solvabilite { get; set; }
        [DisplayName("État de la commande")]
        public Nullable<int> EtatCommande { get; set; }
        public long IdVoyage { get; set; }
        [DisplayName("Date de la commande")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public Nullable<System.DateTime> DateCommande { get; set; }
        public long IdClient { get; set; }

        public virtual Client_BOL Client { get; set; }
        public virtual Voyage Voyage { get; set; }
    }
}
