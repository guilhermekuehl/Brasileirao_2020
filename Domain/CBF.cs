using System.Collections.Generic;

namespace Domain
{
    public class CBF
    {
        public List<Player> _players { get; set; }

        public IReadOnlyCollection<Team> Teams => _teams;
        private List<Team> _teams { get; set; }
        public CBF()
        {
            _players = new List<Player>();
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

        public bool AddPlayers(List<Player> _players)
        {
            if (_players.Count >= 16 && _players.Count <= 32)
            {
                return true;
            }
            return false;
        }

    }
}