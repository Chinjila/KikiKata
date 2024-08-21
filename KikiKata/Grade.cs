using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KikiKata
{
    public class Grade
    {
        public static char Grader(double score)
        => score switch
        {
            (> 1.0) or (< 0.6) => 'F',
            >= 0.9 => 'A',
            >= 0.8 => 'B',
            >= 0.7 => 'C',
            >= 0.6 => 'D'
        };
    }
}
