using ProjetFinal_BOL;
using ProjetFinal_UIL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ProjetFinal_UIL.Controllers
{
    public class HomeController : Controller
    {
        private Repository_BOL Repo = new Repository_BOL();//Doit s'adresser a la couche métier
        public ArrayList GetAllContinents()
        {
            return Repo.GetAllContinents();
        }
        public ArrayList GetAllPays([FromUri] long IdC)
        {
            return Repo.GetAllPays(IdC);
        }

        public ArrayList GetAllRegions([FromUri] long IdC, [FromUri] long IdP)
        {
            return Repo.GetAllRegions(IdC, IdP);
        }

        //voyages a 9 parametres :idC, idP,idR,idV, nomVoyage, descriptionCourte, descriptionDetaillee, prix, nbPlaceDispo
        public ArrayList PostVoyageByContinent([FromUri] long IdC)
        {
            return Repo.PostVoyageByContinent(IdC);
        }

        public ArrayList PostVoyagesByPays([FromUri] long IdC, [FromUri] long IdP)
        {
            return Repo.PostVoyagesByPays(IdC, IdP);
        }

        public ArrayList PostVoyagesByRegions([FromUri] long IdC, [FromUri] long IdP, [FromUri] long IdR)
        {
            return Repo.PostVoyagesByRegions(IdC, IdP, IdR);
        }
        public ActionResult Index()
        {
            ArrayList listContinent = Repo.GetAllContinents();
            List<Continent_UIL> ListDeContinents = new List<Continent_UIL>();

            for (int i = 0; i < listContinent.Count; i+=2)
            {
                ListDeContinents.Add(
                    new Continent_UIL
                    {
                         Nom = listContinent[i].ToString(),
                         IdContinent = int.Parse(listContinent[i+1].ToString())
                    });
            }
            //ArrayList listPays = Repo.GetPaysByContinents(1);
            //List<Pays_UIL> ListDePays = new List<Pays_UIL>();
            //for (int i = 0; i < listPays.Count; i += 2)
            //{
            //    ListDePays.Add(
            //        new Pays_UIL
            //        {
            //            Nom = listPays[i].ToString(),
            //            IdPays = int.Parse(listPays[i + 1].ToString())
            //        });
            //}
            return View(ListDeContinents);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


      
    }
}