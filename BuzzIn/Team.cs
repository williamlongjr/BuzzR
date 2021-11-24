using System;
using System.Collections.Generic;

namespace BuzzIn
{
    public class Team
    {
        public string TeamName { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();

        public Team AddPlayer(Player player)
        {
            Players.Add(player);
            return this;
        }

        public override string ToString()
        {
            return $"{TeamName} ({string.Join(", ", Players)})";
        }
    }
}
