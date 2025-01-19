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
            cabeza = nuevoNodo; // Si la lista está vacía, el nuevo nodo es la cabeza
        }
        else
        {
            Nodo? actual = cabeza; // Nodo actual empieza en la cabeza
            while (actual?.Siguiente != null) // Usamos ? para evitar desreferenciar null
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
    }

    // Función para obtener el número de elementos en la lista
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
            actual = actual?.Siguiente;  // Usamos el operador de nulidad para evitar el warning
        }
        Console.WriteLine();
    }


}
