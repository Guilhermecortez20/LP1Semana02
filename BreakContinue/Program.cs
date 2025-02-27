using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Números de 1 a 20 (exceto 10):");

        for (int i = 1; i <= 20; i++)
        {
            if (i == 10)
            {
                continue; // Pula a iteração quando i for 10
            }

            Console.WriteLine(i);
        }
    }
}

