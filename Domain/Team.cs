using System;

namespace Domain
{
    public class Team
    {
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


    }
}
