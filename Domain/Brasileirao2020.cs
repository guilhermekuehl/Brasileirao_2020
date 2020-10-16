using System.Collections.Generic;

namespace Domain
{
    public class Brasileirao2020
    {
        private List<Team> teams { get; set; }
        
        public IReadOnlyCollection<Team> Teams => teams;

        public Brasileirao2020()
        {
            teams = new List<Team>();
        }

        public bool Register(List<Team> teams, string password, string name)
        {
            if (password == "CBF")
            {
                return true;
            }

                        
            
        }
    }
}