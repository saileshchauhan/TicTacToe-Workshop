using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeProject
{
    class TicTacToeGame
    {
        char[] boardArray = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public void Create_Board()
        {
            Console.WriteLine(" |"+boardArray[1]+"|"+boardArray[2]+"|"+boardArray[3]+"|");
            Console.WriteLine(" |" + boardArray[4]+"|" + boardArray[5]+ "|" + boardArray[6]+ "|");
            Console.WriteLine(" |" + boardArray[7]+ "|" + boardArray[8]+"|" + boardArray[9]+"|");
        }
        public void Check_Player()
        {
           

            Console.WriteLine("Enter your Choice");
            Console.WriteLine("1. you will choose X\n 2. you will choose O  ");
            int option =ConvertTo.int32(Console.ReadLine());


            switch (option)
            {
                case 1:
                    Console.WriteLine("");
                    char playerOneSelection = 'X';
                    char computer = 'O';
                    break;
                case 2:
                    Console.WriteLine("");
                    playerOneSelection = 'O';
                    computer = 'X';
                    break;
                default:
                    break;

            }

        }
        public void Show_Board()
        {
            Console.WriteLine(" |" + boardArray[1] + "|" + boardArray[2] + "|" + boardArray[3] + "|");
            Console.WriteLine(" |" + boardArray[4] + "|" + boardArray[5] + "|" + boardArray[6] + "|");
            Console.WriteLine(" |" + boardArray[7] + "|" + boardArray[8] + "|" + boardArray[9] + "|");
        }
    }
}
