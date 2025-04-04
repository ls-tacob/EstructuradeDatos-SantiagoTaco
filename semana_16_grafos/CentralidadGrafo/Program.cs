using System;

namespace CentralidadGrafo
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafo grafo = new Grafo();

            // Crear el grafo
            grafo.AgregarArista(1, 2);
            grafo.AgregarArista(1, 3);
            grafo.AgregarArista(2, 4);
            grafo.AgregarArista(3, 4);
            grafo.AgregarArista(4, 5);

            grafo.MostrarGrafo();

            // Centralidad de grado
            CentralidadGrado centralidadGrado = new CentralidadGrado(grafo);
            centralidadGrado.Calcular();

            // Centralidad de cercanía
            CentralidadCercania centralidadCercania = new CentralidadCercania(grafo);
            centralidadCercania.Calcular();
        }
    }
}
