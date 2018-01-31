using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacticsWar
{
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
