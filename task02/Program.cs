//Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.
//1 4 8 19
//5 -2 33 -2
//77 3 8 1

int [,] CreateArray (int length1, int lenght2)
{
    int [,] Array = new int [length1, lenght2];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
           Array[i,j] = new Random().Next(-100, 100);
        }
    }
    return Array;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
           System.Console.Write(Array[i,j]+" ");
           
        }
        System.Console.WriteLine();
    }
}

PrintArray(CreateArray(4, 4));