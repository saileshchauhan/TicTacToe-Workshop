using System;

namespace TicTacToeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame ticTacToe = new TicTacToeGame();
            ticTacToe.Create_Board();
            ticTacToe.Check_Player();
            ticTacToe.Show_Board();
          
        }

    }
}
