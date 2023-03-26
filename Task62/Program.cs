// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//заполнение массива -1
void FillArray2DBuffer(int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i ++)
    {
        for (int j = 0; j < array2D.GetLength(1); j ++)
        {
            array2D[i, j] = -1;
        }
    }
}

//заполнение массива по спирали
void FillSpiralArray2D(int[,] array2D, int row, int col, int spiralValue)
{
    array2D[row, col] = spiralValue;
        
    if(row == 0 && col < array2D.GetLength(1)-1)
    {
        spiralValue++;
        FillSpiralArray2D(array2D, row, col+1, spiralValue);
    }
    else if(col+1 == array2D.GetLength(1) && row+1 < array2D.GetLength(0))
    {
        row++;
        spiralValue++;
        FillSpiralArray2D(array2D, row, col, spiralValue);
    }
    else if(col > 0 && row+1 == array2D.GetLength(0))
    {
        col--;
        spiralValue++;
        FillSpiralArray2D(array2D, row, col, spiralValue);
    }
    else if(col == 0 && row+1 <= array2D.GetLength(0) && row-1 > 0)
    {
        row--;
        spiralValue++;
        FillSpiralArray2D(array2D, row, col, spiralValue);
    }
    else
    {
        if(array2D[row, col+1] == -1)
        {
            col++;
            spiralValue++;
            FillSpiralArray2D(array2D, row, col, spiralValue);
        }
        else if (array2D[row+1, col] == -1)
        {
            row++;
            spiralValue++;
            FillSpiralArray2D(array2D, row, col, spiralValue);
        }
        else if (array2D[row, col-1] == -1)
        {
            col--;
            spiralValue++;
            FillSpiralArray2D(array2D, row, col, spiralValue);
        }
        else if (array2D[row-1, col] == -1)
        {
            row--;
            spiralValue++;
            FillSpiralArray2D(array2D, row, col, spiralValue);
        }
    }
}


//печать массива в консоль
void PrintArray2D(int [,] array2D)
{
    System.Console.WriteLine("печатаем массив");
    for (int i = 0; i < array2D.GetLength(0); i ++)
    {
        for (int j = 0; j < array2D.GetLength(1); j ++)
        {
            if (array2D[i, j] < 10)
            {
                System.Console.Write("0"+ array2D[i, j] + " ");
            }
            else
            {
                System.Console.Write(array2D[i, j] + " ");
            }
        }
        System.Console.WriteLine();
    }
}


int rowsArray2D = 4;
int colonsArray2D = 4;

int[,] array2D = new int[rowsArray2D, colonsArray2D];
FillArray2DBuffer(array2D);
// PrintArray2D(array2D);
FillSpiralArray2D(array2D, 0, 0, 1);
PrintArray2D(array2D);

// к сожалению времени на другое решение пока не хватило. с массивом 6-6 уже работает с ошибкой