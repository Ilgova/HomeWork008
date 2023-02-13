// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.WriteLine("Прямоугольный двумерный массив: ");
int[,] MyArray = new int[4, 4];
CreateArray(MyArray);
ShowArray(MyArray);

int minSumm = 0;  // наименьшая сумма элементов
int lineSumm = SumLineElements(MyArray, 0);//сумма элементов строки
for (int i = 1; i < MyArray.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(MyArray, i);
  if (lineSumm > tempSumLine)
  {
    lineSumm = tempSumLine;
    minSumm = i;
  }
}
Console.Write("Номер строки с наименьшей суммой элементов: ");
Console.WriteLine($"{minSumm+1} строка");


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

void CreateArray(int[,] MyArray)
{
  for (int i = 0; i < MyArray.GetLength(0); i++)
  {
    for (int j = 0; j < MyArray.GetLength(1); j++)
    {
      MyArray[i, j] = new Random().Next(1,10);
    }
  }
}

void ShowArray (int[,] MyArray)
{
  for (int i = 0; i < MyArray.GetLength(0); i++)
  {
    for (int j = 0; j < MyArray.GetLength(1); j++)
    {
      Console.Write(MyArray[i,j] + " ");
    }
    Console.WriteLine();
  }
}