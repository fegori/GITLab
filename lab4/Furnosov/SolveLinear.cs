using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furnosov
{
    class SolveLinear
    {
        protected List<float> X;
        protected List<float> Linear(float a, float b)
        {
            if (a == 0)
            {
                throw new FurnosovException("Определено, что такое уравнение не существует.");
            }
            FurnosovLog.I().log("Определено, что это линейное уравнение.");
            return X = new List<float>() { -b / a };
        }
    }
}
