using System;

namespace SnakeLadderProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder program");

            SnakeLadderCode snake = new SnakeLadderCode();

            snake.Start();
        }
    }
}
