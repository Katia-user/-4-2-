using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть довжину масиву: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-5, 11);
        }
        Console.WriteLine("Вихідний масив:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"array[{i}] = {array[i]}");
        }
        Console.WriteLine("Локальні максимуми:");
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                Console.WriteLine($"Локальний максимум: array[{i}] = {array[i]}");
            }
        }
    }
}
