using System;

namespace TicTacToeGame
{
    class Program
    {
        
        static void Main(string[] args)
        {
            char[] board= TicTacToe.CreateBoard();
            TicTacToe.showBoard(board);
            int userMove = TicTacToe.getUserMove(board);
            TicTacToe.Player player = TicTacToe.getWhoStartsFirst();
            char userLetter = TicTacToe.chooseUserLetter();
            char computerLetter = (userLetter == 'X') ? 'O' : 'X';
            Console.WriteLine("Check if won" +TicTacToe.isWinner(board,userLetter));
            // computer move
             int computerMove = TicTacToe.getComputerMove(board, computerLetter,userLetter);

        }

    }
}
