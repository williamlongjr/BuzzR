﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuzzIn
{
    public class Player
    {
        public string Name { get; set; } = String.Empty;

        public Player()
        {

        }

        public Player(string playerName)
        {
            Name = playerName;
        }
                
        public override string ToString()
        {
            return Name;
        }
    }
}
