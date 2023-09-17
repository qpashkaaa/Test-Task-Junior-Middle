using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Exceptions;

namespace Task1.Shapes
{
    public class Triangle : Shape
    {
        private double AB;
        private double BC;
        private double AC;

        /* 
         * The base class is Shape. Allows you to determine the type of shape and display information about it.
         * All shape types are stored in ShapesTypes.
        */
        public Triangle(double ab, double bc, double ac) : base(ShapesTypes.TRIANGLE)
        {
            // Checking the existence of a triangle
            if (IsExists(ab, bc, ac))
            {
                AB = ab;
                BC = bc;
                AC = ac;
            }
        }

        public override double Square()
        {
            double P = (AB + BC + AC) / 2;
            double square = Math.Sqrt(P * (P - AB) * (P - BC) * (P - AC));
            return Math.Round(square, 2);
        }

        public bool TriangleIsRectangular()
        {
            // Triangle rectangular if c^2 = a^2 + b^2
            bool isRectangular = (AB == Math.Sqrt(Math.Pow(BC, 2) + Math.Pow(AC, 2)) || 
                                  BC == Math.Sqrt(Math.Pow(AB, 2) + Math.Pow(AC, 2)) ||
                                  AC == Math.Sqrt(Math.Pow(AB, 2) + Math.Pow(BC, 2)));
            return isRectangular;
        }

        private bool IsExists(double ab, double bc, double ac)
        {
            if (ab < 0 || bc < 0 || ac < 0)
            {
                throw new ShapeException("There is no such triangle, because the side(s) is less than 0.");
            }
            if (ab > (bc + ac) || bc > (ab + ac) || ac > (ab + bc))
            {
                throw new ShapeException("There is no such triangle, because one of the sides is greater than the sum of the other two.");
            }
            return true;
        }
    }
}
