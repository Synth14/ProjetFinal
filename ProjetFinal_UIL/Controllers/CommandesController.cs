using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetFinal_DAL;

namespace ProjetFinal_UIL.Controllers
{
    public class CommandesController : Controller
    {
        private FinalDBContext db = new FinalDBContext();

        // GET: Commandes
        public ActionResult Index()
        {
            var commandes = db.Commandes.Include(c => c.Client).Include(c => c.Voyage);
            return View(commandes.ToList());
        }

        // GET: Commandes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Commande commande = db.Commandes.Find(id);
            if (commande == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdClient = new SelectList(db.Clients, "IdClient", "Nom", commande.IdClient);
            ViewBag.IdVoyage = new SelectList(db.Voyages, "IdVoyage", "Titre", commande.IdVoyage);
            return View(commande);
        }

        // POST: Commandes/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCommande,NbPlaceDemande,TotalCommande,Solvabilite,EtatCommande,IdVoyage,DateCommande,IdClient, NbPlaceDisponible")] Commande commande)
        {
            if (ModelState.IsValid)
            {
                db.Entry(commande).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdClient = new SelectList(db.Clients, "IdClient", "Nom", commande.IdClient);
            ViewBag.IdVoyage = new SelectList(db.Voyages, "IdVoyage", "Titre", commande.IdVoyage);
            return View(commande);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
