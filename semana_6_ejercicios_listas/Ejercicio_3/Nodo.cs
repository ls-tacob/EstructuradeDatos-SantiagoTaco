using System;

public class Nodo
{
    public int Valor { get; set; }
    public Nodo? Siguiente { get; set; } // Siguiente puede ser null

    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}
