using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCardGameConsoleApp
{
    class Deck
    {

        // CREATE DECK OF CARDS LIST AND FILL WITH CARD OBJECTS
        public List<Card> deckOfCards = new List<Card>
            { 
                // Create 13 cards Hearts
                new Card { Face = "Ace", Type = "Hearts", Value = 1 },
                new Card { Face = "2", Type = "Hearts", Value = 2 },
                new Card { Face = "3", Type = "Hearts", Value = 3 },
                new Card { Face = "4", Type = "Hearts", Value = 4 },
                new Card { Face = "5", Type = "Hearts", Value = 5 },
                new Card { Face = "6", Type = "Hearts", Value = 6 },
                new Card { Face = "7", Type = "Hearts", Value = 7 },
                new Card { Face = "8", Type = "Hearts", Value = 8 },
                new Card { Face = "9", Type = "Hearts", Value = 9 },
                new Card { Face = "10", Type = "Hearts", Value = 10 },
                new Card { Face = "Jack", Type = "Hearts", Value = 11 },
                new Card { Face = "Queen", Type = "Hearts", Value = 12 },
                new Card { Face = "King", Type = "Hearts", Value = 13 },

                // Create 13 cards Clubs
                new Card { Face = "Ace", Type = "Clubs", Value = 1 },
                new Card { Face = "2", Type = "Clubs", Value = 2 },
                new Card { Face = "3", Type = "Clubs", Value = 3 },
                new Card { Face = "4", Type = "Clubs", Value = 4 },
                new Card { Face = "5", Type = "Clubs", Value = 5 },
                new Card { Face = "6", Type = "Clubs", Value = 6 },
                new Card { Face = "7", Type = "Clubs", Value = 7 },
                new Card { Face = "8", Type = "Clubs", Value = 8 },
                new Card { Face = "9", Type = "Clubs", Value = 9 },
                new Card { Face = "10", Type = "Clubs", Value = 10 },
                new Card { Face = "Jack", Type = "Clubs", Value = 11 },
                new Card { Face = "Queen", Type = "Clubs", Value = 12 },
                new Card { Face = "King", Type = "Clubs", Value = 13 },

                // Create 13 cards Diamonds
                new Card{ Face = "Ace", Type = "Diamonds", Value = 1 },
                new Card{ Face = "2", Type = "Diamonds", Value = 2 },
                new Card{ Face = "3", Type = "Diamonds", Value = 3 },
                new Card{ Face = "4", Type = "Diamonds", Value = 4 },
                new Card{ Face = "5", Type = "Diamonds", Value = 5 },
                new Card{ Face = "6", Type = "Diamonds", Value = 6 },
                new Card{ Face = "7", Type = "Diamonds", Value = 7 },
                new Card{ Face = "8", Type = "Diamonds", Value = 8 },
                new Card{ Face = "9", Type = "Diamonds", Value = 9 },
                new Card{ Face = "10", Type = "Diamonds", Value = 10 },
                new Card{ Face = "Jack", Type = "Diamonds", Value = 11 },
                new Card{ Face = "Queen", Type = "Diamonds", Value = 12 },
                new Card{ Face = "King", Type = "Diamonds", Value = 13 },

                // Create 13 cards Spades
                new Card { Face = "Ace", Type = "Spades", Value = 1 },
                new Card { Face = "2", Type = "Spades", Value = 2 },
                new Card { Face = "3", Type = "Spades", Value = 3 },
                new Card { Face = "4", Type = "Spades", Value = 4 },
                new Card { Face = "5", Type = "Spades", Value = 5 },
                new Card { Face = "6", Type = "Spades", Value = 6 },
                new Card { Face = "7", Type = "Spades", Value = 7 },
                new Card { Face = "8", Type = "Spades", Value = 8 },
                new Card { Face = "9", Type = "Spades", Value = 9 },
                new Card { Face = "10", Type = "Spades", Value = 10 },
                new Card { Face = "Jack", Type = "Spades", Value = 11 },
                new Card { Face = "Queen", Type = "Spades", Value = 12 },
                new Card { Face = "King", Type = "Spades", Value = 13 }
            };

        // FUNCTIONALITY TO SHUFFLE THE DECK OF CARDS, CARDS GET PUT RANDOMLY IN A SECOND DECK AND GET PUT BACK IN THE FIRST DECK
        public List<Card> shuffleDeck = new List<Card>();
        public void Shuffle()
        {
            Random random = new Random();
            int rnd;
            Deck deck = new Deck();
            int i = deck.deckOfCards.Count;
            while (i > 0)
            {
                rnd = random.Next(0, deckOfCards.Count);
                shuffleDeck.Add(deckOfCards[rnd]);
                deckOfCards.Remove(deckOfCards[rnd]);
                i--;
            }
            foreach (var item in shuffleDeck) deckOfCards.Add(item);
            //foreach (var item in deckOfCards) Console.WriteLine(item);
        }
    }
}
