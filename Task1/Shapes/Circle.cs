using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Exceptions;

namespace Task1.Shapes
{
    public class Circle : Shape
    {
        private double Radius;

        /* 
         * The base class is Shape. Allows you to determine the type of shape and display information about it.
         * All shape types are stored in ShapesTypes.
        */
        public Circle(double radius) : base(ShapesTypes.CIRCLE)
        {
            if (IsExists(radius))
            {
                Radius = radius;
            }
        }
        
        public override double Square()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }

        private bool IsExists(double radius)
        {
            if (radius <= 0)
            {
                throw new ShapeException("There is no such circle, because the radius is less than or equal to 0");
            }
            return true;
        }
    }
}
