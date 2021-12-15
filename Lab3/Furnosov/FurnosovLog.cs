using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using core;

namespace Furnosov
{
    public class FurnosovLog : LogAbstract, LogInterface
    {
        private FurnosovLog(){}
        private static FurnosovLog source = null;
        private List<string> storage=new List<string>();
        public static FurnosovLog I()
        {
            if (source == null)
                source = new FurnosovLog();

            return source;
        }

        public LogInterface log(string str)
        {
            storage.Add(str);
            return this;
        }

        public LogInterface write()
        {
            writeConsole(storage.ToArray());
            return this;
        }
    }
}
