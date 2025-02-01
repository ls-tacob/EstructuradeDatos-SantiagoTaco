using System;
using System.Collections.Generic;

class ColaAsientos
{
    private Queue<int> asientosDisponibles;

    public ColaAsientos(int cantidadAsientos)
    {
        asientosDisponibles = new Queue<int>();

        // Llenamos la cola con los asientos disponibles (números del 1 al 30)
        for (int i = 1; i <= cantidadAsientos; i++)
        {
            asientosDisponibles.Enqueue(i);
        }
    }

    public int AsignarAsiento()
    {
        if (asientosDisponibles.Count > 0)
        {
            return asientosDisponibles.Dequeue(); // Asigna un asiento y lo elimina de la cola
        }
        else
        {
            Console.WriteLine("No hay asientos disponibles.");
            return -1; // Indica que no hay asientos disponibles
        }
    }

    public void MostrarAsientosDisponibles()
    {
        Console.WriteLine("Asientos disponibles:");
        foreach (var asiento in asientosDisponibles)
        {
            Console.Write(asiento + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de ColaAsientos con 30 asientos
        ColaAsientos cola = new ColaAsientos(30);

        // Simulamos 5 personas llegando para asignarles un asiento
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Persona {i} llega y se le asigna el asiento: {cola.AsignarAsiento()}");
        }

        // Mostrar los asientos restantes
        cola.MostrarAsientosDisponibles();
    }
}
