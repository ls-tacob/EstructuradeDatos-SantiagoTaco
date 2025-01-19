using System;

public class ListaEnlazada
{
    private Nodo? cabeza; // Cabeza puede ser null

    public ListaEnlazada()
    {
        cabeza = null;
    }

    // Función para agregar un nodo al final de la lista
    public void AgregarAlFinal(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);

        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            Nodo? actual = cabeza;
            while (actual?.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
    }

    // Función para agregar un nodo al inicio de la lista
    public void AgregarAlInicio(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        nuevoNodo.Siguiente = cabeza;
        cabeza = nuevoNodo;
    }

    // Función para obtener el número de elementos de la lista
    public int ObtenerLongitud()
    {
        int contador = 0;
        Nodo? actual = cabeza;
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }

    // Función para imprimir los elementos de la lista
    public void ImprimirLista()
    {
        Nodo? actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Valor + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }
}
