// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//заполнение массива случайными int от 1 до 5
void FillArray2D(int [,] array2D)
{
    Random random = new Random();

    for (int i = 0; i < array2D.GetLength(0); i ++)
    {
        for (int j = 0; j < array2D.GetLength(1); j ++)
        {
            array2D[i, j] = random.Next(1,6);
        }
    }
}

//печать массива в консоль
void PrintArray2D(int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i ++)
    {
        for (int j = 0; j < array2D.GetLength(1); j ++)
        {
            System.Console.Write(array2D[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

// умножение двух матриц
void MultiplicationOfTwoMatrices(int [,] array2DFirst, int [,] array2DSecond, int [,] array2DResult)
{
        if(array2DFirst == null || 
        array2DFirst.GetLength(0) == 0 || 
        array2DFirst.GetLength(1) == 0 ||
        array2DSecond  == null || 
        array2DSecond .GetLength(0) == 0 || 
        array2DSecond .GetLength(1) == 0)
    {
        Console.WriteLine("Массив пуст!");
        return;
    }
    for (int i = 0; i < array2DFirst.GetLength(0); i ++)
    {
        for (int j = 0; j < array2DFirst.GetLength(1); j ++)
        {
            for (int k = 0; k < array2DFirst.GetLength(1); k++)
            {
                array2DResult[i,j] += array2DFirst[i,k] * array2DSecond[k,j];
            }       
        }
    }
}

int rowsArray2DFirst = 2;
int colArray2DFirst = 2;
int rowsArray2DSecond = 2;
int colArray2DSecond = 2;


int[,] array2DFirst = new int[rowsArray2DFirst, colArray2DFirst];
int[,] array2DSecond = new int[rowsArray2DSecond, colArray2DSecond];
FillArray2D(array2DFirst);
PrintArray2D(array2DFirst);
FillArray2D(array2DSecond);
PrintArray2D(array2DSecond);
int[,] array2DResult = new int[rowsArray2DSecond, colArray2DSecond];
MultiplicationOfTwoMatrices(array2DFirst, array2DSecond, array2DResult);
PrintArray2D(array2DResult);
