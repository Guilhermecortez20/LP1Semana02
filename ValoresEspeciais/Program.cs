using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Valores Mínimos e Máximos ===");
        Console.WriteLine($"byte: {byte.MinValue} a {byte.MaxValue}");
        Console.WriteLine($"sbyte: {sbyte.MinValue} a {sbyte.MaxValue}");
        Console.WriteLine($"short: {short.MinValue} a {short.MaxValue}");
        Console.WriteLine($"ushort: {ushort.MinValue} a {ushort.MaxValue}");
        Console.WriteLine($"int: {int.MinValue} a {int.MaxValue}");
        Console.WriteLine($"uint: {uint.MinValue} a {uint.MaxValue}");
        Console.WriteLine($"long: {long.MinValue} a {long.MaxValue}");
        Console.WriteLine($"ulong: {ulong.MinValue} a {ulong.MaxValue}");
        Console.WriteLine($"float: {float.MinValue} a {float.MaxValue}");
        Console.WriteLine($"double: {double.MinValue} a {double.MaxValue}");
        Console.WriteLine($"decimal: {decimal.MinValue} a {decimal.MaxValue}");

        Console.WriteLine("\n=== Valores Especiais ===");
        Console.WriteLine($"float: -∞ = {float.NegativeInfinity}, +∞ = {float.PositiveInfinity}, NaN = {float.NaN}");
        Console.WriteLine($"double: -∞ = {double.NegativeInfinity}, +∞ = {double.PositiveInfinity}, NaN = {double.NaN}");


        
        Console.WriteLine("\n=== Overflow em uint ===");
        uint maxUint = uint.MaxValue;
        uint overflowUint = maxUint + 1; 
        Console.WriteLine($"uint.MaxValue + 1 = {overflowUint}");

        
        Console.WriteLine("\n=== Overflow em float (resultado infinito) ===");
        float largeFloat = float.MaxValue * 2; 
        Console.WriteLine($"float.MaxValue * 2 = {largeFloat}");

        
        Console.WriteLine("\n=== Overflow em float (perda de precisão) ===");
        float preciseFloat = 1e30f + 1f - 1e30f; 
        Console.WriteLine($"(1e30 + 1 - 1e30) = {preciseFloat}");

        
        Console.WriteLine("\n=== Underflow em float ===");
        float underflowFloat = float.MinValue / float.MaxValue; 
        Console.WriteLine($"float.MinValue / float.MaxValue = {underflowFloat}");
    }
}
