// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TicTacToe.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kirti Swaraj"/>
// --------------------------------------------------------------------------------------------------------------------

namespace TicTacToeGame
{
using System;
using System.Collections.Generic;
    using System.Reflection.Metadata.Ecma335;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;

  /// <summary>
  /// Creating a class
  /// </summary>
    public class TicTacToe
    {
        public const int HEAD = 0;
        public const int TAIL = 1;
        public enum GameStatus { WON,FULL_BOARD,CONTINUE};
        public enum Player { USER,COMPUTER};
        /// <summary>
        /// Creates the board.
        /// </summary>
        /// <returns></returns>
        public static char[] CreateBoard()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';
            }

            return board;
        }
        /// <summary>
        /// Chooses the user letter.
        /// </summary>
        /// <returns></returns>
        public static char chooseUserLetter()
        {
            Console.WriteLine("Choose your letter 'X' or 'O' :");
            String userLetter = Console.ReadLine();
            return char.ToUpper(userLetter[0]);
        }
        /// <summary>
        /// Shows the board.
        /// </summary>
        /// <param name="board">The board.</param>
        public static void showBoard(char[] board)
        {
            Console.WriteLine("\n " + board[1] + "|" + board[2] + "|" + board[3]);
            Console.WriteLine("--------");
            Console.WriteLine(" " + board[4] + "|" + board[5] + "|" + board[6]);
            Console.WriteLine("--------");
            Console.WriteLine(" " + board[7] + "|" + board[8] + "|" + board[9]);
        }
        /// <summary>
        /// Gets the user move.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <returns></returns>
        public static int getUserMove(char[] board)
        {
            int[] validCells = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            while (true)
            {
                Console.WriteLine("Where is your next move?[1-9]: ");
                int index = Convert.ToInt32(Console.ReadLine());
                if (Array.Find<int>(validCells, element => element == index) != 0 && isSpaceFree(board, index))
                    return index;
            }
        }
        /// <summary>
        /// Determines whether [is space free] [the specified board].
        /// </summary>
        /// <param name="board">The board.</param>
        /// <param name="index">The index.</param>
        /// <returns>
        ///   <c>true</c> if [is space free] [the specified board]; otherwise, <c>false</c>.
        /// </returns>
        public static bool isSpaceFree(char[] board, int index)
        {
            return board[index] == ' ';
        }
        /// <summary>
        /// Makes the move.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <param name="index">The index.</param>
        /// <param name="Letter">The letter.</param>
        public static void makeMove(char[] board, int index, char Letter)
        {
            Boolean spaceFree = isSpaceFree(board, index);
            if (spaceFree) board[index] = Letter;

        }
        /// <summary>
        /// Gets the who starts first.
        /// </summary>
        /// <returns></returns>
        public static Player getWhoStartsFirst()
        {
            int toss = getOneFromRandomChoices(2);
            return (toss == HEAD) ? Player.USER : Player.COMPUTER;
        }
        public static int getOneFromRandomChoices(int choices)
        {
            Random random = new Random();
            return (int)(random.Next() * 10) % choices;
        }
        public static bool isWinner(char[] b, char ch)
        { 
            return((b[1]==ch && b[2]==ch && b[3]==ch) ||
                (b[4] == ch && b[5] == ch && b[6] == ch) ||
                (b[7] == ch && b[8] == ch && b[9] == ch) ||
                (b[1] == ch && b[4] == ch && b[7] == ch) ||
                (b[2] == ch && b[5] == ch && b[8] == ch) ||
                (b[3] == ch && b[6] == ch && b[9] == ch) ||
                (b[1] == ch && b[5] == ch && b[9] == ch) ||
                (b[7] == ch && b[5] == ch && b[3] == ch));
        }
        /// <summary>
        /// Gets the winning move.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <param name="letter">The letter.</param>
        /// <returns></returns>
        public static int getWinningMove(char[] board, char letter)
        {
            for(int index = 1; index<board.Length;index++)
            {
                char[] CopyOfBoard = getCopyOfBoard(board);
                if(isSpaceFree(CopyOfBoard,index))
                {
                    makeMove(CopyOfBoard, index, letter);
                    if (isWinner(CopyOfBoard, letter))
                        return index;
                }
            }
            return 0;
        }
        /// <summary>
        /// Gets the copy of board.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <returns></returns>
        public static char[]getCopyOfBoard(char[] board)
        {
            char[] boardCopy = new char[10];
            return boardCopy;
        }
        public static int getComputerMove(char[] board, char computerLetter, char userLetter)
        {
            int winningMove = getWinningMove(board, computerLetter);
            if (winningMove != 0)
            return winningMove;
            int userWinningMove = getWinningMove(board, userLetter);
            if (userWinningMove != 0) 
            return userWinningMove;
            int[] cornerMoves = { 1, 3, 7, 9 };
            int computerMove = getRandomMoveFromList(board, cornerMoves);
            if (computerMove != 0)
            return computerMove;
            if (isSpaceFree(board, 5))
                return 5;
            int[] sideMoves = { 2, 4, 6, 8 };
            computerMove = getRandomMoveFromList(board, sideMoves);
            if (computerMove != 0)
                return computerMove;
            return 0;
        }
        /// <summary>
        /// Gets the random move from list.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <param name="moves">The moves.</param>
        /// <returns></returns>
        public static int getRandomMoveFromList(char[] board,int[] moves)
            {
                for(int index=0; index<moves.Length;index++)
                {
                    if (isSpaceFree(board, moves[index]))
                        return moves[index];
                }
                return 0;
            }
        /// <summary>
        /// Gets the game status.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <param name="move">The move.</param>
        /// <param name="letter">The letter.</param>
        /// <param name="WonMessage">The won message.</param>
        /// <returns></returns>
        public static GameStatus getGameStatus(char[] board,int move, char letter, String WonMessage)
        {
            makeMove(board, move, letter);
            if(isWinner(board,letter))
            {
                showBoard(board);
                Console.WriteLine(WonMessage);
                return GameStatus.WON;
            }
            if(isBoardFull(board))
            {
                showBoard(board);
                Console.WriteLine("Game is Tie");
                return GameStatus.FULL_BOARD;
            }
            return GameStatus.CONTINUE;

        }
        /// <summary>
        /// Determines whether [is board full] [the specified board].
        /// </summary>
        /// <param name="board">The board.</param>
        /// <returns>
        ///   <c>true</c> if [is board full] [the specified board]; otherwise, <c>false</c>.
        /// </returns>
        public static bool isBoardFull(char[] board)
        {
            for(int index=1;index<board.Length;index++)
            {
                if (isSpaceFree(board, index))
                return false;
            }
            return true;
        }
    }

 }

