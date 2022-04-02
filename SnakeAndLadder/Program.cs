using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game!");

            int PLAYER_ONE = 1;
            int starPosition = 0;

            Random random = new Random();
            int dieRoll = random.Next(1,7);
            Console.WriteLine("Random Number : {0}",dieRoll);
            Console.ReadLine();
        }
    }
}
