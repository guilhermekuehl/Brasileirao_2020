using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Fan
    {
        public List<(Player name, int goals)> ShowTableTopScorer()
        {
            var brasileirao = new Brasileirao2020();
            var table = brasileirao.TopScorerDecided();

            table.Sort();
            return table;
        }
        public void ShowTableOfTeams()
        {
            var brasileirao = new Brasileirao2020();
            var table = brasileirao.TeamsRankDecided();

            table.Sort();
            var rebaixados = new List<(Team name, int Punctuation)>();
            var libertadores = new List<(Team name, int Punctuation)>();

            
            for (int i = 5; i > 4; i++)
            {
                rebaixados[i] = table[i];
            }
            
            for (int i = 0; i < 4; i++)
            {
                libertadores[i] = table[i];
            }
        }

        public void ShowTableOfResults()
        {
        
        }
       

    
    }
}