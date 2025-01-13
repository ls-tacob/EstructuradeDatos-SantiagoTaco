using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Solicitar una palabra al usuario
        Console.WriteLine("Por favor, ingresa una palabra:");
        string palabra = Console.ReadLine().ToLower();

        // Crear un diccionario para contar las vocales
        Dictionary<char, int> conteoVocales = new Dictionary<char, int>
        {
            { 'a', 0 },
            { 'e', 0 },
            { 'i', 0 },
            { 'o', 0 },
            { 'u', 0 }
        };

        // Contar las vocales
        foreach (char letra in palabra)
        {
            if (conteoVocales.ContainsKey(letra))
            {
                conteoVocales[letra]++;
            }
        }

        // Mostrar los resultados
        Console.WriteLine("Cantidad de vocales en la palabra:");
        foreach (var vocal in conteoVocales)
        {
            Console.WriteLine($"{vocal.Key}: {vocal.Value}");
        }

        // Pausar para ver el resultado
        Console.ReadLine();
    }
}
