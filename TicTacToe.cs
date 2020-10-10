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
    }
}
