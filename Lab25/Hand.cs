using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab25
{
    public class Hand : CardList
    {

        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        // PRIVATE METHODS

        /// <summary>
        /// This method initializes class variables and other objects
        /// </summary>
        protected override void _initialize()
        {
            // this method is currently empty
        }

        // PUBLIC METHODS

        /// <summary>
        /// This method overrides the built-in ToString method
        /// </summary>
        public override string ToString()
        {
            string outputString = "";
            outputString += "The Hand contains:\n";
            outputString += "=====================================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }
            return outputString;
        }

        public void HighestCards()
        {
            var highestCards =
                from card in this
                orderby card.Face descending
                select card;
            Console.WriteLine("This is the highest Card:\n=====================================================");

            if (highestCards.Any())
            {
                Console.WriteLine("The " + highestCards.First().Face + " of " + highestCards.First().Suit);
            }
        }
    }
}