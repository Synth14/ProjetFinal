using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetFinal_UIL.Controllers
{
    public class VoyageController : Controller
    {
        // GET: Voyage
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VoyageDetaille()
        {
            return View();
        }
        
    }
}