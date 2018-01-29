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
            PrintBoard(board);
            ReadLine();
        }


        public static void PrintBoard(Coordinate[][] board) //finish fixing this
        {
            WriteLine("   0  1  2  3  4  5  6  7  8  9");
            WriteLine("0 [" + board[0][0].GetUnit() + "][" + board[1][0].GetUnit() + "][" + board[2][0].GetUnit() + "][" + board[3][0].GetUnit() + "][" + board[4][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "]");
            WriteLine("1 [" + board[0][1].GetUnit() + "][" + board[1][1].GetUnit() + "][" + board[2][1].GetUnit() + "][" + board[3][1].GetUnit() + "][" + board[4][1].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "]");
            WriteLine("2 [" + board[0][2].GetUnit() + "][" + board[1][2].GetUnit() + "][" + board[2][2].GetUnit() + "][" + board[3][2].GetUnit() + "][" + board[4][2].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "]");
            WriteLine("3 [" + board[0][3].GetUnit() + "][" + board[1][3].GetUnit() + "][" + board[2][3].GetUnit() + "][" + board[3][3].GetUnit() + "][" + board[4][3].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "]");
            WriteLine("4 [" + board[0][4].GetUnit() + "][" + board[1][4].GetUnit() + "][" + board[2][4].GetUnit() + "][" + board[3][4].GetUnit() + "][" + board[4][4].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "]");
            WriteLine("5 [" + board[0][5].GetUnit() + "][" + board[1][5].GetUnit() + "][" + board[2][5].GetUnit() + "][" + board[3][5].GetUnit() + "][" + board[4][5].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "]");
            WriteLine("6 [" + board[0][6].GetUnit() + "][" + board[1][6].GetUnit() + "][" + board[2][6].GetUnit() + "][" + board[3][6].GetUnit() + "][" + board[4][6].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "]");
            WriteLine("7 [" + board[0][7].GetUnit() + "][" + board[1][7].GetUnit() + "][" + board[2][7].GetUnit() + "][" + board[3][7].GetUnit() + "][" + board[4][7].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "]");
            WriteLine("8 [" + board[0][8].GetUnit() + "][" + board[1][8].GetUnit() + "][" + board[2][8].GetUnit() + "][" + board[3][8].GetUnit() + "][" + board[4][8].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "]");
            WriteLine("9 [" + board[0][9].GetUnit() + "][" + board[1][9].GetUnit() + "][" + board[2][9].GetUnit() + "][" + board[3][9].GetUnit() + "][" + board[4][9].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "][" + board[0][0].GetUnit() + "]");
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
                        Console.WriteLine(i + " " + j);
                    }

                    if (j == 2)
                    {
                        board[i][j] = new Coordinate("P");
                    }
                        
                }
            }

            return board;
        }
    }

    public class Coordinate
    {
        private string UnitClass;
        public Coordinate(string input)
        {
            this.UnitClass = input;
        }
        public Coordinate()
        {
            this.UnitClass = "~";
        }

        public String GetUnit()
        {
            return this.UnitClass;
        }
    }
}
