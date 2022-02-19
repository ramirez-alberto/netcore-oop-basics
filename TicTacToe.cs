using System;

namespace netcore_oop_basics
{
    class TicTacToe
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo userinput;
            var tictactoe = new Game();

            do
            {
                userinput = Console.ReadKey(true);
                tictactoe.HandleUserInput(userinput);
            } while (!tictactoe.QuitGame);

        }
    }
}
