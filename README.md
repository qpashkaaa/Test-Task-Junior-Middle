# Что это?
  **Тестовое задание Junior/Middle C#**
  >*Заданание состоит из 2-ух частей. 1 часть - понимание и знание принципов ООП в языке программирования C#, 2 часть - знание принципов работы MS SQL Server, и умение реализовывать составные SQL-запросы.*

## Задание 1
*Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:*
- *Юнит-тесты*
```C#
[TestFixture]
public class CircleTests
{

    [Test]
    public void Square_Radius8_Return201_06()
    {
        // Arrange
        double radius = 8;
        double expected = 201.06;

        // Act
        Shape circle = new Circle(radius);
        double actual = circle.Square();

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void IsExists_Radius0_ReturnException()
    {
        // Arrange
        double radius = 0;

        // Assert
        Assert.That(() => new Circle(radius), Throws.Exception);
    }
}
```
- *Легкость добавления других фигур*
```C#
/* 
 * Static Class ShapeTypes it is necessary to store information about all the figures in the dll.
 * To add a shape, you need to add the necessary information about the shape to this class and create its class in the Shapes folder.
 */
public static class ShapesTypes
{
    public static ShapeType CIRCLE = new ShapeType(1, "Круг");
    public static ShapeType TRIANGLE = new ShapeType(2, "Треугольник");
}
```
- *Вычисление площади фигуры без знания типа фигуры в compile-time*
```C#
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
```
- *Проверку на то, является ли треугольник прямоугольным*
```C#
public bool TriangleIsRectangular()
{
    // Triangle rectangular if c^2 = a^2 + b^2
    bool isRectangular = (AB == Math.Sqrt(Math.Pow(BC, 2) + Math.Pow(AC, 2)) || 
                          BC == Math.Sqrt(Math.Pow(AB, 2) + Math.Pow(AC, 2)) ||
                          AC == Math.Sqrt(Math.Pow(AB, 2) + Math.Pow(BC, 2)));
    return isRectangular;
}
```

### Скриншоты
_____
![1](https://github.com/qpashkaaa/Test-Task-Junior-Middle/assets/95401099/aeb9be93-7f25-424c-ac6e-cfde7c861b43)

_____
![2](https://github.com/qpashkaaa/Test-Task-Junior-Middle/assets/95401099/477ce4dd-576d-49ac-a220-21860c4c72b2)

_____
![3](https://github.com/qpashkaaa/Test-Task-Junior-Middle/assets/95401099/842a61cf-3bb3-4e8b-a650-db13e243dc2b)
_____

## Задание 2
*В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.*  
- *Ответ на задание:*
```SQL
SELECT p.product, c.category FROM Products p
	LEFT JOIN Products_Categories pc ON pc.product_id = p.id
	LEFT JOIN Categories c ON pc.category_id = c.id;
```
>*Полный ответ на данное задание находится в корне репозитория в файле Task2SQLQuery.sql*

### Скриншоты
_____
![4](https://github.com/qpashkaaa/Test-Task-Junior-Middle/assets/95401099/d5225a08-1c01-45a4-901a-5f1ee6a5d35b)
_____
![5](https://github.com/qpashkaaa/Test-Task-Junior-Middle/assets/95401099/55a2eda8-1466-493c-8a7f-e4e1916d97f1)
_____
![6](https://github.com/qpashkaaa/Test-Task-Junior-Middle/assets/95401099/c0e7d68a-3579-44f8-ae98-4512c32c624f)
_____
![7](https://github.com/qpashkaaa/Test-Task-Junior-Middle/assets/95401099/675d860e-3b3c-453d-a721-966d7ba0d802)
_____


## Технологический стек
- **С#**
- **MS SQL Server**

## Автор
- [Pavel Roslyakov](https://github.com/qpashkaaa)

## Контакты
- [Portfolio Website](https://portfolio-website-qpashkaaa.vercel.app/)
- [Telegram](https://t.me/qpashkaaa)
- [VK](https://vk.com/qpashkaaa)
- [LinkedIN](https://www.linkedin.com/in/pavel-roslyakov-7b303928b/)

## Год разработки
> *2023*
  
