using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCardGameConsoleApp
{
    class Game
    {
        public static void playGame(Player player1, Player player2)
        {

            // SETUP GAME
            Deck deck = new Deck();
            deck.Shuffle();

            List<Card> player1Hand = new List<Card>();

            for (int i = 0; i < 26; i++)
            {
                player1Hand.Add(deck.deckOfCards[i]);
                deck.deckOfCards.Remove(deck.deckOfCards[i]);

            }

            List<Card> player2Hand = new List<Card>();
            foreach (var card in deck.deckOfCards) player2Hand.Add(card);
            deck.deckOfCards.Clear();

            // GAME LOGIC
            Random random = new Random();
            Card player1choice;
            Card player2choice;
            int rnd;

            while (true)
            {
                //Console.Clear();
                rnd = random.Next(0, player1Hand.Count);
                player1choice = player1Hand[rnd];
                Console.WriteLine("{0}'s choice: {1}\n", player1.Name, player1choice);

                rnd = random.Next(0, player2Hand.Count);
                player2choice = player2Hand[rnd];
                Console.WriteLine("{0}'s choice: {1}\n", player2.Name, player2choice);

                if (player1choice.Value > player2choice.Value)
                {
                    Console.WriteLine("{0} is the Winner!\n", player1.Name);
                }
                else if (player1choice.Value < player2choice.Value)
                {
                    Console.WriteLine("{0} is the Winner!\n", player2.Name);
                }
                else
                {
                    Console.WriteLine("No one is the winner :(\n");
                }
                Console.WriteLine("Press o to Exit");
                Console.WriteLine("Press any other key to play again");
                if (Console.ReadLine() == "o")
                {
                    Environment.Exit(0);
                }
            }
        }

    }
}

// SHOW CARDS METHOD
//public void ShowCards(Player playerA, Player playerB)
//{
//    Console.WriteLine("{0}'s hand: ", playerA.Name);
//    foreach (var card in player1Hand) Console.WriteLine(card);
//    Console.WriteLine(" ");
//    Console.WriteLine("{0}'s hand: ", playerB.Name);
//    foreach (var card in player2Hand) Console.WriteLine(card);
//    Console.WriteLine(" ");
//}

// GAME LOGIC EXAMPLE
//public static string GetAttackResult(Warrior warriorA,
//   Warrior warriorB)
//{
//    double warAAttkAmt = warriorA.Attack();
//    double warBBlkAmt = warriorB.Block();

//    double dmg2WarB = warAAttkAmt -
//        warBBlkAmt;

//    if (dmg2WarB > 0)
//    {
//        warriorB.Health = warriorB.Health -
//            dmg2WarB;
//    }
//    else dmg2WarB = 0;

//    Console.WriteLine("{0} Attacks {1} and" +
//        "Deals {2} Damage",
//        warriorA.Name,
//        warriorB.Name,
//        dmg2WarB);

//    Console.WriteLine("{0} Has {1} Health" +
//        "\n",
//        warriorB.Name,
//        warriorA.Health);

//    if (warriorB.Health <= 0)
//    {
//        Console.WriteLine("{0} has Died and " +
//            "{1} is Victorius\n",
//            warriorB.Name,
//            warriorA.Name);
//        return "Game Over";

//    }
//    else return "Fight Again";
//}
