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
            
            
            ReadLine();
        }
        public static string CoordinateState()
        {
            return " ";
        }

        public void PrintBoard()
        {
            WriteLine("   0  1  2  3  4  5  6  7  8  9");
            WriteLine("0 [" + CoordinateState() + "][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            WriteLine("1 [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            WriteLine("2 [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            WriteLine("3 [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            WriteLine("4 [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            WriteLine("5 [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            WriteLine("6 [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            WriteLine("7 [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            WriteLine("8 [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
            WriteLine("9 [ ][ ][ ][ ][ ][ ][ ][ ][ ][ ]");
        }
    }
}
