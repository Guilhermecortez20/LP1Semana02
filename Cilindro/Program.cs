using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Insira a altura do cilindro: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Insira o raio do cilindro: ");
        double raio = Convert.ToDouble(Console.ReadLine());

       
        double volume = Math.PI * Math.Pow(raio, 2) * altura;
        double areaSuperficie = 2 * Math.PI * raio * (raio + altura);

        
        Console.WriteLine($"Volume: {volume:F3}");
        Console.WriteLine($"Área de superfície: {areaSuperficie:F3}");
    }
}

