using System;

class Arrays
{
    public static void Arrayss()
    {      
        int[] numbers = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Numbers in array:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    Console.WriteLine();

      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      Array.Sort(cars);
      foreach (string i in cars)
      {
        Console.WriteLine(i);
      }    
      
      
      int[] myNumbers = {5, 1, 8, 9};
      Array.Sort(myNumbers);
      foreach (int i in myNumbers)
      {
        Console.WriteLine(i);
      }
    {
      int[,] num = { {1, 4, 2}, {3, 6, 8} };
      num[0,0]=5;
      Console.WriteLine(num[0, 0]);
    }
    }
}
