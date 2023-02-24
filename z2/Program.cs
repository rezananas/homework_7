/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

int [,] FindElement (int [,] array, int row, int column)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == row && j == column)
            {
                Console.WriteLine ($"Element on position ({row},{column}) is {array [i, j]}");
            }
        }
    }
    if (row > array.GetLength(0) || column > array.GetLength(1))
    {
        Console.WriteLine ($"There is no elements on position ({row},{column})");
    }
    return array;
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

Console.Write ("Input row position of element: ");
int rowEl = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Input column position of element: ");
int columnEl = Convert.ToInt32 (Console.ReadLine ());

FindElement (createdArray, rowEl, columnEl);