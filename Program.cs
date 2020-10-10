using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] board= TicTacToe.CreateBoard();
            char userLetter = TicTacToe.chooseUserLetter();
            TicTacToe.showBoard(board);
            int userMove = TicTacToe.getUserMove(board);
            TicTacToe.makeMove(board, userMove, userLetter);
            TicTacToe.Player player = TicTacToe.getWhoStartsFirst();
        }
    }
}
