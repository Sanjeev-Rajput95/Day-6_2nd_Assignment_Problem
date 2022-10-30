using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment2
{
    internal class Day6problems2
    {

        public  void RupeesNotes(int amount)
        {
            int[] currency = new int[] { 1, 2, 5, 10, 50,100, 500,1000 };
            int[] currencyCounter = new int[10];

            for (int i = 0; i < 10; i++)
            {
                if ( amount >= currency[i] )
                {
                    currencyCounter[i] = amount / currency[i];
                    amount = amount % currency[i];
                }
            }

            Console.WriteLine("Currency Count: ");
            for (int i = 0; i < 10; i++)
            {
                if (currencyCounter[i] != 0)
                {
                    Console.WriteLine(currency[i] + " : " + currencyCounter[i]);
                }
            }
        }
    }
}
