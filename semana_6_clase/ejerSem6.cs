#nullable enable
using System;

public class Nodo
{
    public int Data;
    public Nodo? Next;
    public Nodo? Prev;

    public Nodo(int data)
    {
        this.Data = data;
        this.Next = null;
        this.Prev = null;
    }
}

public class ListaDoble
{
    private Nodo? head;
    private Nodo? tail;

    public ListaDoble()
    {
        head = tail = null;
    }

    public void InsertarFinal(int dato)
    {
        var nuevoNodo = new Nodo(dato);
        if (tail == null)
        {
            head = tail = nuevoNodo;
        }
        else
        {
            tail.Next = nuevoNodo;
            nuevoNodo.Prev = tail;
            tail = nuevoNodo;
        }
    }

    public void DibujarLista()
    {
        Nodo? actual = head;
        while (actual != null)
        {
            Console.Write($"[{actual.Data}] <-> ");
            actual = actual.Next;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var lista = new ListaDoble();

        // Insertar elementos al final
        lista.InsertarFinal(10);
        lista.InsertarFinal(20);
        lista.InsertarFinal(30);

        // Dibujar la lista
        Console.WriteLine("Lista doblemente enlazada:");
        lista.DibujarLista();
    }
}
