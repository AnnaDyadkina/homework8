//Задача 62: Заполните спирально массив 4 на 4 с помощью цикла
//int[,] spiralArray= new int[4, 4];

int[,] spiralArray = FillSpiralArray(4, 4);
PrintArray(spiralArray);

int[,] FillSpiralArray (int m, int n)
{
  int[,] array = new int[m, n];
  int lengthArray = m*n;
  int index = 1;
  //int step = 0;
  int row = 0;
  int col = 0;
  while (index < lengthArray)
  {
    while (col < n)
    {
      if (col+1 < n && array[row, col+1] > 0)
      {
        break;
      }
        array[row, col] = index;
        index++;
        col++;
    }
    col = col - 1;
    while (row < m)
    {
      if (row + 1 < m && array[row+1, col] > 0)
      {
        break;
      }
      array[row, col] = index;
      index++;
      row++;
    }
    row = row - 1;
    while (col >= 0)
    {
      //Console.WriteLine(row);
      //Console.WriteLine(col);
      if (col-1 >= 0 && array[row, col-1] > 0)
      {
        break;
      }
      array[row, col] = index;
      index++;
      col--;
    }
    col = col + 1;
    while (row >=0)
    {
      if (row - 1 >= 0 && array[row-1, col] > 0)
      {
        break;
      }
      array[row, col] = index;
      index++;
      row--;
    }
    row = row + 1;
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
