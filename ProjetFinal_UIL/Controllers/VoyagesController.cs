
using ProjetFinal_DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetFinal_UIL.Controllers
{
    public class CommandeController : ApiController
    {
        private Repository Repo = new Repository();
        public IEnumerable<Continent> GetAllContinents()
        {
            ArrayList listeA = Repo.GetAllContinents();
            List<Continent> listeC = new List<Continent>();
            for (int i = 0; i < listeA.Count; i += 2)
            {
                listeC.Add(
                    new Continent
                    {
                        IdContinent = int.Parse(listeA[i].ToString()),
                        Nom = listeA[i + 1].ToString()
                    });
            }
            return listeC;
        }

        public IEnumerable<Pay> GetAllPays([FromUri] long IdC)
        {
            ArrayList listeB = Repo.GetPaysByContinents(IdC);
            List<Pay> listeP = new List<Pay>();
            for (int i = 0; i < listeB.Count; i += 3)
            {
                listeP.Add(
                    new Pay
                    {
                        IdContinent = int.Parse(listeB[i].ToString()),
                        IdPays = int.Parse(listeB[i + 1].ToString()),
                        Nom = listeB[i + 2].ToString()
                    });
            }
            return listeP;
        }

        public IEnumerable<Region> GetAllRegions([FromUri] long IdC, [FromUri] long IdP)
        {
            ArrayList listeC = Repo.GetRegionsByPays(IdC, IdP);
            List<Region> listeR = new List<Region>();
            for (int i = 0; i < listeC.Count; i += 4)
            {
                listeR.Add(
                    new Region
                    {
                        IdRegions = int.Parse(listeC[i].ToString()),
                        IdPays = int.Parse(listeC[i + 1].ToString()),
                        Nom = listeC[i + 3].ToString()
                    });
            }
            return listeR;
        }

        //voyages a 9 parametres :idC, idP,idR,idV, nomVoyage, descriptionCourte, descriptionDetaillee, prix, nbPlaceDispo
        public IEnumerable<Voyage> PostVoyageByContinent([FromUri] long IdC)
        {
            ArrayList listeD = Repo.PostVoyagesByContinent(IdC);
            List<Voyage> listeV = new List<Voyage>();
            for (int i = 0; i < listeD.Count; i += 9)
            {
                listeV.Add(
                    new Voyage
                    {
                        IdContinent = int.Parse(listeD[i].ToString()),
                        IdVoyage = int.Parse(listeD[i + 3].ToString()),
                        Titre = listeD[i + 4].ToString(),
                        DescCourte = listeD[i + 5].ToString(),
                        DescLongue = listeD[i + 6].ToString(),
                        Prix = float.Parse(listeD[i + 7].ToString()),
                        NbPlaceDisponible = int.Parse(listeD[i + 8].ToString())
                    });
            }
            return listeV;
        }

        public IEnumerable<Voyage> PostVoyagesByPays([FromUri] long IdC, [FromUri] long IdP)
        {
            ArrayList listeE = Repo.PostVoyagesByPays(IdC, IdP);
            List<Voyage> listeV = new List<Voyage>();
            for (int i = 0; i < listeE.Count; i += 9)
            {
                listeV.Add(
                    new Voyage
                    {
                        IdContinent = int.Parse(listeE[i].ToString()),
                        IdVoyage = int.Parse(listeE[i + 3].ToString()),
                        Titre = listeE[i + 4].ToString(),
                        DescCourte = listeE[i + 5].ToString(),
                        DescLongue = listeE[i + 6].ToString(),
                        Prix = float.Parse(listeE[i + 7].ToString()),
                        NbPlaceDisponible = int.Parse(listeE[i + 8].ToString())
                    });
            }
            return listeV;
        }

        public IEnumerable<Voyage> PostVoyagesByRegions([FromUri] long IdC, [FromUri] long IdP, [FromUri] long IdR)
        {
            ArrayList listeF = Repo.PostVoyagesByRegions(IdC, IdP, IdR);
            List<Voyage> listeV = new List<Voyage>();
            if (listeF != null)
            {
                for (int i = 0; i < listeF.Count; i += 9)
                {
                    listeV.Add(
                        new Voyage
                        {
                            IdContinent = int.Parse(listeV[i].ToString()),
                            IdVoyage = int.Parse(listeV[i + 3].ToString()),
                            Titre = listeV[i + 4].ToString(),
                            DescCourte = listeV[i + 5].ToString(),
                            DescLongue = listeV[i + 6].ToString(),
                            Prix = float.Parse(listeV[i + 7].ToString()),
                            NbPlaceDisponible = int.Parse(listeV[i + 8].ToString())
                        });
                }
                return listeV;
            }
            else { return listeV; }


        }


    }

}
