using System.Collections.Generic;

namespace Domain{

    public class Player
    {
        
        public string Name { get; set; }
        public int Goals { get; set; } = 0;

        public Player(string name)
        {
            Name = name;
        }
    }
}