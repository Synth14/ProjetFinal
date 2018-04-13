using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetFinal_BOL;
using ProjetFinal_UIL.Models;

namespace ProjetFinal_UIL.Controllers
{
    public class CommandesController : Controller
    {
        private Repository_BOL Repo = new Repository_BOL();
        [Authorize(Roles = "Commercial, SuperAdmin")]
        // GET: Commandes
        public ActionResult Index()
        {
            ArrayList listeCommandes = Repo.GetAllCommandes();
            List<Commande_UIL> listeDeCommandes = new List<Commande_UIL>();
            for (int i = 0; i < listeCommandes.Count; i += 7)
            {
                listeDeCommandes.Add(
                    new Commande_UIL
                    {
                        IdCommande = int.Parse(listeCommandes[i].ToString()),
                        IdVoyage = int.Parse(listeCommandes[i + 1].ToString()),
                        NbPlaceDemande = int.Parse(listeCommandes[i + 2].ToString()),
                        Solvabilite = int.Parse(listeCommandes[i + 3].ToString()),
                        TotalCommande = int.Parse(listeCommandes[i + 4].ToString()),
                        EtatCommande = int.Parse(listeCommandes[i + 5].ToString()),
                        IdClient = int.Parse(listeCommandes[i + 6].ToString()),
                        //DateCommande = Convert.ToDateTime(listeCommandes[i+7].ToString()),
                    });
            }
            return View(listeDeCommandes);
        }
    }
}

//    protected override void Dispose(bool disposing)
//    {
//        if (disposing)
//        {
//            db.Dispose();
//        }
//        base.Dispose(disposing);
//    }
//}
//}
