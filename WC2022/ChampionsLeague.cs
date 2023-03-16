using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WC2022
{
    internal class ChampionsLeague : GroupTypeCompetition
    {
        string[] participantTeams;
        public ChampionsLeague(string name, int numberOfTeams, int numberOfGroups, string[] _participantTeams) : base(name, numberOfTeams, numberOfGroups)
        {
            participantTeams = _participantTeams;
        }
    }
}
