using ProjetFinal_UIL.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public partial class Commande_UIL
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
    //[DisplayName("Date de la commande")]
    //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
    //public Nullable<System.DateTime> DateCommande { get; set; }
    public long IdClient { get; set; }

    public virtual Client_UIL Client { get; set; }
    public virtual Voyage_UIL Voyage { get; set; }
}