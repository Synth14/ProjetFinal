﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal_DAL
{
    public class Repository
    {
        private FinalDBContext context = new FinalDBContext();

        public IEnumerable<Continent> GetContinent()
        {
            return context.Continents;
        }
    }
}
