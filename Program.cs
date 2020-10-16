using System;

namespace TicTacToeGame
{
    class Program
    {
        
        static void Main(string[] args)
        {
            char[] board= TicTacToe.CreateBoard();
            char userLetter = TicTacToe.chooseUserLetter();
            char computerLetter = (userLetter == 'X') ? 'O' : 'X';
            TicTacToe.Player player = TicTacToe.getWhoStartsFirst();
            bool gameIsPlaying = true;
            TicTacToe.GameStatus gameStatus;
            while(gameIsPlaying)
            {
                //players turn
                if(player.Equals(TicTacToe.Player.USER))
                {
                    TicTacToe.showBoard(board);
                    int userMove = TicTacToe.getUserMove(board);
                    String WonMessage = "Hooray! you won";
                    gameStatus = TicTacToe.getGameStatus(board, userMove, userLetter, WonMessage);
                    player = TicTacToe.Player.COMPUTER;
                }
                else
                {
                    // computer turn
                    String WonMessage = "The computer has beaten you";
                    int computerMove = TicTacToe.getComputerMove(board,computerLetter,userLetter);
                    gameStatus = TicTacToe.getGameStatus(board, computerMove, computerLetter, WonMessage);
                    player = TicTacToe.Player.USER;
                }
                if (gameStatus.Equals(TicTacToe.GameStatus.CONTINUE)) continue;
                gameIsPlaying = false;

            }
        }

    }
}
