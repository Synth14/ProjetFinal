using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Solvabilité
{
   // [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class ServiceSolvabilite : IServiceSolvabilite
    {
        private int rand = new Random().Next(1);
        public int solvabilite()
        {
           
            return rand;
        }
    }
}
