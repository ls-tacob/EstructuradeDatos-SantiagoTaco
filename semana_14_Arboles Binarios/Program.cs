using System;

namespace ArbolBinario
{
    // Clase Nodo que representa cada nodo del árbol
    public class Nodo
    {
        public int Valor;       // Valor del nodo
        public Nodo Izquierda;  // Apuntador al subárbol izquierdo
        public Nodo Derecha;    // Apuntador al subárbol derecho

        // Constructor de Nodo
        public Nodo(int valor)
        {
            Valor = valor;
            Izquierda = null;
            Derecha = null;
        }
    }

    // Clase ArbolBinario que contiene los métodos del árbol
    public class ArbolBinario
    {
        public Nodo Raiz;  // Raíz del árbol

        // Constructor de ArbolBinario
        public ArbolBinario()
        {
            Raiz = null;
        }

        // Método para insertar un nodo en el árbol de manera iterativa
        public void Insertar(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            if (Raiz == null)
            {
                Raiz = nuevoNodo;
            }
            else
            {
                Nodo actual = Raiz;
                Nodo padre = null;
                while (actual != null)
                {
                    padre = actual;
                    if (valor < actual.Valor)
                        actual = actual.Izquierda;
                    else
                        actual = actual.Derecha;
                }

                if (valor < padre.Valor)
                    padre.Izquierda = nuevoNodo;
                else
                    padre.Derecha = nuevoNodo;
            }
        }

        // Método para insertar un nodo en el árbol de manera recursiva
        public void InsertarRecursivo(int valor)
        {
            Raiz = InsertarRecursivo(Raiz, valor);
        }

        private Nodo InsertarRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null)
            {
                nodo = new Nodo(valor);
            }
            else
            {
                if (valor < nodo.Valor)
                    nodo.Izquierda = InsertarRecursivo(nodo.Izquierda, valor);
                else
                    nodo.Derecha = InsertarRecursivo(nodo.Derecha, valor);
            }
            return nodo;
        }

        // Método para hacer un recorrido en inorden del árbol
        public void RecorridoInorden()
        {
            RecorridoInorden(Raiz);
        }

        private void RecorridoInorden(Nodo nodo)
        {
            if (nodo != null)
            {
                RecorridoInorden(nodo.Izquierda);
                Console.Write(nodo.Valor + " ");
                RecorridoInorden(nodo.Derecha);
            }
        }

        // Método para hacer un recorrido en inorden de manera recursiva
        public void RecorridoInordenRecursivo()
        {
            RecorridoInordenRecursivo(Raiz);
        }

        private void RecorridoInordenRecursivo(Nodo nodo)
        {
            if (nodo != null)
            {
                RecorridoInordenRecursivo(nodo.Izquierda);
                Console.Write(nodo.Valor + " ");
                RecorridoInordenRecursivo(nodo.Derecha);
            }
        }
    }

    // Clase Program con el punto de entrada del programa
    public class Program
    {
        public static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();

            // Insertando elementos en el árbol
            arbol.Insertar(50);
            arbol.Insertar(30);
            arbol.Insertar(70);
            arbol.Insertar(20);
            arbol.Insertar(40);
            arbol.Insertar(60);
            arbol.Insertar(80);

            // Mostrando el recorrido en inorden
            Console.WriteLine("Recorrido en inorden:");
            arbol.RecorridoInorden();  // Debería mostrar los valores en orden ascendente
            Console.WriteLine();

            // También puedes usar el recorrido recursivo
            Console.WriteLine("Recorrido en inorden recursivo:");
            arbol.RecorridoInordenRecursivo();  // Debería mostrar los valores en orden ascendente
            Console.WriteLine();
        }
    }
}
