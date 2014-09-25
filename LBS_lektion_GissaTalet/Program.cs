using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBS_lektion_GissaTalet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numberU = 0;
            string restart;
    
            Random random = new Random();
            int numberC = random.Next(1, 11);

            while (numberC != numberU)
            {
                Console.Clear();
                Console.WriteLine("Enter a number from one to ten");
                numberU = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (numberC > numberU)
                    Console.WriteLine("För lågt! försök igen.");

                else if (numberC < numberU)
                    Console.WriteLine("För högt! försök igen.");

                else
                {
                    Console.WriteLine("Grattis!");
                    Console.WriteLine("Vill du starta igen? ");
                    Console.WriteLine("Y/N");

                    restart = Console.ReadLine().ToLower();

                    if (restart == "y")
                    {

                    }
                }
            }
        }
    }
}
