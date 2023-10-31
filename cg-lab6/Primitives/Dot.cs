using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using cg_lab6.MathUtils;
using System.Diagnostics;

namespace cg_lab6.Primitives
{
    public enum ProjectionType { Central, Isometric }
    class Dot
    {

        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
        public Dot(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        public override string ToString()
        {
            return string.Concat($"({x} {y} {z})");
        }
        public PointF getProjection(ProjectionType projection) 
        {

            if (projection == ProjectionType.Central)
            {

                MatrixUtils m1 = new MatrixUtils(4, 4, 
                    1, 0, 0, 0, 
                    0, 1, 0, 0,
                    0, 0, 1, 1,
                    0, 0, 0, 1);
                MatrixUtils m2 = new MatrixUtils(4, 1, x , y, z , 1.0);
                MatrixUtils res = (m1 * m2);
                Debug.WriteLine(res);
                return new PointF(Constants.WORLD_X + (float)((float)res.matrix[0, 0] / (float)res.matrix[2,0]), Constants.WORLD_Y + (float)((float)res.matrix[1, 0] / (float)res.matrix[2, 0]));
            }
            else 
            {
                double sqrt3 = Math.Sqrt(3);
                double sqrt2 = Math.Sqrt(2);
                double sqrt6 = Math.Sqrt(6);
                MatrixUtils m1 = new MatrixUtils(3,3,
                    sqrt3,0,-sqrt3,
                    1,2,1,
                    sqrt2,-sqrt2,sqrt2);
                MatrixUtils m2 = new MatrixUtils(3,1,x, -y, z); //y z x
                MatrixUtils m3 = new MatrixUtils(3, 3, 1,0,0,0,1,0,0,0,0);
                MatrixUtils res = m3 * (m1 * m2);
                return new PointF(Constants.WORLD_X + (float)(res.matrix[0,0] / sqrt6), Constants.WORLD_Y + (float)(res.matrix[1, 0] / sqrt6));
            }
        }

    }
}
