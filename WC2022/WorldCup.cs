using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WC2022
{
    internal class WorldCup : GroupTypeCompetition
    {
        string[] participantCountries;
        public WorldCup(string name, int numberOfTeams, int numberOfGroups, string[] _participantCountries) : base(name, numberOfTeams, numberOfGroups)
        {
            participantCountries = _participantCountries;
        }
    }
}
