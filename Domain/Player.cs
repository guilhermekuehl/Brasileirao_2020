using System;
using System.Collections.Generic;

namespace Domain{

    public class Player
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Goals { get; set; }
        public bool TopScorer { get; set; } = false;

        public Player (string name)
        {
            Name = name;
        }
        public Player(bool topScorer)
        {
            TopScorer = topScorer;
        }
    }
}   