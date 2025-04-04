using System;
using System.Collections.Generic;

namespace CentralidadGrafo
{
    public class Grafo
    {
        public Dictionary<int, List<int>> Adyacencia { get; private set; }

        public Grafo()
        {
            Adyacencia = new Dictionary<int, List<int>>();
        }

        public void AgregarNodo(int nodo)
        {
            if (!Adyacencia.ContainsKey(nodo))
                Adyacencia[nodo] = new List<int>();
        }

        public void AgregarArista(int origen, int destino)
        {
            AgregarNodo(origen);
            AgregarNodo(destino);
            Adyacencia[origen].Add(destino);
            Adyacencia[destino].Add(origen); // grafo no dirigido
        }

        public void MostrarGrafo()
        {
            Console.WriteLine("Representación del Grafo:");
            foreach (var nodo in Adyacencia)
            {
                Console.Write(nodo.Key + " -> ");
                Console.WriteLine(string.Join(", ", nodo.Value));
            }
        }
    }
}
