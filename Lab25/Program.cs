using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Priscylla Flisch
 * Student ID: 300931589
 * Date: 25th July 2017
 * Description: Lesson 11 (Demo)
 * Version: 0.1 - Implement the HighestCards methods
 * Github Link: https://github.com/pflisch/Lab25-Cards
 */

namespace Lab25
{
    class Program
    {
        static void Main(string[] args)
        {
            Hand hand = new Hand(); // new empty hand contianer

            Deck deck = new Deck();

            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();

            hand.Add(deck.Deal1()); // deal one card from the top of the deck
            Console.WriteLine(hand.ToString());
            Console.WriteLine();

            hand.Add(deck.Deal1()); // deal one card from the top of the deck
            Console.WriteLine(hand.ToString());

            hand = deck.Deal5(); // Created a new Hand object and assigns it to hand
            Console.WriteLine(hand.ToString());

            hand.HighestCards();

        }
    }
}