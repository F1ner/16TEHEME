using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aababiy18_3
{
    internal class Program
    {
        static List<Figure> figures = new List<Figure>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Добавить фигуру");
                Console.WriteLine("2. Вывести все фигуры");
                Console.WriteLine("3. Вывести свойства всех фигур");
                Console.WriteLine("4. Редактировать свойство фигуры");
                Console.WriteLine("5. Удалить фигуру");
                Console.WriteLine("6. Вызвать метод фигуры");
                Console.WriteLine("0. Выход");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1. Прямоугольник"); // Rectangle
                        Console.WriteLine("2. Квадрат"); // Square
                        Console.WriteLine("3. Треугольник"); // Triangle
                        Console.WriteLine("4. Круг"); // Circle

                        int figureChoice = Convert.ToInt32(Console.ReadLine());

                        switch (figureChoice)
                        {
                            case 1:
                                Console.Write("Enter name: ");
                                string name = Console.ReadLine();
                                Console.Write("Enter side1: ");
                                double side1 = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Enter side2: ");
                                double side2 = Convert.ToDouble(Console.ReadLine());

                                figures.Add(new Rectangle(name, side1, side2));
                                break;

                            case 2:
                                Console.Write("Enter name: ");
                                string squareName = Console.ReadLine();
                                Console.Write("Enter side: ");
                                double squareSide = Convert.ToDouble(Console.ReadLine());

                                figures.Add(new Square(squareName, squareSide));
                                break;

                            case 3:
                                Console.Write("Enter name: ");
                                string triangleName = Console.ReadLine();
                                Console.Write("Enter side1: ");
                                double triangleSide1 = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Enter side2: ");
                                double triangleSide2 = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Enter side3: ");
                                double triangleSide3 = Convert.ToDouble(Console.ReadLine());

                                figures.Add(new Triangle(triangleName, triangleSide1, triangleSide2, triangleSide3));
                                break;

                            case 4:
                                Console.Write("Enter name: ");
                                string circleName = Console.ReadLine();
                                Console.Write("Enter radius: ");
                                double circleRadius = Convert.ToDouble(Console.ReadLine());

                                figures.Add(new Circle(circleName, circleRadius));
                                break;
                        }
                        break;

                    case 2:
                        foreach (Figure figure in figures)
                        {
                            figure.Print();
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        Console.Write("Enter name of the figure: ");
                        string nameToFind = Console.ReadLine();
                        Figure figureToFind = figures.Find(figure => figure.Name == nameToFind);

                        if (figureToFind != null)
                        {
                            figureToFind.Print();
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Figure not found.");
                        }
                        break;

                    case 4:
                        Console.Write("Enter name of the figure: ");
                        string nameToEdit = Console.ReadLine();
                        Figure figureToEdit = figures.Find(figure => figure.Name == nameToEdit);

                        if (figureToEdit != null)
                        {
                            Type type = figureToEdit.GetType();
                            Console.Write("Enter new value for " + type.Name + ": ");
                            object newValue = Convert.ChangeType(Console.ReadLine(), type);
                            type.GetProperty("Radius")?.SetValue(figureToEdit, newValue);
                            type.GetProperty("Side1")?.SetValue(figureToEdit, newValue);
                            type.GetProperty("Side2")?.SetValue(figureToEdit, newValue);
                            type.GetProperty("Side3")?.SetValue(figureToEdit, newValue);
                        }
                        else
                        {
                            Console.WriteLine("Figure not found.");
                        }
                        break;

                    case 5:
                        Console.Write("Enter name of the figure: ");
                        string nameToRemove = Console.ReadLine();
                        Figure figureToRemove = figures.Find(figure => figure.Name == nameToRemove);

                        if (figureToRemove != null)
                        {
                            figures.Remove(figureToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Figure not found.");
                        }
                        break;

                    case 6:
                        Console.Write("Enter name of the figure: ");
                        string nameToCall = Console.ReadLine();
                        Figure figureToCall = figures.Find(figure => figure.Name == nameToCall);

                        if (figureToCall != null)
                        {
                            Console.WriteLine($"Area: {figureToCall.Area()}, Perimeter: {figureToCall.Perimeter()}");
                        }
                        else
                        {
                            Console.WriteLine("Figure not found.");
                        }
                        break;
                }
            }
        }
    }
}


