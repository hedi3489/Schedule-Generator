using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Generator
{
    internal class Duration
    {
        public int beginning;
        public int end;

        public Duration(int beginning, int end)
        {
            this.beginning = beginning;
            this.end = end;
        }
    }
}
