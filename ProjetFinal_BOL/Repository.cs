
using ProjetFinal_DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal_BOL
{
    public class Repository_BOL
    {
        private Repository_DAL Repo = new Repository_DAL(); 
        public ArrayList GetAllContinents()
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
            return listeA;
        }
    }
}
