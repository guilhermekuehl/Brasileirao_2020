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

        public List<Team> RandomGeneratorTeams()
        {   
            Random randomize = new Random();
            var palmeiras = new Team("Palmeiras", 0);
            var flamengo = new Team("Flamengo", 0);
            var fluminense = new Team("Fluminense", 0);
            var corinthians = new Team("Corinthians", 0);
            var chapecoense = new Team("Chapecoense", 0);
            var atleticoMG = new Team("Atlético - MG", 0);
            var vasco = new Team("Vasco", 0);
            var saoPaulo = new Team("São Paulo", 0);

            var teams = new List<Team>{palmeiras, flamengo, fluminense, corinthians, chapecoense, atleticoMG, vasco, saoPaulo};
            var randomTeams = new List<Team>();

            for (int i = 0; teams.Count > 6; i++)
            {
                i = randomize.Next(0, teams.Count);
                randomTeams.Add(teams.ElementAt(i));
                teams.RemoveAt(i);
            }
            return randomTeams;
        }    

            
    }
}