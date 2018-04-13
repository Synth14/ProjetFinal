using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetFinal_BOL.ServiceReferenceSolvabilite;

namespace ProjetFinal_BOL
{
    class Solvabilite
    {
        Service1Client Solva = new Service1Client();
        
        public string TestSolva()
        {
            int value = Solva.Solvabilite();
            switch (value)
            {
                case 1: return "<script>document.getElementById('btnSolva').style.backgroundColor = 'green';</script>"; //Client solvable
                default: return "<script>document.getElementById('btnSolva').style.backgroundColor = 'red';</script>";//Client non solvable
            }
           

        }

    }
}
