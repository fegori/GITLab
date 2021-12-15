using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furnosov
{
    class Program
    {
        static void Main(string[] args)
        {
                float a = float.Parse(Console.ReadLine());
                float b = float.Parse(Console.ReadLine());
                float c = float.Parse(Console.ReadLine());
                SolveQuadratic object1 = new SolveQuadratic();
                List<float> result=object1.solve(a,b,c);
                Console.ReadKey();
        }
        
    }
}