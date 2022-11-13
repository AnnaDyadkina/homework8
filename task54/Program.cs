//  Задайте двумерный массив. Напишите программу, которая упорядочит
//по убыванию элементы каждой строки двумерного массива.

int m = Prompt("Количество строк");
int n = Prompt("Количество столбцов");

int[,] newArray = CreateArray(m, n);
PrintArray (newArray);

Console.WriteLine(" ");
SortedRowArray(newArray);
PrintArray(newArray);

void SortedRowArray (int[,] array)
{
  int[] rowArray = new int[array.GetLength(0)*array.GetLength(1)];
  int indexArray = 0;
  for (int row = 0; row < array.GetLength(0); row++)
  {
    for (int col = 0; col < array.GetLength(1); col++)
    {
      rowArray[indexArray] = array[row, col];
      indexArray++;
    }
    Array.Sort(rowArray, indexArray-array.GetLength(1), indexArray-1);
  }
  indexArray = 0;
  for (int i =0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = rowArray[indexArray];
      indexArray++;
    }
  }
}

int[,] CreateArray (int m, int n) // метод создания массива
{
  int[,] array = new int[m, n];
  for (int i =0; i < m; i++)
  {
    for (int j = 0; j<n; j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
  return array;
}

void PrintArray (int[,] array) //метод вывода массива в консоль
{
  for (int i =0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j<array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
  }
}

int Prompt (string message) // метод для подсказки в консоль и ввода данных
{
  Console.WriteLine(message);
  int number = int.Parse(Console.ReadLine());
  return number;
}
