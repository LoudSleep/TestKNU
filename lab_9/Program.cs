using System;
using static System.Math;

namespace lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n");
            Console.WriteLine("----------------------------------------#1----------------------------------------");
            Console.Write("\n");
            
            Console.Write("Введите x: ");
            double x_test = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y: ");
            double y_test = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");

            double h = Sqrt(Pow(x_test, 2) + Pow(y_test, 2));
            double r = 2;

            if ((x_test >= -2) & (x_test <= 2) & (y_test >= -2) & (y_test <= 2))
            {
                if (r >= h)
                {
                    Console.WriteLine("Точка находиться на полях фигур А и В!");
                }
                else
                {
                    Console.WriteLine("Точка находиться на полях фигуры В!");
                }
            }
            else
            {
                Console.WriteLine("Точка (" + x_test + "," + y_test + ") находиться за полями фигур!");
            }

            Console.Write("\n");
            Console.WriteLine("--------------------------------------TEST№1--------------------------------------");
            Console.Write("\n");

            int[,] num1 = { { 2, 2 }, { 5, 2 }, { 1, 3 }, { 0, 2 }, { 3, 1 }, { 2, 7 }, { 1, 2 }, { 3, 3 } };

            int rows = num1.GetUpperBound(0) + 1;
            int columns = num1.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 0)
                    {
                        if ((num1[i,j] >= -2) & (num1[i, j] <= 2))
                        {
                            if ((num1[i, j+1] >= -2) & (num1[i, j+1] <= 2))
                            {
                                double h_test = Sqrt(Pow(num1[i, j], 2) + Pow(num1[i, j + 1], 2));

                                if (r >= h_test)
                                {
                                    Console.WriteLine("Точка "+ $"({num1[i,j]},{num1[i, j+1]})" + " находиться на полях фигур А и В!");
                                }
                                else
                                {
                                    Console.WriteLine("Точка " + $"({num1[i, j]},{num1[i, j + 1]})" + " находиться на полях фигуры В!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Точка " + $"({num1[i, j]},{num1[i, j + 1]})" + " находиться за полями фигур!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Точка " + $"({num1[i, j]},{num1[i, j + 1]})" + " находиться за полями фигур!");
                        }
                    }
                }
            }
        }
    }
}
