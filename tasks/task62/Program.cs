/*Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7  */

int n = 4;  //кол-во строк и стобцов
int num = 1;  //первое число массива

int[,] FillArray(int n, int num)
{
    int[,] result = new int[n, n];
    int row = result.GetLength(0);
    int col = result.GetLength(1);
    int count = 0; 
    while (num <= n * n)
    {
        for (col = count; col < n - count; col++)  
        {
            result[count, col] = num++;
        }
        for (row = count+1; row < n - count; row++)  
        {
            result[row, n - count - 1] = num++;
        }
        for (col = n - count - 2; col > count; col--) 
        {
            result[n - count - 1, col] = num++;
        }
        for (row = n - count - 1; row > count; row--)  
        {
            result[row,count] = num++;
        }
        count++;
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

int[,] arrayResult = FillArray(n, num);
ShowArray(arrayResult);