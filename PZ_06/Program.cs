using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10];

        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 51);
        }

        Array.Sort(array, 0, array.Length / 2);
        Array.Sort(array, array.Length / 2, array.Length / 2, new ReverseComparer());

        Console.WriteLine("Отсортированный массив:");
        foreach (int num in array)
        {
            Console.WriteLine(num);
        }
    }
}

class ReverseComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return y.CompareTo(x);
    }
}