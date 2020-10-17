using System;
using System.Collections.Generic;

namespace Domain
{
    public class Brasileirao2020
    {
        private List<Team> _teams { get; set; }
        
        public IReadOnlyCollection<Team> Teams => _teams;

        public Brasileirao2020()
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
            
            if (Teams.Count > 7)
            {
                return true;
            }

            return false;
        }

        public List<Domain.Team> RandomGeneratorTeams()
        {
            
            Random randomize = new Random();
            var palmeiras = new Team("Palmeiras");
            var flamengo = new Team("Flamengo");
            var fluminense = new Team("Fluminense");
            var corinthians = new Team("Corinthians");
            var chapecoense = new Team("Chapecoense");
            var atleticoMG = new Team("Atlético - MG");
            var vasco = new Team("Vasco");
            var saoPaulo = new Team("São Paulo");

            var teams = new List<Team>{palmeiras, flamengo, fluminense, corinthians, chapecoense, atleticoMG, vasco, saoPaulo};

            
            while (teams.Count > 6)
            {
                var i = randomize.Next(0, teams.Count);
                teams.RemoveAt(i);
            }
            return teams;
        }
    }
}