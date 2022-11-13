//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int x = Prompt("Количество строк");
int y = Prompt("Количество столбцов");
int z = Prompt("Задайте глубину массива");

int[,,] newMatrix = CreateMatrix(x, y, z, CreateArrayNumbers(x, y, z));
PrintMatrix (newMatrix);

int[] CreateArrayNumbers (int a, int b, int c)
{
  int [] arrayNumbers = new int[a*b*c];
  for(int i = 0; i < arrayNumbers.Length; i++)
  {
    //создаю рандомное число в пределах длины массива, чтобы не было повторяющихся чисел (плюс запас 10)
    int newNumber = new Random().Next(1, arrayNumbers.Length + 10);
    int j = 0;
    //проверка нового числа на повторение
    while (j < i)
    {
      if(newNumber == arrayNumbers[j])
      {
        newNumber = new Random().Next(1, arrayNumbers.Length + 10);
        j = 0;
      }
      else
      {
        j++;
      }
    }
    arrayNumbers[i] = newNumber;
  }
  return arrayNumbers;
}

int[,,] CreateMatrix (int a, int b, int c, int[] array) // метод создания матрицы
{
  int[,,] matrix = new int[a, b, c];
  int index = 0;
  for (int i =0; i < a; i++)
  {
    for (int j = 0; j < b; j++)
    {
      for (int d = 0; d < c; d++)
      {
        matrix[i, j, d] = array[index];
        index++;

      }
    }
  }
  return matrix;
}

void PrintMatrix (int[,,] matrix) //метод вывода массива в консоль
{
  for (int i =0; i < matrix.GetUpperBound(0) + 1; i++)
  {
    for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
    {
      for (int d = 0; d < matrix.GetUpperBound(2) + 1; d++)
      {
        Console.Write($"{matrix[i, j, d]} ({i}, {j}, {d}) \t");
      }
      Console.WriteLine();
    }
  }
}

int Prompt (string message) // метод для подсказки в консоль и ввода данных
{
  Console.WriteLine(message);
  int number = int.Parse(Console.ReadLine());
  return number;
}
