using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Generics_For_Buoyant_Force_Calculation
{
    class Generics
    {
        static void Main(string[] args)
        {
            InterfaceFormula<double> myGen1 = new InterfaceFormula<double>();
            myGen1.Calc();
            Console.Read();
        }
    }
}
