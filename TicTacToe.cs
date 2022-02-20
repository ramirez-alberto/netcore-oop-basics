using System;
using System.Collections.Generic;

namespace netcore_oop_basics
{
    class TicTacToe : Game
    {
        ConsoleKeyInfo userinput;
        List<char> userkeys = new List<char> { 'x', 'o' };

        public TicTacToe() : base(true)
        {
            
        }

        protected override void HandleUserInput(ConsoleKeyInfo choice)
        {
            if (choice.Key == ConsoleKey.Escape)
                currentstate = GameState.QUIT;
            GameLogic(choice);
        }

        protected override void GameLogic(ConsoleKeyInfo userchoice)
        {
            if (currentstate is GameState.QUIT)
            {
                Console.WriteLine("Thanks For Playing!!");
                QuitGame = true;
            }
        }

        public void Play()
        {
            Console.WriteLine("Play as X or O:");
            do
            {
                userinput = Console.ReadKey(true);
                HandleUserInput(userinput);
            } while (!QuitGame);
        }

    }
}
