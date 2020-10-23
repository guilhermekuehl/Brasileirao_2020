using System;
using System.Collections.Generic;

namespace Domain{

    public class Player
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Goals { get; set; }

        public Player(Guid id, string name, int goals)
        {
            Name = name;
            Goals = goals;
        }
    }
}   