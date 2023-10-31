using cg_lab6.Figures;
using cg_lab6.MathUtils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_lab6.Primitives
{
    class Polyhedron
    {
        public List<Polygon> polys { get; set; }
        public List<Dot> dots { get; set; }
        public Polyhedron(List<Polygon> _polys)
        {
            polys = _polys;

        }

        public void transform() 
        {

            switch (dots.Count) 
            {
                case 4:
                    polys = Tetrahedron.getPolys(dots);
                    break;
                case 6:
                    polys = Octahedron.getPolys(dots);
                    break;
                case 8:
                    polys = Hexahedron.getPolys(dots);
                    break;
                default:    
                    throw new InvalidOperationException("Несоответствующее число точек!");
            }
        }

        public Dot getCenter() 
        {
            float x = 0f, y = 0f, z = 0f;
            foreach (Polygon p in polys)
            {
                x += p.getCenter().x;
                y += p.getCenter().y;
                z += p.getCenter().z;
            }

            return new Dot(x / polys.Count, y / polys.Count, z / polys.Count);
        }


        public void addEdge(Polygon poly)
        {
            polys.Add(poly);
        }


    }


}
