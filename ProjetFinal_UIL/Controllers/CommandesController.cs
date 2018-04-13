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
                        IdVoyage = int.Parse(listeCommandes[i+1].ToString()),
                        NbPlaceDemande = int.Parse(listeCommandes[i+2].ToString()),
                        Solvabilite = int.Parse(listeCommandes[i+3].ToString()),
                        TotalCommande = int.Parse(listeCommandes[i+4].ToString()),
                        EtatCommande = int.Parse(listeCommandes[i+5].ToString()),
                        IdClient = int.Parse(listeCommandes[i+6].ToString()),
                        //DateCommande = Convert.ToDateTime(listeCommandes[i+7].ToString()),
                    });
            }
            return View(listeDeCommandes);
        }
    }
}
        //[Authorize]
        // GET: Commandes/Edit/5
    //    public ActionResult Edit(long? id)
    //    {
    //        if (id == null)
    //        {
    //            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    //        }
    //        Commande_UIL commande = db.Commandes.Find(id);
    //        if (commande == null)
    //        {
    //            return HttpNotFound();
    //        }
    //        ViewBag.IdClient = new SelectList(db.Clients, "IdClient", "Nom", commande.IdClient);
    //        ViewBag.IdVoyage = new SelectList(db.Voyages, "IdVoyage", "Titre", commande.IdVoyage);
    //        return View(commande);
    //    }

    //    // POST: Commandes/Edit/5
    //    // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
    //    // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Edit([Bind(Include = "IdCommande,NbPlaceDemande,TotalCommande,Solvabilite,EtatCommande,IdVoyage,DateCommande,IdClient, NbPlaceDisponible")] Commande commande)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            db.Entry(commande).State = EntityState.Modified;
    //            db.SaveChanges();
    //            return RedirectToAction("Index");
    //        }
    //        ViewBag.IdClient = new SelectList(db.Clients, "IdClient", "Nom", commande.IdClient);
    //        ViewBag.IdVoyage = new SelectList(db.Voyages, "IdVoyage", "Titre", commande.IdVoyage);
    //        return View(commande);
    //    }

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
