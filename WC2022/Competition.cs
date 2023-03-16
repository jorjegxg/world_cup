using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WC2022
{
    class Competition
    {
        public string name;
        public int numberOfTeams;

        public Competition(string _name , int _numberOfTeams)
        {
            name = _name;
            numberOfTeams = _numberOfTeams;
        }
    }
}
