using System;
using System.Collections.Generic;

namespace CentralidadGrafo
{
    public class CentralidadGrado
    {
        private Grafo grafo;

        public CentralidadGrado(Grafo grafo)
        {
            this.grafo = grafo;
        }

        public void Calcular()
        {
            Console.WriteLine("\nCentralidad de Grado:");
            foreach (var nodo in grafo.Adyacencia)
            {
                Console.WriteLine($"Nodo {nodo.Key}: {nodo.Value.Count}");
            }
        }
    }
}
