using System;

namespace netcore_oop_basics
{
    class Game
    {

        private static void DisplayBoard(string gridFiller)
        {
            //Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write($" {gridFiller} { (j < 2 ? "*" : "\n")}");
                Console.WriteLine($"{(i < 2 ? "***********" : "")}");
            }
        }
        static void Main(string[] args)
        {
            DisplayBoard(" ");
            Console.WriteLine("Choice");


        }
    }
}
