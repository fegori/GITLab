using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using core;

namespace Furnosov
{
    class SolveQuadratic : SolveLinear, EquationInterface
    {

        protected double Discriminant(float a, float b, float c)
        {
            return Convert.ToDouble(b * b - 4 * c * a);
        }
        public List<float> solve(float a, float b, float c)
        {
            if (a == 0)
            {
                return Linear(b, c);
            }
            double discriminant = Discriminant(a, b, c);
            FurnosovLog.I().log("Определено, что это квадратное уравнение.");
            if (discriminant < 0)
            {
                throw new FurnosovException("Ошибка: уравнение не имеет решений.");
            }

            if (discriminant == 0)
            {
                return X = new List<float>() { -b / 2 / a };
            }
            float sqrtDiscriminant = (float)Math.Sqrt(discriminant);
            return new List<float> { (-b - sqrtDiscriminant) / 2 / a, (-b + sqrtDiscriminant) / 2 / a };
        }
    }
}
