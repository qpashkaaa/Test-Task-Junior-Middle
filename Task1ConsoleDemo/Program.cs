using Task1.Shapes;

namespace Task1
{
    public class Program
    {
        static void Main() 
        {
            /* 
             * Демонстрация п. 3 - вычисление площади фигуры без знания типа фигуры в compile-time. 
             * Мы определяем абстрактный класс-интерфейс, у которого есть метод рассчета площади.
             * После, без знания типа фигуры, мы можем рассчитать площадь(создав экземпляр класса Shape).
             */
            Shape circle = new Circle(13);
            /*
             * Так же мы можем в качестве типа у triangle указать Shape, что тоже будет являться демонстрацией п.3.
             * Но, т.к. далее нам необходимо обратиться к методу, который определен только в классе Triangle, соответственно приходится указывать явно.
             */
            Triangle triangle = new Triangle(14, 17, 11);

            // Circle full info
            Console.WriteLine(circle.GetShapeTypeInfo());
            Console.WriteLine($"The area of this figure: " + circle.Square().ToString());
            Console.WriteLine("\n\n");

            // Triangle full info
            Console.WriteLine(triangle.GetShapeTypeInfo());
            Console.WriteLine($"The area of this figure: " + triangle.Square().ToString());
            if (triangle.TriangleIsRectangular())
            {
                Console.WriteLine($"This triangle is rectangular");
            }
            else
            {
                Console.WriteLine($"This triangle is not rectangular");
            }
            Console.ReadLine();
        }
    }
}
