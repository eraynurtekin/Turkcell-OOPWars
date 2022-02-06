using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilizationOOP
{
    public class Player
    {
        public Player()
        {

        }
        
        public Player(Countries countryName)
        {
            CountryName = countryName;
        }

        public Countries CountryName;

        public Soldiers Soldiers;

    }
}
