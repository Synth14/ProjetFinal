using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetFinal_UIL.Models
{
    public class Client_UIL
    {
        public long IdClient { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }
    }
}