using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ShapeType
    {
        public int ID { get; set; }
        public string ShapeName { get; set; }

        public ShapeType(int id, string shapeName)
        {
            ID = id;
            ShapeName = shapeName;
        }
    }
}
