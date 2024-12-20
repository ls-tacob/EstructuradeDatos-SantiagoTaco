using System;                     // Espacio de nombres base de .NET para entrada/salida, manejo de fechas y operaciones básicas.
using System.Collections.Generic; // Proporciona estructuras de datos como listas y diccionarios.
using System.IO;                  // Permite leer y escribir en archivos, además de trabajar con rutas y directorios.

class Program
{
    static void Main(string[] args)
    {
        List<Producto> productos = new List<Producto>(); // Lista de productos registrados
        int autoIncrementalId = 1; // Controla el ID automático

        while (true)
        {
            int opcion = Utilidades.LeerOpcionMenu(); // Lee la opción seleccionada por el usuario

            if (opcion == 1) // Registrar un nuevo producto
            {
                Console.WriteLine("\nRegistrando un nuevo producto:");
                int id = autoIncrementalId++; // Genera el ID automáticamente
                Console.WriteLine($"ID generado automáticamente: {id}");

                Console.Write("Ingrese el nombre del producto: ");
                string nombre = Utilidades.LeerTexto();

                Console.Write("Ingrese la unidad de medida: ");
                string unidad = Utilidades.LeerTexto();

                Console.Write("Ingrese el precio por unidad: ");
                double precioPorUnidad = Utilidades.LeerDouble();

                Console.Write("Ingrese el precio por docena: ");
                double precioPorDocena = Utilidades.LeerDouble();

                Console.Write("Ingrese el precio al mayoreo: ");
                double precioMayoreo = Utilidades.LeerDouble();

                Producto nuevoProducto = new Producto(id, nombre, unidad, precioPorUnidad, precioPorDocena, precioMayoreo);
                productos.Add(nuevoProducto); // Agrega el producto a la lista
                Producto.GuardarEnArchivo(productos); // Guarda el producto en el archivo
                Console.WriteLine("\nProducto registrado y guardado con éxito.");
            }
            else if (opcion == 2) // Ver lista de productos
            {
                Console.WriteLine("\nLista de productos registrados:");
                if (productos.Count > 0)
                {
                    foreach (var producto in productos)
                    {
                        producto.MostrarInformacion();
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("No hay productos registrados.");
                }
            }
            else if (opcion == 3) // Salir del programa
            {
                Console.WriteLine("Saliendo...");
                break;
            }
        }
    }
}
