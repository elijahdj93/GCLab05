using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            while (keepGoing == true)
            {
                string userChoice;
                Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n):");
                userChoice = Console.ReadLine();
                if (userChoice == "n")
                {
                    keepGoing = false;
                }
                else
                {
                    int x;
                    x = readDie();

                    Random r = new Random();

                    int result = r.Next(1, x + 1);
                    int result2 = r.Next(1, x + 1);

                    Console.WriteLine(result);
                    Console.WriteLine(result2);

                    Console.WriteLine("Roll again? (y/n)");
                    userChoice = Console.ReadLine();
                    if (userChoice == "n")
                    {
                        keepGoing = false;
                    }
                    

                    
                }




            }
        }


        public static int readDie()
        {
            int input;
            Console.WriteLine("How many sides should the die have?");
            input = int.Parse(Console.ReadLine());

            return input;
        }


       /*public static int randomNum()
        {
            Random varName = new Random();

            int result = varName.Next(1,readDie() + 1);

            return result;
        }*/
    }
}
