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
    using System.Text;

  /// <summary>
  /// Creating a class
  /// </summary>
    public class TicTacToe
    {
        public const int HEAD = 0;
        public const int TAIL = 1;
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
            string userLetter = Console.ReadLine();
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
    }
}
