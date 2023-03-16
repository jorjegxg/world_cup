using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WC2022
{
    class GroupTypeCompetition : Competition
    {
        int numberOfGroups;        
        public GroupTypeCompetition(string _name, int _numberOfTeams, int numberOfGroups) : base(_name, _numberOfTeams)
        {
            this.numberOfGroups = numberOfGroups;
        }
    }
    
}
