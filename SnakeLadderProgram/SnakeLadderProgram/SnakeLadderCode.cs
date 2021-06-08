using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderProgram
{
   public class SnakeLadderCode
    {
        public void Start()
        {
            int Player1Position = 0;

            while (Player1Position != 100)
            {
                Console.WriteLine("Press Y here to roll dice");
                string userinput = Console.ReadLine();
                Random random = new Random();
                int dicenum = random.Next(1, 6);
                Console.WriteLine("Player1 got: " + dicenum);

                int checkOption = random.Next(1, 3);
                if (checkOption == 1)
                {
                    Console.WriteLine("No play for player1");
                    Console.WriteLine("Your position is: " + Player1Position);
                }
                if (checkOption == 2)
                {
                    Console.WriteLine("Player1 got Ladder");
                    Player1Position += dicenum;
                    Console.WriteLine("Player1 position :" + Player1Position);
                }
                if (checkOption == 3)
                {
                    Console.WriteLine("Player1 got SnakeFace");
                    Player1Position -= dicenum;
                    if (Player1Position < 0)
                    {
                        Player1Position = 0;
                    }
                    Console.WriteLine("Player1 position :" + Player1Position);
                }
            }
        }
    }
}
