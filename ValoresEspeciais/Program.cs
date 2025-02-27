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
    }
}
