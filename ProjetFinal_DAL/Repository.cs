﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal_DAL
{
    public class Repository
    {
        private FinalDBContext context = new FinalDBContext();
        public ArrayList GetAllContinents()
        {
            return new ArrayList { };
        }

        public ArrayList GetPaysByContinents(long IdC)
        {
            return new ArrayList { };
        }

        public ArrayList GetRegionsByPays(long IdC, long IdP)
        {
            return new ArrayList { };
        }
        public ArrayList PostVoyagesByContinent(long idC)
        {
            return new ArrayList { };
        }

        public ArrayList PostVoyagesByPays(long idC, long idP)
        {
            return new ArrayList { };
        }

        public ArrayList PostVoyagesByRegions(long idC, long idP, long idR){
            return new ArrayList { };
        }
    }
}

