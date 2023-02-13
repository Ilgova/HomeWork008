// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



Console.WriteLine("Заполненый спирально массив 4 на 4");
int[,] numbers = new int[4, 4];
int num = 1;
int i = 0;
int j = 0;

while (num <= 4 * 4)
{
    numbers[i, j] = num;
    if (i <= j + 1 && i + j < 4 - 1)
        ++j;
    else if (i < j && i + j >= 4 - 1)
        ++i;
    else if (i >= j && i + j > 4 - 1)
        --j;
    else
        --i;
    ++num;
}

ShowArray(numbers);

void ShowArray(int[,] MyArray)
{
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
     
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            Console.Write(MyArray[i, j] + "\t");
        }
    
        Console.WriteLine(" ");
    }
}