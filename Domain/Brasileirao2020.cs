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
        public List<Player> _player { get; set; }

        public Brasileirao2020()
        {
            _teams = new List<Team>();
            _player = new List<Player>();
        }

        public List<Team> RandomGeneratorTeams()
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
            var randomTeams = new List<Team>();

            for (int i = 0; teams.Count > 6; i++)
            {
                i = randomize.Next(0, teams.Count);
                teams.RemoveAt(i);
            }
            return teams;
        }


        
    }
}