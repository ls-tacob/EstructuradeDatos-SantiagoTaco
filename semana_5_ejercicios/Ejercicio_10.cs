using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Inicializar la lista con los precios
        List<int> precios = new List<int> { 50, 75, 46, 22, 80, 65, 8 };

        // Encontrar el menor y mayor precio
        int menorPrecio = int.MaxValue;
        int mayorPrecio = int.MinValue;

        foreach (int precio in precios)
        {
            if (precio < menorPrecio)
            {
                menorPrecio = precio;
            }
            if (precio > mayorPrecio)
            {
                mayorPrecio = precio;
            }
        }

        // Mostrar los resultados
        Console.WriteLine("El menor precio es: " + menorPrecio);
        Console.WriteLine("El mayor precio es: " + mayorPrecio);

        // Pausar para ver el resultado
        Console.ReadLine();
    }
}
