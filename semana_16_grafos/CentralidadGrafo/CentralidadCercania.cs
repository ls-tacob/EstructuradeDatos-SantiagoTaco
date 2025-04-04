using System;
using System.Collections.Generic;
using System.Linq;

namespace CentralidadGrafo
{
    public class CentralidadCercania
    {
        private Grafo grafo;

        public CentralidadCercania(Grafo grafo)
        {
            this.grafo = grafo;
        }

        public void Calcular()
        {
            Console.WriteLine("\nCentralidad de Cercanía:");

            foreach (var nodo in grafo.Adyacencia.Keys)
            {
                int sumaDistancias = 0;

                foreach (var otroNodo in grafo.Adyacencia.Keys)
                {
                    if (nodo != otroNodo)
                        sumaDistancias += BFS(nodo, otroNodo);
                }

                double centralidad = sumaDistancias > 0 ? 1.0 / sumaDistancias : 0;
                Console.WriteLine($"Nodo {nodo}: {centralidad:F4}");
            }
        }

        private int BFS(int inicio, int objetivo)
        {
            Queue<int> cola = new Queue<int>();
            Dictionary<int, int> distancias = new Dictionary<int, int>();

            cola.Enqueue(inicio);
            distancias[inicio] = 0;

            while (cola.Count > 0)
            {
                int actual = cola.Dequeue();

                foreach (var vecino in grafo.Adyacencia[actual])
                {
                    if (!distancias.ContainsKey(vecino))
                    {
                        distancias[vecino] = distancias[actual] + 1;
                        cola.Enqueue(vecino);

                        if (vecino == objetivo)
                            return distancias[vecino];
                    }
                }
            }

            return int.MaxValue; // no hay camino
        }
    }
}
