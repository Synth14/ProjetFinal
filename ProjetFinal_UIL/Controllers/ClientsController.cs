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
//using ProjetFinal_DAL;
using ProjetFinal_UIL.Models;

namespace ProjetFinal_UIL.Controllers
{
    public class ClientsController : Controller
    {
        private Repository_BOL Repo = new Repository_BOL();
        
        //[Authorize]
        // GET: Clients
        //public ActionResult Index()
        //{
        //    return View(db.Clients.ToList());
        //}

        //public ActionResult Index(string searchString)
        //{
        //    var listeVoyageFiltre = from v in Repo.Voyages
        //                              select v;
        //    var listeCommandeFiltre = from c in Repo.Commandes
        //                              select c;
        //    var listeClientFiltree = from m in Repo.Clients
        //                       select m;

        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        listeClientFiltree = listeClientFiltree.Where(s => s.Nom.Contains(searchString));
        //    }

        //    return View(listeClientFiltree.ToList());
        //}

        //[Authorize]
        //public ActionResult Index()
        //{
        //    ArrayList listeClients = Repo.GetAllClients();
        //    List<Client_UIL> listeDeClients = new List<Client_UIL>();
        //    for (int i = 0; i < listeClients.Count; i += 3)
        //    {
        //        listeDeClients.Add(
        //            new Client_UIL
        //            {
        //                Nom = listeClients[i].ToString(),
        //                Prenom = listeClients[i+1].ToString(),
        //                Mail = listeClients[i+2].ToString(),
        //                //IdContinent = int.Parse(listeDeClients[i + 1].ToString())
        //            });
        //    }
        //    return View(listeDeClients);
        //}

        [Authorize]
        public ActionResult Index(string searchString)
        {
            ArrayList listeClients = Repo.GetClientById(searchString);
            List<Client_UIL> listeDeClients = new List<Client_UIL>();
            for (int i = 0; i < listeClients.Count; i += 3)
            {
                listeDeClients.Add(
                    new Client_UIL
                    {
                        Nom = listeClients[i].ToString(),
                        Prenom = listeClients[i + 1].ToString(),
                        Mail = listeClients[i + 2].ToString(),
                        //IdContinent = int.Parse(listeDeClients[i + 1].ToString())
                    });
            }
            return View(listeDeClients);
        }





        //[Authorize]
        //// GET: Clients/Details/5
        //public ActionResult Details(long? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Client client = db.Clients.Find(id);
        //    if (client == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(client);
        //}




        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
