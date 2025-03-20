using System;
using System.Linq;

class Ej3SegParcial
{
    static void Main()
    {
        Console.WriteLine("Ingrese el numero total de votantes:");
        int totalVotantes = Convert.ToInt32(Console.ReadLine());

        int votosA = 0;
        int votosB = 0;
        int votosNulos = 0;

        Console.WriteLine($"\nProceso de votacion para {totalVotantes} votantes:");

        for (int i = 1; i <= totalVotantes; i++)
        {
            Console.WriteLine($"\nVotante #{i}:");
            Console.WriteLine("Ingrese su voto (1 para A, 2 para B):");

            if (int.TryParse(Console.ReadLine(), out int voto))
            {
                switch (voto)
                {
                    case 1:
                        votosA++;
                        break;
                    case 2:
                        votosB++;
                        break;
                    default:
                        votosNulos++;
                        Console.WriteLine("¡Voto nulo! Solo se aceptan 1 para A o 2 para B.");
                        break;
                }
            }
            else
            {
                votosNulos++;
                Console.WriteLine("¡Voto nulo! Por favor ingrese un numero valido.");
            }
        }

        Console.WriteLine("\nRESULTADOS FINALES:");
        Console.WriteLine("====================");
        Console.WriteLine($"Total de votantes: {totalVotantes}");
        Console.WriteLine($"Votos para A: {votosA}");
        Console.WriteLine($"Votos para B: {votosB}");
        Console.WriteLine($"Votos nulos: {votosNulos}");

        if (votosA > votosB)
            Console.WriteLine("\n¡Candidato A es el ganador!");
        else if (votosB > votosA)
            Console.WriteLine("\n¡Candidato B es el ganador!");
        else
            Console.WriteLine("\n¡Ha habido un empate entre ambos candidatos!");
    }
}