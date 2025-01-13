using System;

class Program
{
    static void Main()
    {
        // Solicitar una palabra al usuario
        Console.WriteLine("Por favor, ingresa una palabra:");
        string palabra = Console.ReadLine();

        // Convertir la palabra a minúsculas para evitar problemas con mayúsculas
        palabra = palabra.ToLower();

        // Invertir la palabra
        char[] caracteres = palabra.ToCharArray();
        Array.Reverse(caracteres);
        string palabraInvertida = new string(caracteres);

        // Comparar la palabra original con la invertida
        if (palabra == palabraInvertida)
        {
            Console.WriteLine("La palabra ingresada es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra ingresada NO es un palíndromo.");
        }

        // Pausar para ver el resultado
        Console.ReadLine();
    }
}
