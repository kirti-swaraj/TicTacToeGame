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
    }
}
