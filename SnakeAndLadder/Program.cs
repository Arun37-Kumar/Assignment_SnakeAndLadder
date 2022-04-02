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
            const int WINNING_POSITION = 100;


            //variables
            int position = 0;
            int noPlayPosition = 0;
            int winningPosition = 0;
            int count = 0;
            //Random class
            Random random = new Random();

            // random variable 

            //Console.WriteLine("Random Number : {0}", dieRoll);
            //Console.WriteLine("Die Option : {0}", dieOption);

            while (position <= WINNING_POSITION) { 

            int dieOption = random.Next(0, 2);
            int dieRoll = random.Next(1, 7);

            switch (dieOption)
            {
                case NO_PLAY:
                    noPlayPosition = position;
                    Console.WriteLine(position);
                    break;
                case LADDER:
                        if (position == WINNING_POSITION) {
                            position = 100; 
                        }
                        else {
                            position += dieRoll;
                        }
                    Console.WriteLine(position);
                    break;
                case SNAKE:
                    position -= dieRoll;
                    Console.WriteLine(position);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
                count++;

        }
            if (position == 100)
            {
                Console.WriteLine("Player 1 won ");
                Console.WriteLine("No of Count : {0}", count);
                Console.ReadLine();
            }


            Console.ReadLine();
        }
    }
}
