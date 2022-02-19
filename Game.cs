using System;

namespace netcore_oop_basics
{
    class Game
    {
        public bool QuitGame { get; set; }
        public Game()
        {
            QuitGame = false;
            DisplayBoard(" ");
        }
        private void DisplayBoard(string gridFiller)
        {
            //Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write($" {gridFiller} { (j < 2 ? "*" : "\n")}");
                Console.WriteLine($"{(i < 2 ? "***********" : "")}");
            }
        }

        public void HandleUserInput(ConsoleKeyInfo choice)
        {
            if (choice.Key == ConsoleKey.Escape)
            {
                QuitGame = true;
            }
            GameLogic(choice);
        }

        private void GameLogic(ConsoleKeyInfo userchoice)
        {
            if (QuitGame)
                Console.WriteLine("Thank you for playing!!");
        }
    }
}
