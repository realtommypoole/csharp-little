using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();

            //int count = deck.Cards.Count(x => x.Face == Face.Ace);
            //Console.WriteLine(count);


            List<int> numberList = new List<int> { 1, 2, 3, 535, 343, 23 };

            int min = numberList.Min();
            int sum = numberList.Sum();
            //int sum = numberList.Where(x => x > 20).Sum();
            Console.WriteLine(sum);

            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();


            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}


            //    foreach (Card card in deck.Cards)
            //    {
            //        Console.WriteLine(card.Face + " of " + card.Suit);

            //    }
            //    Console.WriteLine(deck.Cards.Count);
                Console.ReadLine();
        }
        
    }
}
