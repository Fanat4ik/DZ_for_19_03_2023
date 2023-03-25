// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

//Находит и выводит в консоль номер строки, сумма элементов которой наименьшая
void SmallestSumOfArray2DRowElements(int [,] array2D)
{
        if(array2D == null || array2D.GetLength(0) == 0 || array2D.GetLength(1) == 0)
    {
        Console.WriteLine("Массив пуст!");
        return;
    }
    int sumOfRowElements = 0;
    int temporarySumOfRowElements = 0;
    int numberRowWithSmallestSum = 0;
    for (int i = 0; i < array2D.GetLength(0); i ++)
    {
        for (int j = 0; j < array2D.GetLength(1); j ++)
        {
            sumOfRowElements += array2D[i,j];
        }
        if (i == 0)
        {
            temporarySumOfRowElements = sumOfRowElements;
        }
        if (sumOfRowElements < temporarySumOfRowElements)
        {
            temporarySumOfRowElements = sumOfRowElements;
            numberRowWithSmallestSum = i;
        }
        sumOfRowElements = 0;
    }
    Console.WriteLine($"Номер строки с наименьшей суммой: {numberRowWithSmallestSum}");
}

int rowsArray2D = 3;
int colonsArray2D = 4;

int[,] array2D = new int[rowsArray2D, colonsArray2D];
FillArray2D(array2D);
PrintArray2D(array2D);
SmallestSumOfArray2DRowElements(array2D);
