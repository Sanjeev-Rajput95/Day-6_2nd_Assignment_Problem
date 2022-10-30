using System;

namespace Day6Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Day6problems2 obj = new Day6problems2();
            Console.Write("enter amount : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            obj.RupeesNotes(amount);
            obj.dayOfWeek();
            obj.temperature_Conversion();
        }


    }
}