using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// list of persons on 1 team
        /// </summary>
        public List<PersonsModel> TeamMembers { get; set; } = new List<PersonsModel>();

        public string TeamNames { get; set; }
    }
}
