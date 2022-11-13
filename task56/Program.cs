// Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int m = Prompt("Количество строк");
int n = Prompt("Количество столбцов");

int[,] newArray = CreateArray(m, n);
PrintArray (newArray);
FindMinRow(newArray);

void FindMinRow (int[,] array)
{
  int min=0;
  int sum = 0;
  int minRow = 0;
  for (int row = 0; row < array.GetLength(0); row++)
  {
    for (int col = 0; col < array.GetLength(1); col++)
    {
      if (row == 0)
      {
        min = min + array[row, col];
      }
      sum = sum + array[row, col];
    }
    if (sum < min)
    {
      min = sum;
      minRow = row;
    }
    sum = 0;
  }
  Console.WriteLine(minRow);
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
