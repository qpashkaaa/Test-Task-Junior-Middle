using static System.Formats.Asn1.AsnWriter;

namespace Task1
{
    /* 
     * Static Class ShapeTypes it is necessary to store information about all the figures in the dll.
     * To add a shape, you need to add the necessary information about the shape to this class and create its class in the Shapes folder.
     */
    public static class ShapesTypes
    {
        public static ShapeType CIRCLE = new ShapeType(1, "Круг");
        public static ShapeType TRIANGLE = new ShapeType(2, "Треугольник");
    }
}