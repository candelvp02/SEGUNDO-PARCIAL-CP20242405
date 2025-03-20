using System;
using System.Text.RegularExpressions;

class Ej2SegParcial
{
    static void Main()
    {
        Console.WriteLine("Ingrese texto (termina con $):");

        var texto = string.Empty;
        var caracter = Console.Read();

        while (caracter != '$')
        {
            texto += (char)caracter;
            caracter = Console.Read();
        }

        var vocales = texto.Count(c => "aeiouAEIOU".Contains(c));
        var palabras = Regex.Matches(texto, @"\w+").Count;

        Console.WriteLine($"\nResultados:");
        Console.WriteLine($"Numero de vocales: {vocales}");
        Console.WriteLine($"Numero de palabras: {palabras}");
    }
}