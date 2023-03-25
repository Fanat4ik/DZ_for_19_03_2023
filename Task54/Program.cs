// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//заполнение массива случайными int до 10
void FillArray2D(int [,] array2D)
{
    Random random = new Random();

    for (int i = 0; i < array2D.GetLength(0); i ++)
    {
        for (int j = 0; j < array2D.GetLength(1); j ++)
        {
            array2D[i, j] = random.Next(10);
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
}

//упорядочит по убыванию элементы каждой строки двумерного массива
void SortValuesOfArray2DRowElementsInDescendingOrder(int [,] array2D)
{
        if(array2D == null || array2D.GetLength(0) == 0 || array2D.GetLength(1) == 0)
    {
        Console.WriteLine("Массив пуст!");
        return;
    }
    int tempValue = 0;
    for (int i = 0; i < array2D.GetLength(0); i ++)
    {
        for (int j = 0; j+1 < array2D.GetLength(1); j ++)
        {
            if(array2D[i, j] < array2D[i, j+1])
            {
                tempValue = array2D[i, j];
                array2D[i, j] = array2D[i, j+1];
                array2D[i, j+1] = tempValue;
                SortValuesOfArray2DRowElementsInDescendingOrder(array2D);
                // используем рекурсию  с условием выхода if
            }
        }
    }
}

int rowsArray2D = 3;
int colonsArray2D = 4;

int[,] array2D = new int[rowsArray2D, colonsArray2D];
FillArray2D(array2D);
PrintArray2D(array2D);
SortValuesOfArray2DRowElementsInDescendingOrder(array2D);
Console.WriteLine("Строки массива отсортированы");
PrintArray2D(array2D);