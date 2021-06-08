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
           
            Console.WriteLine("Press Y here to roll dice");
             string userinput  = Console.ReadLine();
            Random random = new Random();
            int dicenum = random.Next(1,6);
            Console.WriteLine("Player1 got: " +dicenum);

        }
    }
}
