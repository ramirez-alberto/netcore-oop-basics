using System;
using System.Collections.Generic;

namespace netcore_oop_basics
{
    abstract class Game
    {
        protected enum GameState { START, QUIT }
        private bool quitgame = false;
        protected GameState currentstate {get;set;}
        public Game()
        {
            currentstate = GameState.START;
            
        }
        public Game(bool displayboard)
        {
            currentstate = GameState.START;
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

        protected virtual void HandleUserInput(ConsoleKeyInfo choice)
        {
            if (choice.Key == ConsoleKey.Escape)
                currentstate = GameState.QUIT;

            GameLogic(choice);
        }

        protected virtual void GameLogic(ConsoleKeyInfo userchoice)
        {
            if (currentstate is GameState.QUIT)
            {
                Console.WriteLine("Thank you for playing!!");
                QuitGame = true;
            }
        }


        public bool QuitGame
        {
            get
            {
                return quitgame;
            }
            set{
                quitgame = value;
            }
        }
    }
}
