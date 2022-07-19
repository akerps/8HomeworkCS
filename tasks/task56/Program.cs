/*  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка*/

int[,] FillArray(int rowNumber, int colNumber)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void ShowArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j]);
            if (j < arrayToPrint.GetLength(1) - 1)
            {
                Console.Write("\t");
            }
        }
        Console.WriteLine();
    }
}

int rowMin(int[,] array)
{
    int indexMinRow = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRowElem = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRowElem += array[i, j];
        }
        if (i == 0)
        {
            result = sumRowElem;
        }
        if (sumRowElem < result)
        {
            result = sumRowElem;
            indexMinRow = i;
        }
    }
    return indexMinRow;
}

int[,] array = FillArray(5, 5);
ShowArray(array);

int numRow = rowMin(array);

Console.WriteLine($"{numRow + 1} строка с наименьшей суммой  элементов");
