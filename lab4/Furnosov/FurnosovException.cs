using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furnosov
{
    class FurnosovException : Exception
    {
        public FurnosovException(string message) : base(message) { }
    }
}
