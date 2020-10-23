using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class CBF
    {
        
        private List<Team> _teams { get; set; }
        public IReadOnlyCollection<Team> Teams => _teams;

        public CBF()
        {
            _teams = new List<Team>();

        }
        public bool RegisterOfTeams(List<Team> teams, string password)
        {
            if (password == "CBF")
            {
                if (teams == null)
                {
                    return true;
                }
                _teams = teams;

                return true;
            }
            
            if (teams.Count > 7)
            {
                return true;
            }

            return false;
        }

        public void SetGoalsInRound(List<Team> randomTeams, int goalsfor)
        {
           
        }

    }
}