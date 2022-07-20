/*
 Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/

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

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = FillArray(row, column);
int[,] secondArray = FillArray(row, column);
Console.WriteLine("Первый массив:");
ShowArray(firstArray);
Console.WriteLine("Второй массив:");
ShowArray(secondArray);

int [,] arrayMultiplication(int[,] firstArr, int[,] secondArr)
{
    int[,] result = new int[firstArr.GetLength(0), secondArr.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = firstArr[i, j] * secondArr[i, j]; 
        }
    }
    return result;
}

int [,]resultArray= arrayMultiplication(firstArray,secondArray);
Console.WriteLine("Их произведение будет равно следующему массиву:");
ShowArray(resultArray);