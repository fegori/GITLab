using System;
using System.Collections.Generic;

namespace Lab2
{
    class Program
    {
        class A
        {
           protected List<double> X;
           protected List<double> Linear(double a, double b)
           {
                if (a == 0)
                {
                    throw new Exception("НЕ УРАВНЕНИЕ");
                }
                return X =  new List<double>() { -b / a }; 
           }
        }
        class B : A
        {
            protected double Discriminant(double a, double b, double c )
            {
                return b * b - 4 * c * a;
            }
            List<double> Quadratic(double a, double b,double c)
            {
                if (a == 0)
                {
                    return Linear(b, c);
                }
                double discriminant = Discriminant(a, b, c);
                if (discriminant < 0)
                {
                    throw new Exception("Нет решения, т.к. дискриминант равен 0");
                }
                if (discriminant == 0)
                {
                    return X = new List<double>() { -b / 2 / a }; 
                }
                double sqrtDiscriminant = Math.Sqrt(discriminant);
                return new List<double> {(-b - sqrtDiscriminant) / 2 / a, (-b + sqrtDiscriminant) / 2 / a };
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
