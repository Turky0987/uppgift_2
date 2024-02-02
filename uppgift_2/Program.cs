using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Mata in siffror (tryck enter för att avsluta):");
        while (true)
        {
            Console.Write("Ange en siffra (eller tryck enter för att avsluta): ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
                break; 

            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Ogiltig inmatning. Var god ange en giltig siffra.");
            }
        }

        if (numbers.Count > 0)
        {
            int maxNumber = Max(numbers);
            Console.WriteLine("Det största talet är: " + maxNumber);
        }
        else
        {
            Console.WriteLine("Ingen giltig inmatning. Listan är tom.");
        }
    }

    static int Max(List<int> numbers)
    {
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        return max;
    }
}
