using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /* 
     * Basic Abstract Shape class.
     * Used as an interface for child shapes.
     */
    public abstract class Shape
    {
        private ShapeType shape { get; set; }

        public Shape(ShapeType shape)
        {
            this.shape = shape;
        }

        public abstract double Square();

        public string GetShapeTypeInfo()
        {
            return $"Current shape: " + shape.ShapeName + "\n" + "ID current shape: " + shape.ID;
        }
    }
}
