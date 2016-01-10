using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    class OperatorOverloading
    {
        public static char operator +(OperatorOverloading a, OperatorOverloading b) { return 'a'; }
        public static char operator -(OperatorOverloading a, OperatorOverloading b) { return 'a'; }
        public static char operator *(OperatorOverloading a, OperatorOverloading b) { return 'a'; }
        public static char operator /(OperatorOverloading a, OperatorOverloading b) { return 'a'; }
    }
}
