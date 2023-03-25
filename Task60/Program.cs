// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//заполнение одномерного массива случайными неповторяющимися int от 10 до 99
void FillArray1D(int [] array1D)
{
    Random random = new Random();
    int temporaryValue = 0;
    for (int i = 0; i < array1D.Length; i ++)
    {
        if(i > 0)
        {
            temporaryValue = random.Next(10, 100);
            for (int j = 0; j < i; j++)
                {
                    while(temporaryValue == array1D[j])
                    {       
                        temporaryValue = random.Next(10, 100);
                        j = 0;
                        array1D[i] = temporaryValue;
                    }
                    array1D[i] = temporaryValue;
                }
        }
        else
        {
           array1D[i] = random.Next(10, 100);
        }
    }
}

//заполнение 3D массива числами из массива 1D
void FillArray3D(int [,,] array3D, int [] array1D)
{
int countArray1D = 0;
    for (int i = 0; i < array3D.GetLength(0); i ++)
    {
        for (int j = 0; j < array3D.GetLength(1); j ++)
        {
            for (int k = 0; k < array3D.GetLength(2); k ++)
            {
                array3D[i, j, k] = array1D[countArray1D];
                countArray1D++;
            }
        }
    }
}

//печать массива в консоль
void PrintArray3D(int [,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i ++)
    {
        for (int j = 0; j < array3D.GetLength(1); j ++)
        {
            for (int k = 0; k < array3D.GetLength(2); k ++)
            {
            System.Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
    }
}


int rowsArray3D = 2;
int colonsArray3D = 2;
int depthArray3D = 2;
int lengthArray1D = rowsArray3D*colonsArray3D*depthArray3D;

int[] array1D = new int[lengthArray1D];
int[,,] array3D = new int[rowsArray3D, colonsArray3D, depthArray3D];
FillArray1D(array1D);
FillArray3D(array3D, array1D);
PrintArray3D(array3D);

