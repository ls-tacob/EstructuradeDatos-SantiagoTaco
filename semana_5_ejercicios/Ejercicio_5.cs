using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Declaramos una lista para almacenar los números del 1 al 10
        List<int> numeros = new List<int>();

        // Llenar la lista con los números del 1 al 10
        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }

        // Mostrar los números en orden inverso separados por comas
        numeros.Reverse();
        Console.WriteLine(string.Join(", ", numeros));

        // Detener el programa temporalmente para ver el resultado
        Console.ReadLine();
    }
}
