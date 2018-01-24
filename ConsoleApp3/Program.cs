using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random arbitrarynum = new Random();
            int number = arbitrarynum.Next(1, 100);
            Console.Write("Im thinking about a number between one and one-hundred (take a guess): ");
            int yourguess = int.Parse(Console.ReadLine());
            int i = 0;
            while(yourguess != number)
            {
                i++;
                if (yourguess > number)
                {
                    Console.WriteLine("That is to high.");
                }
                else if(yourguess < number)
                {
                    Console.WriteLine("That is to low.");
                }
                Console.Write("guess again: ");
                
                yourguess = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("wooo you did it. It took you " + i + " trys to get it.");
            Console.ReadKey();
        }
    }
}