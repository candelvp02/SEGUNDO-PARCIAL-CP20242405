using System;
using System.Collections.Generic;
using System.Linq;

class Ej1SegParcial
{
    static void Main()
    {
        var numbers = ReadNumbers();
        Console.WriteLine("Lista ingresada: " + string.Join(" ", numbers));

        Console.WriteLine("Numeros impares: " + string.Join(" ",
            numbers.Where(n => n % 2 != 0)));

        var maxValue = numbers.Max();
        var maxIndex = numbers.IndexOf(maxValue);
        Console.WriteLine($"El valor maximo {maxValue} esta en la posicion {maxIndex + 1}");
    }

    static List<int> ReadNumbers()
    {
        var numbers = new List<int>();
        Console.WriteLine("Ingrese numeros positivos (-9999 para terminar):");

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int num) && num != -9999)
            {
                if (num > 0) numbers.Add(num);
            }
            else if (num == -9999)
            {
                break;
            }
            else
            {
                Console.WriteLine("Por favor ingrese un numero valido.");
            }
        }
        return numbers;
    }
}