
using Microsoft.AspNet.Identity.Owin;
using ProjetFinal_BOL;
using ProjetFinal_UIL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Security;

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

            for (int i = 0; i < listContinent.Count; i += 2)
            {
                ListDeContinents.Add(
                    new Continent_UIL
                    {
                        Nom = listContinent[i].ToString(),
                        IdContinent = int.Parse(listContinent[i + 1].ToString())
                    });
            }
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
        public ActionResult Attribuer()
        {
            RegisterViewModel model = new RegisterViewModel { Email = "superadmin@exemple.fr", Password = "P@ssw0rd"};
            var user = new ApplicationUser { UserName = model.Email, Email = model.Email};
            var UserManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var result =  UserManager.CreateAsync(user,model.Password );

            RegisterViewModel model2 = new RegisterViewModel { Email = "commercial@exemple.fr", Password = "P@ssw0rd" };
            var use2r = new ApplicationUser { UserName = model.Email, Email = model.Email };
            var UserManager2 = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();

            var result2 = UserManager.CreateAsync(user, model.Password);
            RegisterViewModel model3 = new RegisterViewModel { Email = "mailing@exemple.fr", Password = "P@ssw0rd" };
            var user3 = new ApplicationUser { UserName = model.Email, Email = model.Email };
            var UserManager3 = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();

            var result= UserManager.CreateAsync(user, model.Password);

            if (!Roles.RoleExists("SuperAdmin")) Roles.CreateRole("SuperAdmin");
            if (!Roles.RoleExists("Commercial")) Roles.CreateRole("Commercial");
            if (!Roles.RoleExists("Mailing")) Roles.CreateRole("Mailing");

            
           
          

            if (!Roles.IsUserInRole(model.Email, "SuperAdmin"))
                Roles.AddUserToRole(model.Email, "SuperAdmin");
                                   
            if (!Roles.IsUserInRole(model2.Email, "Commercial"))
                Roles.AddUserToRole(model2.Email, "Commercial");
                                 
            if (!Roles.IsUserInRole(model3.Email, "Mailing"))
                Roles.AddUserToRole(model3.Email, "Mailing");
            ViewBag.Message = "Iasyasdnn@live.fr est superadmin";
            return View();
        }



    }
}