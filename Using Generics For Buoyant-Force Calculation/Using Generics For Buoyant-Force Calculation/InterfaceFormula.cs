using System;
using System.Collections.Generic;
using System.Text;

namespace Using_Generics_For_Buoyant_Force_Calculation
{
    class InterfaceFormula<T> : GenericInterface<T>
    {
        private double D; //Density
        private double V; //Volume
        private double G; //Gravity
        private double F; //Buoyant-Force
        public void Calc()
        {
            Console.WriteLine("Please Enter the Volume : ");
            double V = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Density : ");
            double D = Double.Parse(Console.ReadLine());
            G = 9.81;
            F = (D*Math.Pow(10,-3)) * V * G;
            Console.WriteLine("Buoyant-Force equal by : {0} N", F);
        }
    }
}
