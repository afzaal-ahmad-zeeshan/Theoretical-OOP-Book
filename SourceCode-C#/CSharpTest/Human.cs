using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    class Human
    {
        public const string ScientificName = "Homo sapiens";
        public double Height { get; set; }
        public double Temperature { get; set; }
    }

    class Male : Human
    {
        public int GamesPerWeek { get; set; }
        private int Salary { get; set; }
    }

    class Female : Human
    {
        public int MarketRoundsPerWeek { get; set; }
        private int Age { get; set; }
    }
}
