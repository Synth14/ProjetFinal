
using ProjetFinal_DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ProjetFinal_BOL
{
    public class Repository_BOL
    {
        private Repository_DAL Repo = new Repository_DAL();
        public ArrayList GetAllContinents()
        {
            ArrayList listeA = Repo.GetAllContinents();
            return listeA;
        }

        public ArrayList GetAllCommandes()
        {
            ArrayList listeC = Repo.GetAllCommande();
            return listeC;
        }
        public ArrayList GetAllPays([FromUri] long IdC)
        {
            ArrayList listeB = Repo.GetPaysByContinents(IdC);
            List<Pays_BOL> listeP = new List<Pays_BOL>();
            for (int i = 0; i < listeB.Count; i += 3)
            {
                listeP.Add(
                    new Pays_BOL
                    {
                        IdContinent = int.Parse(listeB[i].ToString()),
                        IdPays = int.Parse(listeB[i + 1].ToString()),
                        Nom = listeB[i + 2].ToString()
                    });
            }
            return listeB;
        }

        public ArrayList GetAllClients()
        {
            ArrayList listeC = Repo.GetAllClient();
            return listeC;
        }

        public ArrayList GetClientById(string searchString)
        {
            ArrayList listeC = Repo.GetClientsById(searchString);
            return listeC;
        }

        //public ArrayList GetClients()
        //{
        //    ArrayList alisteClient = Repo.GetClients();
        //    // ..
        //    return alisteClient;
        //}

        public ArrayList GetAllRegions([FromUri] long IdC, [FromUri] long IdP)
        {
            ArrayList listeC = Repo.GetRegionsByPays(IdC, IdP);
            List<Region_BOL> listeR = new List<Region_BOL>();
            for (int i = 0; i < listeC.Count; i += 4)
            {
                listeR.Add(
                    new Region_BOL
                    {
                        IdRegions = int.Parse(listeC[i].ToString()),
                        IdPays = int.Parse(listeC[i + 1].ToString()),
                        Nom = listeC[i + 3].ToString()
                    });
            }
            return listeC;
        }

        //voyages a 9 parametres :idC, idP,idR,idV, nomVoyage, descriptionCourte, descriptionDetaillee, prix, nbPlaceDispo
        public ArrayList PostVoyageByContinent([FromUri] long IdC)
        {
            ArrayList listeD = Repo.PostVoyagesByContinent(IdC);
            List<Voyage_BOL> listeV = new List<Voyage_BOL>();
            for (int i = 0; i < listeD.Count; i += 9)
            {
                listeV.Add(
                    new Voyage_BOL
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
            return listeD;
        }

        public ArrayList PostVoyagesByPays([FromUri] long IdC, [FromUri] long IdP)
        {
            ArrayList listeE = Repo.PostVoyagesByPays(IdC, IdP);
            List<Voyage_BOL> listeV = new List<Voyage_BOL>();
            for (int i = 0; i < listeE.Count; i += 9)
            {
                listeV.Add(
                    new Voyage_BOL
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
            return listeE;
        }

        public ArrayList PostVoyagesByRegions([FromUri] long IdC, [FromUri] long IdP, [FromUri] long IdR)
        {
            ArrayList listeF = Repo.PostVoyagesByRegions(IdC, IdP, IdR);
            List<Voyage_BOL> listeV = new List<Voyage_BOL>();
            if (listeF != null)
            {
                for (int i = 0; i < listeF.Count; i += 9)
                {
                    listeV.Add(
                        new Voyage_BOL
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
                return listeF;
            }
            else { return listeF; }


        }


    }
}

