using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Brasileirao2020
    {
        static void Main()
        {
        }
        private List<Team> _teams { get; set; }
        public IReadOnlyCollection<Team> Teams => _teams;

        public Brasileirao2020()
        {
            _teams = new List<Team>();
        }

        public List<(Team team, int goals)> RandomGeneratorTeams()
        {   
            Random randomize = new Random();
            (Team team, int goals) palmeiras = (new Team ("Palmeiras"), 0);
            (Team team, int goals) flamengo = (new Team("Flamengo"), 0);
            (Team team, int goals) fluminense = (new Team("Fluminense"), 0);
            (Team team, int goals) corinthians = (new Team("Corinthians"), 0);
            (Team team, int goals) chapecoense = (new Team("Chapecoense"), 0);
            (Team team, int goals) atleticoMG = (new Team("Atletico - MG"), 0);
            (Team team, int goals) vasco = (new Team("Vasco"), 0);
            (Team team, int goals) saoPaulo = (new Team("São Paulo"), 0);

            var dados = new Team();

            var teams = new List<(Team team, int goals)>{palmeiras, flamengo, fluminense, corinthians, chapecoense, atleticoMG, vasco, saoPaulo};
            var randomTeams = new List<(Team team, int goals)>();
            var goal = new int[2];

            for (int i = 0; i < 2; i++)
            {
                var index = randomize.Next(0, teams.Count);
                randomTeams.Add(teams.ElementAt(index));
                goal[i] = randomize.Next(0, 7);
                teams.RemoveAt(index);
            }   
                  
            if (goal[0] > goal[1])
            {
                randomTeams[0].team.Punctuation += 3;
                randomTeams[0].team.Wins++;
                randomTeams[0].team.MatchesPlayed++;
                randomTeams[1].team.MatchesPlayed++;
                randomTeams[1].team.Defeats++;
                randomTeams[0].team.GoalsFor+=goal[0];
                randomTeams[0].team.OwnGoals+=goal[1];
                randomTeams[1].team.GoalsFor+=goal[1];
                randomTeams[1].team.OwnGoals+=goal[0];
            }
            else if (goal[1] > goal[0])
            {
                randomTeams[1].team.Punctuation += 3;
                randomTeams[1].team.Wins++;
                randomTeams[0].team.MatchesPlayed++;
                randomTeams[1].team.MatchesPlayed++; 
                randomTeams[0].team.Defeats++;  
                randomTeams[0].team.GoalsFor+=goal[0];
                randomTeams[0].team.OwnGoals+=goal[1];
                randomTeams[1].team.GoalsFor+=goal[1];
                randomTeams[1].team.OwnGoals+=goal[0]; 
            }
            else
            {
                randomTeams[0].team.Punctuation++;
                randomTeams[1].team.Punctuation++;
                randomTeams[0].team.MatchesPlayed++;
                randomTeams[1].team.MatchesPlayed++; 
                randomTeams[0].team.Draws++; 
                randomTeams[1].team.Draws++; 
                randomTeams[0].team.GoalsFor+=goal[0];
                randomTeams[0].team.OwnGoals+=goal[1];
                randomTeams[1].team.GoalsFor+=goal[1];
                randomTeams[1].team.OwnGoals+=goal[0]; 
            }
            return randomTeams;
        }

               
    }
}