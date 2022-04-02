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

            //Constants
            const int PLAYER_ONE = 1;
            const int NO_PLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;

            //variables
            int starPosition = 0;
            int position = 0;
            
            Random random = new Random();
            int dieOption = random.Next(0,2);
            int dieRoll = random.Next(1,7);
            Console.WriteLine("Random Number : {0}",dieRoll);
            Console.WriteLine("Die Option : {0}", dieOption);

            switch (dieOption)
            {
                case NO_PLAY:
                    position = 0;
                    break;
                case LADDER:
                    position += dieRoll;
                    Console.WriteLine("Position moved to : {0}",position);
                    break;
                case SNAKE:
                    position -= dieRoll;
                    if(position < 0)
                    {
                        position = 0;
                        Console.WriteLine("Position moved to : {0}", position);
                        
                    }
                    break;
                default:
                    Console.WriteLine("Invalid move");
                    break;

            }

            Console.ReadLine();
        }
    }
}
