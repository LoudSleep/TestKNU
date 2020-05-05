using System;
using static System.Math;

namespace lab_9_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n");
            Console.WriteLine("----------------------------------------#2----------------------------------------");
            Console.Write("\n");

            Console.Write("Введите x: ");
            double x_test = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y: ");
            double y_test = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");

            double r = 1;
            double h1 = Sqrt(Pow(x_test - (-1), 2) + Pow(y_test - 1, 2));
            double h2 = Sqrt(Pow(x_test - 1, 2) + Pow(y_test - (-1), 2));

            if ((x_test >= -2) & (x_test <= 0) & (y_test >= 0) & (y_test <= 2) & (r >= h1))
            {
                Console.WriteLine("Точка (" + x_test +","+ y_test+ ") находиться на полях фигуры А!");
            }
            else if ((x_test >= 0) & (x_test <= 2) & (y_test >= -2) & (y_test <= 0) & (r >= h2))
            {
                Console.WriteLine("Точка (" + x_test + "," + y_test + ") находиться на полях фигуры B!");
            }
            else
            {
                Console.WriteLine("Точка (" + x_test + "," + y_test + ") находиться за полями фигур А и B!");
            }

            Console.Write("\n");
            Console.WriteLine("--------------------------------------TEST№2--------------------------------------");
            Console.Write("\n");
            
            int[,] num2 = { { 3, 1 }, { 3, 3 }, { 3, 2 }, { 1, 3 }, { 2, 1 }, { 2, 2 }, { 4, 0 }, { 3, 0 } };

            int rows = num2.GetUpperBound(0) + 1;
            int columns = num2.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 0)
                    {
                        double h1_test = Sqrt(Pow(num2[i, j] - (-1), 2) + Pow(num2[i, j + 1] - 1, 2));
                        double h2_test = Sqrt(Pow(num2[i, j] - 1, 2) + Pow(num2[i, j + 1] - (-1), 2));

                        if ((num2[i,j] >= -2) & (num2[i, j] <= 0) & (num2[i, j+1] >= 0) & (num2[i, j + 1] <= 2) & (r >= h1_test))
                        {
                            Console.WriteLine("Точка " + $"({num2[i, j]},{num2[i, j + 1]})" + " находиться на полях фигуры А!");
                        }
                        else if ((num2[i, j] >= 0) & (num2[i, j] <= 2) & (num2[i, j + 1] >= -2) & (num2[i, j + 1] <= 0) & (r >= h2_test))
                        {
                            Console.WriteLine("Точка " + $"({num2[i, j]},{num2[i, j + 1]})" + " находиться на полях фигуры B!");
                        }
                        else
                        {
                            Console.WriteLine("Точка "+ $"({num2[i, j]},{num2[i, j + 1]})" + " находиться за полями фигур А и B!");
                        }
                    }
                }
            }

        }
    }
}
