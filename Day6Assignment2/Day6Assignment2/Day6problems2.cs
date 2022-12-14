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

        // DayOfWeek Problem 

        public void dayOfWeek ()
        {

            Console.WriteLine("Welcome to Gregorian Calender");
            Console.Write("Enter Month : ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Day : ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Year : ");
            double y = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(y - (14 - m / 12));
            double x = y0 + y0 / 4 + y0 / 400 - y0 / 100;
            double m0 = m + (12 * (14 - m) / 12) - 2;
            double d0 = (int)(d + x + 31 * m / 12) % 12;
            switch (m)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }
            switch (d0)
            {

                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("invallid input given");
                    break;
            }
        }   

        // Temperature Conversion Problem

        public void temperature_Conversion ()
        {
            int Far = 0;
            int cel = 1;
            Console.WriteLine("Enter zero(0) to convert to celsius from farenheit : ");
            Console.Write("Enter 1 to convert to celsius from farenheit : ");
            

            int check = Convert.ToInt32(Console.ReadLine());

            if (check == 0)
            {
                Console.WriteLine("\n");
                Console.Write("Enter the Temprature in Fahrenheit : ");
                double F = Convert.ToDouble(Console.ReadLine());
                double fc = Convert.ToDouble((F - 32) * 5 / 9);
                Console.WriteLine($"{fc} Degree Celsius ");
            }
            else if (check == 1)
            {
                Console.WriteLine("\n");
                Console.Write("Enter the Temprature in Celsius : ");
                double C = Convert.ToDouble(Console.ReadLine());
                double cf = Convert.ToDouble((C * 9 / 5) + 32);
                Console.WriteLine($"{cf} Degree Farenheit");
            }
            else
            {
                Console.WriteLine("You are Entered Wrong Input");
            }
        }      

        // Monthly Payements Program
            public void Payment()
            {
                Console.Write("Enter the Principal : ");
                double principal = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the Year : ");
                double year = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the Rate : ");
                double rate = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("Monthly Payment is " + monthlyPayment(principal, year, rate));
                Console.WriteLine("");

        }
        public static double monthlyPayment(double p, double y, double r)
            {
                double n = 12 * y;
                double rpp = r / (12 * 100);
                double payment = p * rpp / (1 - Math.Pow((1 + rpp), -n));
                return payment;
            }
    }
}
