using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KikiKata
{
    public class Hero
    {
        public string Name = "Hero";
        public string Position = "00";
        public float Health = 100;
        public float Damage = 5;
        public int Experience = 0;
        public Hero(string _name)
        {
                this.Name = _name;
        }
        public Hero():this("Hero")
        {
                
        }
    }
}
