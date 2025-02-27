using System;

class Program
{
    static void Main()
    {
        Console.Write("Insere número inteiro: ");
        int input;
        
        // Verificar se a entrada é um número válido
        if (int.TryParse(Console.ReadLine(), out input))
        {
            // Conversão para sbyte
            sbyte n = (sbyte)input;

            // Mostrar decremento e incremento
            Console.WriteLine((sbyte)(n - 1));
            Console.WriteLine((sbyte)(n + 1));
        }
        else
        {
            Console.WriteLine("Entrada inválida! Insira um número inteiro.");
        }
    }
}


