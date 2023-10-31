using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_lab6.Primitives
{
    class Polygon
    {
        public List<Edge> edges { get; set; }

        public Polygon(List<Edge> _edges)
        {
            edges = _edges;
        }
        
        public Dot getCenter()
        {
            float x = 0, y = 0, z = 0;
            foreach (Edge e in edges)
            {
                x += e.end.x;
                y += e.end.y;
                z += e.end.z;
            }
            return new Dot(x / edges.Count, y / edges.Count, z / edges.Count);
        }
    }
}
