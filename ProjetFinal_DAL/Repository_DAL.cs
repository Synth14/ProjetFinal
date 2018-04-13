using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal_DAL
{
    public class Repository_DAL
    {
        private FinalDBContext Context = new FinalDBContext();
        public ArrayList GetAllContinents()
        {
            var liste = Context.Continents.ToList();
            ArrayList listeContinent = new ArrayList();
            for (int i = 0; i < liste.Count; i ++)
            {
                listeContinent.Add(liste[i].Nom);
                listeContinent.Add(liste[i].IdContinent);
            }

            return (listeContinent);
        }

        public ArrayList GetPaysByContinents(long IdC)
        {
            var liste = Context.Continents.Where(x => x.IdContinent == IdC).Select(x => x.Pays);
            
            //ArrayList listePays = new ArrayList();
            //for(int i=0;i<liste.Count; i++)
            //{
            //    //listePays.Add(liste[i].IdContinent);
            //    //listePays.Add(liste[i].Pays);

            //}
            return (ArrayList)(liste);
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

            var liste = Context.Clients.ToList();
            var listeClientFiltree = new ArrayList();
            for (int i = 0; i < liste.Count; i++)
            {
                listeClientFiltree.Add(liste[i].Nom);
                listeClientFiltree.Add(liste[i].Prenom);
                listeClientFiltree.Add(liste[i].Mail);
            }

            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    listeClientFiltree = listeClientFiltree.Where(s => s.Nom.Contains(searchString));
            //}

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

