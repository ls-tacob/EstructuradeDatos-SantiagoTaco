using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> catalogo = new List<string>
        {
            "Revista Ciencia Hoy",
            "National Geographic",
            "Muy Interesante",
            "Popular Science",
            "Scientific American",
            "Nature",
            "Discover Magazine",
            "IEEE Spectrum",
            "Time Magazine",
            "Forbes"
        };

        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Buscar un título");
            Console.WriteLine("2. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "2")
                break;
            else if (opcion == "1")
            {
                Console.Write("Ingrese el título a buscar: ");
                string titulo = Console.ReadLine();

                if (BusquedaRecursiva(catalogo, titulo, 0))
                    Console.WriteLine("Encontrado");
                else
                    Console.WriteLine("No encontrado");
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
            }
        }
    }

    static bool BusquedaRecursiva(List<string> catalogo, string titulo, int index)
    {
        if (index >= catalogo.Count)
            return false;
        if (catalogo[index].Equals(titulo, StringComparison.OrdinalIgnoreCase))
            return true;
        return BusquedaRecursiva(catalogo, titulo, index + 1);
    }
}
