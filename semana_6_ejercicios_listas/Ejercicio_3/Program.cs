using System;

class Program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();

        // Agregar elementos a la lista
        lista.AgregarAlFinal(10);
        lista.AgregarAlFinal(20);
        lista.AgregarAlFinal(30);

        // Imprimir la lista
        Console.WriteLine("Lista de elementos:");
        lista.ImprimirLista();

        // Obtener la longitud de la lista
        int longitud = lista.ObtenerLongitud();
        Console.WriteLine("Número de elementos en la lista: " + longitud);
    }
}
