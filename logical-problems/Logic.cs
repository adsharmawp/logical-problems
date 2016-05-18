using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_problems
{
    public abstract class Logic
    {
        public string InputString { get; set; }
        public string OutputString { get; set; }

        public abstract string Run(string input);
    }
}
