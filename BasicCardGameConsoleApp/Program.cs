using System;

namespace BasicCardGameConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Harry");
            Player player2 = new Player("Der Jo");
            Game.playGame(player1, player2);
        }
    }
}
