using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCardGameConsoleApp
{
    class Player
    {
        public string Name { get; set; }
        //public static List<Card> playerHand = new List<Card>();

        public Player(string name)
        {
            Name = name;
        }
    }
}
