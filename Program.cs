//Homework 8
//Task1. Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] CreateRandom2DArray()
{
  Console.Write("Input amount of rows: ");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input amount of columns: ");
  int columns = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input min: ");
  int minValue = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input max: ");
  int maxValue = Convert.ToInt32(Console.ReadLine());
  int[,] array = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      array[i, j] = new Random().Next(minValue, maxValue + 1);
  return array;
};

void Show2DArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i, j] + " ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

/*
int[,] SorttheRow(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      for (int k = 0; k < array.GetLength(1) - 1; k++)
        if (array[i, k + 1] > array[i, k])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
  return array;
}

int[,] newArray = CreateRandom2DArray();
Show2DArray(newArray);
int[,] sortedArray = SorttheRow(newArray);
Show2DArray(sortedArray);
*/

//Task2. Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
int MinRowSum(int[,] array)
{
  int numberofrow = 0;
  int sum=0;
  for(int j=0;j<array.GetLength(1);j++)
  sum = sum + array[0,j];
  for (int i = 1; i < array.GetLength(0); i++)
  {
    int temp = 0;
    for (int j = 0; j < array.GetLength(1); j++) temp = temp + array[i, j];
    if (temp < sum) { sum = temp; numberofrow = i + 1; }
  }
  return numberofrow;
}


int[,] newArray = CreateRandom2DArray();
Show2DArray(newArray);
Console.WriteLine("String of minimun sum is "+MinRowSum(newArray));
*/

//Task3.  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
int[,] ArrayMultiply(int[,] array1, int[,] array2)
{
  int[,] newarray = new int[array1.GetLength(0), array2.GetLength(1)];
  if (array1.GetLength(1) == array2.GetLength(0))
    for (int i = 0; i < newarray.GetLength(0); i++)
      for (int j = 0; j < newarray.GetLength(1); j++)
      {
        newarray[i, j] = 0;
        for (int k = 0; k < array1.GetLength(1); k++)
          newarray[i, j] += array1[i, k] * array2[k, j];
      }
  return newarray;
}


int[,] ar1 = CreateRandom2DArray();
Show2DArray(ar1);
int[,] ar2 = CreateRandom2DArray();
Show2DArray(ar2);

Show2DArray(ArrayMultiply(ar1,ar2));
*/

//Task4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
int[,,] CreateRandom3DArray()
{
  Console.Write("Input amount of first dimension: ");
  int first = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input amount of second dimension: ");
  int second = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input amount of third dimension: ");
  int third = Convert.ToInt32(Console.ReadLine());
  int[,,] array = new int[first, second, third];
  for (int i = 0; i < first; i++)
    for (int j = 0; j < second; j++)
      for (int k = 0; k < third; k++)
        array[i, j, k] = new Random().Next(10, 100);
  return array;
};

void Show3DArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
        Console.Write(array[i, j, k] + " (" + i + ", " + j + ", " + k + ") ");
      Console.WriteLine();
    }
  
  Console.WriteLine();
}

int[,,] newarray = CreateRandom3DArray();
Show3DArray(newarray);
*/

//Task5. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] FillArraySpire(int n)
{
  int[,] result = new int[n, n];
  int num = 1;
  int i = 0;
  int j = 0;
     int i1 = 0, i2 = 0, j1 = 0, j2 = 0;
  while (num <= n * n)
  {
    result[i, j] = num;
    if (i == i1 && j < n - j2 - 1)
      ++j;
    else if (j == n - j2 - 1 && i < n - i2 - 1)
      ++i;
    else if (i == n - i1 - 1 && j > j1)
      --j;
    else
      --i;

    if ((i == i1 + 1) && (j == j1) && (j1 != n- j2 - 1))
    {
      i1++;
      i2++;
      j1++;
      j2++;
    }
    num++;
  }
  return result;
}

Console.Write("Input size of the square matrix. n = ");
int n = Convert.ToInt32(Console.ReadLine());
Show2DArray(FillArraySpire(n));
