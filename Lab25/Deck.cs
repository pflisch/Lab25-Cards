using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab25
{
    public class Deck : CardList
    {
        // PRIVATE INSTANCE VARIABLES
        private Random _random;

        // PRIVATE PROPERTIES
        private Random Random
        {
            get
            {
                return this._random;
            }
        }

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        // PRIVATE METHODS

        /// <summary>
        /// This is the private _initialize the initializes the Deck with 52 cards.
        /// this method also initializes other class variables.
        /// </summary>
        protected override void _initialize()
        {
            // initialize the random object
            this._random = new Random();

            // load the list with cards.
            for (int suit = 0; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = 1; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }

        /// <summary>
        /// This methosd overrides the built-in ToString method and outputs the current cards of the Deck.
        /// </summary>
        /// <returns></returns>
        // PUBLIC METHODS
        public override string ToString()
        {
            string outputString = "";
            outputString += "The Deck contains:\n";
            outputString += "=====================================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }
            return outputString;
        }

        /// <summary>
        /// This method huffles the deck.
        /// </summary>
        public void Shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;

            for (int i = 0; i < this.Count; i++)
            {
                firstCard = this.Random.Next(0, 52);
                secondCard = this.Random.Next(0, 52);
                tempCard = (Card)this[secondCard].Clone();
                this[secondCard].Face = this[firstCard].Face;
                this[secondCard].Suit = this[firstCard].Suit;
                this[firstCard].Face = tempCard.Face;
                this[firstCard].Suit = tempCard.Suit;
            }
        }

        /// <summary>
        /// This methods remove a Card from element 0 in the list and returns it.
        /// </summary>
        /// <returns></returns>
        public Card Deal1()
        {
            Card firstCard = (Card)this[0].Clone();
            this.RemoveAt(0); // removes the top card

            Console.WriteLine("Deck contains: " + this.Count + " cards.");
            return firstCard;
        }

        public Hand Deal5()
        {
            Hand hand = new Hand(); // new empty hand contianer

            for (int i = 0; i < 5; i++)
            {
                Card firstCard = (Card)this[i].Clone();
                this.RemoveAt(0); // removes the top card
                hand.Add(firstCard);
            }
            return hand;

        }
    }
}