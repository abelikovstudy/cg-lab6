using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_lab6.Primitives
{
    class Edge
    {
        public Dot start { get; set; }
        public Dot end { get; set; }
        public Edge(Dot _start, Dot _end) 
        {
            start = _start;
            end = _end;
        }
        public override string ToString()
        {
            return string.Concat($"{start} <-> {end}");
        }
    }
}
