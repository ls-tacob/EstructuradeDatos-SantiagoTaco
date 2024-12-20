using System;

public static class Utilidades
{
    // Método para leer un número entero con validación
    public static int LeerEntero()
    {
        while (true)
        {
            string? input = Console.ReadLine(); // Lee la entrada del usuario
            if (int.TryParse(input, out int resultado)) // Valida si la entrada es un entero
            {
                return resultado; // Retorna el número si es válido
            }
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero."); // Muestra un error si no es válido
        }
    }

    // Método para leer un texto no nulo o vacío
    public static string LeerTexto()
    {
        while (true)
        {
            string? input = Console.ReadLine(); // Lee la entrada del usuario
            if (!string.IsNullOrWhiteSpace(input)) // Verifica que no sea nula ni vacía
            {
                return input; // Retorna el texto si es válido
            }
            Console.WriteLine("Entrada inválida. Por favor, ingrese un texto válido."); // Muestra un error si es inválido
        }
    }

    // Método para leer un número decimal con validación
    public static double LeerDouble()
    {
        while (true)
        {
            string? input = Console.ReadLine(); // Lee la entrada del usuario
            if (double.TryParse(input, out double resultado)) // Valida si la entrada es un número decimal
            {
                return resultado; // Retorna el número si es válido
            }
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número decimal válido."); // Muestra un error si no es válido
        }
    }

    // Método para leer la opción del menú
    public static int LeerOpcionMenu()
    {
        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Registrar un nuevo producto");
            Console.WriteLine("2. Ver lista de productos");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");

            string? input = Console.ReadLine();
            if (int.TryParse(input, out int opcion) && opcion >= 1 && opcion <= 3)
            {
                return opcion;
            }
            Console.WriteLine("Opción inválida. Por favor, ingrese una opción entre 1 y 3.");
        }
    }
}
