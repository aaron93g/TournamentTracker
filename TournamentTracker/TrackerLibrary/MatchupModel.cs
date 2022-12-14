using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents list of all teams participating in tournament
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// which of the two Entries will be set as the winner
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// What will the round number be set as for the matchup of the two entries
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
