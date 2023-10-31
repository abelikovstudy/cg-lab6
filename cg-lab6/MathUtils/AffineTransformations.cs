using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using cg_lab6.Primitives;
namespace cg_lab6.MathUtils
{
    static class AffineTransformations
    {
        private static double radians(double angle)
        {
            return Math.PI * angle / 180.0;
        }
        public static List<Dot> rotate(List<Dot> dots, double angle, Constants.Axis axis) 
        {
            double rads = radians(angle);
            List<Dot> result = new List<Dot>();
            MatrixUtils rotation;
            switch (axis) 
            {
                
                case Constants.Axis.X:
                    rotation = new MatrixUtils(4,4,1,0,0,0,0,Math.Cos(rads), Math.Sin(rads), 0, 0, -Math.Sin(rads), Math.Cos(rads),0,0,0,0,1);
                    break;

                case Constants.Axis.Y:
                    rotation = new MatrixUtils(4, 4, Math.Cos(rads), 0 , -Math.Sin(rads),0, 0, 1, 0, 0, Math.Sin(rads), 0, Math.Cos(rads), 0, 0, 0, 0, 1);
                    break;

                case Constants.Axis.Z:
                    rotation = new MatrixUtils(4, 4, Math.Cos(rads), Math.Sin(rads), 0, 0, -Math.Sin(rads), Math.Cos(rads), 0, 0, 0, 0, 1, 0, 0, 0,0 ,1);
                    break;

                default:
                    rotation = new MatrixUtils(4, 4, 1, 0, 0, 0, 0, Math.Cos(angle), Math.Sin(angle), 0, 0, -Math.Sin(angle), Math.Cos(angle), 0, 0, 0, 0, 1);
                    break;
            }

            foreach (Dot dot in dots) 
            {
                MatrixUtils resulting = rotation * new MatrixUtils(4, 1, dot.x, dot.y, dot.z, 1);
                result.Add(new Dot((float)resulting.matrix[0,0], (float)resulting.matrix[1, 0], (float)resulting.matrix[2, 0]));
            }
            return result;
        }

        public static List<Dot> shift(List<Dot> dots, double dx, double dy, double dz) 
        {
            List<Dot> result = new List<Dot>();
            MatrixUtils rotation = new MatrixUtils(4, 4, 1, 0, 0, dx, 0, 1, 0, dy, 0, 0, 1, dz, 0, 0, 0, 1);

            foreach (Dot dot in dots)
            {
                MatrixUtils resulting = rotation * new MatrixUtils(4, 1, dot.x, dot.y, dot.z, 1);
                result.Add(new Dot((float)resulting.matrix[0, 0], (float)resulting.matrix[1, 0], (float)resulting.matrix[2, 0]));
            }
            return result;
        }

        public static List<Dot> scale(List<Dot> dots, double dx, double dy, double dz)
        {
            List<Dot> result = new List<Dot>();
            MatrixUtils rotation = new MatrixUtils(4, 4, dx, 0, 0, 0, 0, dy, 0, 0, 0, 0, dz, 0, 0, 0, 0, 1);

            foreach (Dot dot in dots)
            {
                MatrixUtils resulting = rotation * new MatrixUtils(4, 1, dot.x, dot.y, dot.z, 1);
                result.Add(new Dot((float)resulting.matrix[0, 0], (float)resulting.matrix[1, 0], (float)resulting.matrix[2, 0]));
            }
            return result;
        }

        
    }
}
