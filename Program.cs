using System;

namespace TicTacToeGame
{
    class Program
    {
        public const int HEAD = 0;
        public const int TAIL = 1;
        public enum Player { USER,COMPUTER};

        static void Main(string[] args)
        {
            char[] board= TicTacToe.CreateBoard();
            TicTacToe.showBoard(board);
            int userMove = TicTacToe.getUserMove(board);
            TicTacToe.Player player = TicTacToe.getWhoStartsFirst();
            char userLetter = TicTacToe.chooseUserLetter();
            Console.WriteLine("Check if won" +TicTacToe.isWinner(board,userLetter));
        }
    }
}
