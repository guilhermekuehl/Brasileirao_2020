using System;
using System.Collections.Generic;

namespace Domain
{
    public class Team
    {

        private List<Player> _players { get; set; } = new List<Player>();
        public IReadOnlyCollection<Player> Players => _players;

        public string Name { get; set; }
        public int Punctuation { get; set; } = 0;
        public int MatchesPlayed { get; set; } = 0;
        public int Wins { get; set; } = 0;
        public int Draws { get; set; } = 0;
        public int Defeats { get; set; } = 0;
        public int GoalBalance { get; set; } = 0;
        public int GoalsFor { get; set; } = 0;
        public int OwnGoals { get; set; } = 0;
        public int PercentageOfUse { get; set; } = 0;

        public Team(string name)
        {
            Name = name;
        }
        public Team(string name, int punctuation)
        {
            Name = name;
            Punctuation = punctuation;
        }

        public Team()
        {
        }

        public bool AddPlayers(List<Player> Players)
        {
            if (Players.Count > 15 && Players.Count < 33)
            {
                _players = Players;
                return true;
            }
            return false;
        }
        public bool RemovePlayers(List<Player> Players)
        {
            var temp = new List<Player>();
            if (Players.Count > 15 && Players.Count < 33)
            {
                temp = Players;
                return true;
            }
            return false;
        }
    }
}
