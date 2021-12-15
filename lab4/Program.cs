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
            Console.WriteLine("Введите 3 параметра a, b и с.");
            //FurnosovLog.I().log("Введите 3 параметра a, b и с.");
            try
            {
                float a = float.Parse(Console.ReadLine());
                float b = float.Parse(Console.ReadLine());
                float c = float.Parse(Console.ReadLine());
                FurnosovLog.I().log($"Введено уравнение: {a}*x^2 + {b}*x + {c} = 0");
                SolveQuadratic object1 = new SolveQuadratic();
                List<float> result=object1.solve(a,b,c);
                FurnosovLog.I().log ("Корни уравнения: "+string.Join("   ", result));
            }
            catch (FurnosovException ex1)
            {
                FurnosovLog.I().log(ex1.Message);
            }
            FurnosovLog.I().write();
            Console.ReadKey();
        }
        
    }
}