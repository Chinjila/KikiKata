using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KikiKata
{
    public class Dinglemouse
    {
        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {
            // Your code here!

            int catYear = 0;

            catYear = humanYears switch
            {
                <= 0 => 0,
                1 => 15,
                2 => 24,
                >= 3 => (humanYears - 2) * 4 + 24
            };
            int dogYear = 0;

            dogYear = humanYears switch
            {
                <= 0 => 0,
                1 => 15,
                2 => 24,
                >= 3 => (humanYears - 2) * 5 + 24
            };


            return new int[] { humanYears, catYear, dogYear };
        }
    }
}
