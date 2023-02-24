/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double [,] Create2dArray (int row, int column, int minV, int maxV)
{
    double [,] created2dArray = new double [row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            created2dArray [i, j] = Math.Round((new Random().Next(minV, maxV)) + (new Random().NextDouble()), 2);
        }
    }
    return created2dArray;
}

void Show2dArray (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write ("Input count of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Input count of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Input min possible value: ");
int minVal = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Input max possible value: ");
int maxVal = Convert.ToInt32 (Console.ReadLine ());

double [,] createdArray = Create2dArray (rows, columns, minVal, maxVal);
Show2dArray (createdArray);