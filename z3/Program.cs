/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int [,] Create2dArray (int row, int column, int minV, int maxV)
{
    int [,] created2dArray = new int [row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            created2dArray [i, j] = new Random().Next(minV, maxV);
        }
    }
    return created2dArray;
}

void Show2dArray (int [,] array)
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

void FindAvgColumn (int [,] array, int row, int column)
{
    double [] avg = new double [column];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array [i, j];
        }
    avg [j] = Math.Round ((sum / row), 2);
    Console.Write(avg [j] + " ");
    }
}

Console.Write ("Input count of rows: ");
int rows = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Input count of columns: ");
int columns = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Input min possible value: ");
int minVal = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Input max possible value: ");
int maxVal = Convert.ToInt32 (Console.ReadLine ());

int [,] createdArray = Create2dArray (rows, columns, minVal, maxVal);
Show2dArray (createdArray);
FindAvgColumn (createdArray, rows, columns);