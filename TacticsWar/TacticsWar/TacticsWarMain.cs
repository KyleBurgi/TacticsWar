using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TacticsWar
{
    class TacticsWarMain
    {
        static void Main(string[] args)
        {
            Coordinate[][] board = MakeBoard();
            PrintOtherBoard(board);
            ReadLine();
        }



        public static void PrintOtherBoard(Coordinate[][] board)
        {
            WriteLine("   0  1  2  3  4  5  6  7  8  9");
            for (int i = 0; i < 10; i++)
            {
                Write(i + " ");

                for (int j = 0; j < 10; j++)
                {
                    Write("[" + board[i][j].GetUnit() + "]");
                }
                WriteLine("");
            }
        }
        public static string CoordinateState(Coordinate Spot)
        {

            return Spot.GetUnit();
        }

        public static Coordinate[][] MakeBoard()
        {
            Coordinate[][] board = new Coordinate[10][];
            for (int i = 0; i < 10; i++)
                board[i] = new Coordinate[10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    board[i][j] = new Coordinate();
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0)
                    {
                        board[i][j] = new Coordinate("W");
                    }

                    if (j == 2)
                    {
                        if (board[i][j].GetUnit() == "~")
                            board[i][j] = new Coordinate("P");
                    }

                }
            }

            return board;
        }
    }
}
