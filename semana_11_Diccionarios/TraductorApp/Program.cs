using System;
using System.Collections.Generic;

namespace TraductorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diccionario con las palabras predefinidas
            Dictionary<string, string> diccionarioInglesEspañol = new Dictionary<string, string>
            {
                {"Time", "tiempo"},
                {"Person", "persona"},
                {"Year", "año"},
                {"Way", "camino/forma"},
                {"Day", "día"},
                {"Thing", "cosa"},
                {"Man", "hombre"},
                {"World", "mundo"},
                {"Life", "vida"},
                {"Hand", "mano"},
                {"Part", "parte"},
                {"Child", "niño/a"},
                {"Eye", "ojo"},
                {"Woman", "mujer"},
                {"Place", "lugar"},
                {"Work", "trabajo"},
                {"Week", "semana"},
                {"Case", "caso"},
                {"Point", "punto/tema"},
                {"Government", "gobierno"},
                {"Company", "empresa/compañía"}
            };

            // Diccionario para la traducción del español al inglés
            Dictionary<string, string> diccionarioEspañolIngles = new Dictionary<string, string>();
            foreach (var item in diccionarioInglesEspañol)
            {
                diccionarioEspañolIngles[item.Value] = item.Key;
            }

            bool running = true;

            while (running)
            {
                // Mostrar el menú
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("=======================================================");
                Console.WriteLine("1. Traducir una frase");
                Console.WriteLine("2. Ingresar más palabras al diccionario");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine()?.Trim(); // Usamos ? para manejar posibles valores nulos

                // Verificar que la opción no sea nula o vacía
                if (string.IsNullOrEmpty(opcion))
                {
                    Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case "1":
                        // Traducir una frase
                        TraducirFrase(diccionarioInglesEspañol, diccionarioEspañolIngles);
                        break;

                    case "2":
                        // Agregar más palabras al diccionario
                        AgregarPalabra(diccionarioInglesEspañol, diccionarioEspañolIngles);
                        break;

                    case "0":
                        // Salir
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        // Método para traducir la frase
        static void TraducirFrase(Dictionary<string, string> diccionarioInglesEspañol, Dictionary<string, string> diccionarioEspañolIngles)
        {
            Console.WriteLine("¿De qué idioma desea traducir? (1: Inglés a Español / 2: Español a Inglés)");
            string? opcionIdioma = Console.ReadLine()?.Trim();

            // Verificar que la opción no sea nula o vacía
            if (string.IsNullOrEmpty(opcionIdioma) || (opcionIdioma != "1" && opcionIdioma != "2"))
            {
                Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Ingrese la frase:");
            string? frase = Console.ReadLine()?.Trim();

            // Verificar que la frase no sea nula o vacía
            if (string.IsNullOrEmpty(frase))
            {
                Console.WriteLine("La frase no puede estar vacía. Presione cualquier tecla para continuar...");
                Console.ReadKey();
                return;
            }

            // Convertir la frase a un array de palabras
            string[] palabras = frase.Split(' ');

            // Traducir las palabras según el diccionario seleccionado
            for (int i = 0; i < palabras.Length; i++)
            {
                if (opcionIdioma == "1" && diccionarioInglesEspañol.ContainsKey(palabras[i])) // Inglés a Español
                {
                    palabras[i] = diccionarioInglesEspañol[palabras[i]];
                }
                else if (opcionIdioma == "2" && diccionarioEspañolIngles.ContainsKey(palabras[i])) // Español a Inglés
                {
                    palabras[i] = diccionarioEspañolIngles[palabras[i]];
                }
            }

            // Mostrar la frase traducida
            Console.WriteLine("\nSu frase traducida es: " + string.Join(" ", palabras));
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        // Método para agregar palabras al diccionario
        static void AgregarPalabra(Dictionary<string, string> diccionarioInglesEspañol, Dictionary<string, string> diccionarioEspañolIngles)
        {
            Console.WriteLine("Ingrese la palabra en inglés:");
            string? palabraIngles = Console.ReadLine()?.Trim();

            // Verificar que la palabra no sea nula o vacía
            if (string.IsNullOrEmpty(palabraIngles))
            {
                Console.WriteLine("La palabra en inglés no puede estar vacía. Presione cualquier tecla para continuar...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Ingrese la traducción al español:");
            string? traduccion = Console.ReadLine()?.Trim();

            // Verificar que la traducción no sea nula o vacía
            if (string.IsNullOrEmpty(traduccion))
            {
                Console.WriteLine("La traducción no puede estar vacía. Presione cualquier tecla para continuar...");
                Console.ReadKey();
                return;
            }

            // Agregar la palabra al diccionario de inglés a español
            if (!diccionarioInglesEspañol.ContainsKey(palabraIngles))
            {
                diccionarioInglesEspañol.Add(palabraIngles, traduccion);
                // También se agrega la traducción al diccionario inverso (español a inglés)
                diccionarioEspañolIngles[traduccion] = palabraIngles;
                Console.WriteLine("Palabra agregada correctamente.");
            }
            else
            {
                Console.WriteLine("La palabra ya existe en el diccionario.");
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
