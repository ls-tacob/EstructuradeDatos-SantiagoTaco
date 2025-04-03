using System;
using System.Collections.Generic;

class Grafo
{
    private Dictionary<int, List<int>> adyacencia;

    public Grafo()
    {
        adyacencia = new Dictionary<int, List<int>>();
    }

    public void AgregarNodo(int nodo)
    {
        if (!adyacencia.ContainsKey(nodo))
        {
            adyacencia[nodo] = new List<int>();
        }
    }

    public void AgregarArista(int origen, int destino)
    {
        if (!adyacencia.ContainsKey(origen))
        {
            AgregarNodo(origen);
        }
        if (!adyacencia.ContainsKey(destino))
        {
            AgregarNodo(destino);
        }

        adyacencia[origen].Add(destino);
        adyacencia[destino].Add(origen); // Grafo no dirigido
    }

    public void MostrarGrafo()
    {
        foreach (var nodo in adyacencia)
        {
            Console.Write(nodo.Key + " -> ");
            Console.WriteLine(string.Join(", ", nodo.Value));
        }
    }

    public void CalcularCentralidadGrado()
    {
        Console.WriteLine("\nCentralidad de Grado:");
        foreach (var nodo in adyacencia)
        {
            Console.WriteLine($"Nodo {nodo.Key}: {nodo.Value.Count}");
        }
    }
}

class Program
{
    static void Main()
    {
        Grafo grafo = new Grafo();

        // Agregar nodos y aristas
        grafo.AgregarArista(1, 2);
        grafo.AgregarArista(1, 3);
        grafo.AgregarArista(2, 4);
        grafo.AgregarArista(3, 4);
        grafo.AgregarArista(4, 5);

        // Mostrar el grafo
        Console.WriteLine("Representación del Grafo:");
        grafo.MostrarGrafo();

        // Calcular y mostrar centralidad de grado
        grafo.CalcularCentralidadGrado();
    }
}
