// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int InputNum(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void RandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5); 
        }
    }
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    Console.WriteLine("");
    }
}
int size = InputNum("Задайте размерность матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
int[,] result = new int[size, size];
RandomArray(matrixA);
RandomArray(matrixB);

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            result[i, j] = result[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
//Console.WriteLine({ShowArray(matrixA)} | {ShowArray(matrixB)});
ShowArray(matrixA);
ShowArray(matrixB);
Console.WriteLine("Результирующая матрица будет:");
ShowArray(result);
