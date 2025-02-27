using System;

class Program
{
    static void Main()
    {
        Console.Write("Insere número inteiro não-negativo: ");
        int input;

        
        if (int.TryParse(Console.ReadLine(), out input) && input >= 0 && input <= 255)
        {
            
            byte n = (byte)input;

           
            Console.WriteLine(n / 2);       
            Console.WriteLine(n << 3);      
            Console.WriteLine(n ^ 6);       
            Console.WriteLine(n > 10);      
        }
        else
        {
            Console.WriteLine("Entrada inválida! Insira um número entre 0 e 255.");
        }
    }
}

