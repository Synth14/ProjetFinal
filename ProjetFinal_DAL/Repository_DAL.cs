using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace ProjetFinal_DAL
{
    public class Repository_DAL
    {
        private FinalDBContext Context = new FinalDBContext();
        public ArrayList GetAllContinents()
        {
            var liste = Context.Continents.ToList();
            ArrayList listeContinent = new ArrayList();
            for (int i = 0; i < liste.Count; i++)
            {
                listeContinent.Add(liste[i].Nom);
                listeContinent.Add(liste[i].IdContinent);
            }

            return (listeContinent);
        }
        public ArrayList GetAllVoyages()
        {
            var liste = Context.Voyages.ToList();
            ArrayList listeVoyages = new ArrayList();
            for (int i = 0; i < liste.Count; i++)
            {
                listeVoyages.Add(liste[i].Titre);
                listeVoyages.Add(liste[i].DescCourte);
                listeVoyages.Add(liste[i].DescLongue);
                listeVoyages.Add(liste[i].Prix);
                listeVoyages.Add(liste[i].photo);
            }

            return (listeVoyages);
        }

        public ArrayList GetPaysByContinents(long IdC)
        {
            ArrayList listePaysByContinentById = new ArrayList();
            List<Pay> liste = null;
            //List<Pay> liste = Context.Continents.Where(x => x.IdContinent == IdC).Select(x => x.Nom).ToList();

            for (int i = 0; i < liste.Count; i++)
            {
                listePaysByContinentById.Add(liste[i].IdContinent);
                listePaysByContinentById.Add(liste[i].Nom);

            }
            return listePaysByContinentById;
        }

        public ArrayList GetRegionsByPays(long IdC, long IdP)
        {
            return new ArrayList { };
        }
        public ArrayList PostVoyagesByContinent(long idC)
        {
            return new ArrayList { };
        }

        public ArrayList GetAllCommande()
        {
            var liste = Context.Commandes.ToList();
            ArrayList listeCommande = new ArrayList();
            for (int i = 0; i < liste.Count; i++)
            {
                listeCommande.Add(liste[i].IdCommande);
                listeCommande.Add(liste[i].IdVoyage);
                listeCommande.Add(liste[i].NbPlaceDemande);
                listeCommande.Add(liste[i].Solvabilite);
                listeCommande.Add(liste[i].TotalCommande);
                listeCommande.Add(liste[i].EtatCommande);
                listeCommande.Add(liste[i].IdClient);
                //listeCommande.Add(liste[i].DateCommande);
            }

            return (listeCommande);
        }

        public ArrayList GetClientsById(string searchString)
        {
            var listeClientFiltree = new ArrayList();
            List<Client> liste = null;

            if (String.IsNullOrEmpty(searchString))
            {
                liste = Context.Clients.ToList();
            }

            else
            {
                liste = Context.Clients.Where(s => s.Nom.Contains(searchString)).ToList();
            }
            
            for (int i = 0; i < liste.Count; i++)
            {
                listeClientFiltree.Add(liste[i].Nom);
                listeClientFiltree.Add(liste[i].Prenom);
                listeClientFiltree.Add(liste[i].Mail);
            }
            
            return (listeClientFiltree);
        }

        public ArrayList PostVoyagesByPays(long idC, long idP)
        {
            return new ArrayList { };
        }

        public ArrayList PostVoyagesByRegions(long idC, long idP, long idR)
        {
            return new ArrayList { };
        }

        public ArrayList GetCommandes()
        {
            var liste = Context.Commandes.ToList();
            // ...
            ArrayList listeAl = new ArrayList();
            //...
            return listeAl;
        }

        //public ArrayList GetClients()
        //{
        //    var liste = Context.Clients.ToList();
        //    // ...
        //    ArrayList listeAlClient = new ArrayList();
        //    //...
        //    return listeAlClient;
        //}

        public ArrayList GetAllClient()
        {
            var liste = Context.Clients.ToList();
            ArrayList listeClient = new ArrayList();
            for (int i = 0; i < liste.Count; i++)
            {
                listeClient.Add(liste[i].Nom);
                listeClient.Add(liste[i].Prenom);
                listeClient.Add(liste[i].Mail);
            }

            return (listeClient);
        }


    }
}

