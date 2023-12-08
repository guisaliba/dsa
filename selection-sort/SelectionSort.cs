using System;

namespace SelectionSort
{
  class Program
  {
    static void Main(string[] args)
    {
      // Testing the algorithm
      int[] array = { 5, 3, 6, 2, 10 };
      SelectionSort(array);
      foreach (int item in array)
      {
        Console.WriteLine(item); // 2, 3, 5, 6, 10
      }
    }

    public static void SelectionSort(int[] array)
    {
      for (int i = 0; i < array.length - 1; i++)
      {
        int minI = i;

        for (int j = i + 1; j < n; j++)
        {
          if (array[j] < array[minI])
          {
            minI = j;
          }
        }

        int temp = array[i];
        array[i] = array[minI];
        array[minI] = temp;
      }
    }
  }
}