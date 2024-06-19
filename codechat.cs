using System;

class Program
{
    const int MaxElements = 100;

    static int Sum(int[] numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    static int[] ReadNumbers(int count)
    {
        int[] numbers = new int[count];
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter integer #{i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        return numbers;
    }

    static void Main()
    {
        Console.Write("Enter the number of elements (1-100): ");
        if (!int.TryParse(Console.ReadLine(), out int numberOfElements) || numberOfElements < 1 || numberOfElements > MaxElements)
        {
            Console.WriteLine("Invalid input. Please provide a number ranging from 1 to 100.");
            return;
        }

        int[] numbers = ReadNumbers(numberOfElements);
        int total = Sum(numbers);

        Console.WriteLine($"Sum of the numbers: {total}");
    }
}