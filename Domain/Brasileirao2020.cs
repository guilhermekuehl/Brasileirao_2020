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
        private List<Player> _players { get; set; }
        public IReadOnlyCollection<Player> Players => _players;


        private List<(Team name, int goals)> _teams { get; set; }
        public IReadOnlyCollection<(Team name, int goals)> Teams => _teams;

        public Brasileirao2020()
        {
            _teams = new List<(Team name, int goals)>();
            
        }

        public List<(Team team, int goals)> RandomGeneratorTeams()
        {   
            Random randomize = new Random();
            (Team name, int goals) palmeiras = (new Team ("Palmeiras"), 0);
            (Team name, int goals) flamengo = (new Team("Flamengo"), 0);
            (Team name, int goals) fluminense = (new Team("Fluminense"), 0);
            (Team name, int goals) corinthians = (new Team("Corinthians"), 0);
            (Team name, int goals) chapecoense = (new Team("Chapecoense"), 0);
            (Team name, int goals) atleticoMG = (new Team("Atletico - MG"), 0);
            (Team name, int goals) vasco = (new Team("Vasco"), 0);
            (Team name, int goals) saoPaulo = (new Team("São Paulo"), 0);

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
                randomTeams[0].team.GoalsFor += goal[0];
                randomTeams[0].team.OwnGoals += goal[1];
                randomTeams[1].team.GoalsFor += goal[1];
                randomTeams[1].team.OwnGoals += goal[0];
            }
            else if (goal[1] > goal[0])
            {
                randomTeams[1].team.Punctuation += 3;
                randomTeams[1].team.Wins++;
                randomTeams[0].team.MatchesPlayed++;
                randomTeams[1].team.MatchesPlayed++; 
                randomTeams[0].team.Defeats++;  
                randomTeams[0].team.GoalsFor += goal[0];
                randomTeams[0].team.OwnGoals += goal[1];
                randomTeams[1].team.GoalsFor += goal[1];
                randomTeams[1].team.OwnGoals += goal[0]; 
            }
            else
            {
                randomTeams[0].team.Punctuation++;
                randomTeams[1].team.Punctuation++;
                randomTeams[0].team.MatchesPlayed++;
                randomTeams[1].team.MatchesPlayed++; 
                randomTeams[0].team.Draws++; 
                randomTeams[1].team.Draws++; 
                randomTeams[0].team.GoalsFor += goal[0];
                randomTeams[0].team.OwnGoals += goal[1];
                randomTeams[1].team.GoalsFor += goal[1];
                randomTeams[1].team.OwnGoals += goal[0]; 
            }
            return randomTeams;
        }
        public List<(Player name, int goals)> TopScorerDecided()
        {
            Random randomize = new Random();
            (Player name, int goals) gallardo = (new Player ("Thiago Gallardo"), 0);
            (Player name, int goals) valdivia = (new Player ("Valdívia Amorim"), 0);
            (Player name, int goals) luan = (new Player ("Luan Santos"), 0);
            (Player name, int goals) dudu = (new Player ("Eduardo Ramos"), 0);
            (Player name, int goals) neymar = (new Player ("Neymar Jr."), 0);
            (Player name, int goals) gabigol = (new Player ("Gabriel Lanzoni"), 0);
            (Player name, int goals) marcos = (new Player ("Marcos Augustini"), 0);
            (Player name, int goals) adrian = (new Player ("Adrian Silva"), 0);
            (Player name, int goals) pablo = (new Player ("Pablo Lima"), 0);
            (Player name, int goals) lucas = (new Player ("Lucas Stiller"), 0);
            (Player name, int goals) thiago = (new Player ("Thiago Moraes"), 0);
            (Player name, int goals) carlos = (new Player ("Carlos Henrique"), 0);
            (Player name, int goals) julio = (new Player ("Julio Garcia"), 0);
            (Player name, int goals) martins = (new Player ("Martins Antony"), 0);
            (Player name, int goals) caio = (new Player ("Caio dos Santos"), 0);
            (Player name, int goals) manoel = (new Player ("Manoel Lima"), 0);
            (Player name, int goals) gabriel = (new Player ("Gabriel Oliveira"), 0);
            (Player name, int goals) antonio = (new Player ("Antonio Nunes"), 0);
            (Player name, int goals) yuri = (new Player ("Yuri Martins"), 0);
            (Player name, int goals) alisson = (new Player ("Alisson Ribeiro"), 0);
            (Player name, int goals) marlon = (new Player ("Marlon Floriani"), 0);
            (Player name, int goals) amaral = (new Player ("Amaral Batista"), 0);
            
            var topScorerRank = new string[10];

            var randomPlayers = new List<(Player name, int goals)>();
            var _players = new List<(Player name, int goals)>(){gallardo, valdivia, luan, dudu, neymar, gabigol, marcos, adrian, pablo, lucas, thiago, carlos,
            julio, martins, caio, manoel, gabriel, antonio, yuri, alisson, marlon, amaral};
            var goal = new int[22];


            for (int i = 0; i < 22; i++)
            {
                var index = randomize.Next(0, _players.Count);
                randomPlayers.Add(_players.ElementAt(index));
                goal[i] = randomize.Next(0, 30);
            }
            return _players;
        }

        public List<(Team name, int Punctuation)> TeamsRankDecided()
        {
            var team = new List<(Team name, int Punctuation)>();
            return team;
        }
        // public List<Team> AddResults()
        // {
        //     var teamValues = new Team();
        //     teamValues.PercentageOfUse = (teamValues.Wins - teamValues.Defeats) * teamValues.MatchesPlayed / 100; 
        // }
    }
}