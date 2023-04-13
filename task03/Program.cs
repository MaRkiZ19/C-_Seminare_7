// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int m = ReadNumb("m");
int n = ReadNumb("n");
int[,] Array = CreateArray(m, n);
PrintArray(Array);
ChangeArray (Array);
PrintArray(Array);


int ReadNumb(string arg)
{
    System.Console.Write($"Введите {arg}: ");
    return int.Parse(Console.ReadLine());
}

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

void ChangeArray (int [,] Array)
{
    
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
           if (i % 2 == 0 && j % 2 == 0)
           {
                Array[i,j] = (int) Math.Pow(Array[i,j], 2);
           }
           
        }
    }
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