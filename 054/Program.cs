// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] MyArray = new int[3, 4];
FillArray(MyArray);
ShowArray(MyArray);
SortArray(MyArray);
Console.WriteLine();
ShowArray(MyArray);


void FillArray(int[,] MyArray)
{
    Console.WriteLine("Задан массив:");
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            MyArray[i, j] = new Random().Next(1, 10);
        }
    }
}
void SortArray(int[,] MyArray)
{
    Console.WriteLine($"В итоге получается вот такой массив:");
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
    for (int j = 0; j < MyArray.GetLength(1); j++)
        {
        for (int k = 0; k < MyArray.GetLength(1) - 1; k++)
         {
        if (MyArray[i, k] < MyArray[i, k + 1])
            {
            int temp = MyArray[i, k + 1];
            MyArray[i, k + 1] = MyArray[i, k];
            MyArray[i, k] = temp;
            }
         }
        }
    }
}
void ShowArray(int[,] MyArray)
{
        for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            Console.Write($"{MyArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
