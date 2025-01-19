using System;

class Program
{
    // Función para verificar si un número es primo
    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
                return false;
        }
        return true;
    }

    // Función para verificar si un número es Armstrong
    static bool EsArmstrong(int numero)
    {
        int suma = 0;
        int temp = numero;
        int cantidadDeDigitos = numero.ToString().Length;

        while (temp > 0)
        {
            int digito = temp % 10;
            suma += (int)Math.Pow(digito, cantidadDeDigitos);
            temp /= 10;
        }

        return suma == numero;
    }

    static void Main()
    {
        ListaEnlazada listaPrimos = new ListaEnlazada();
        ListaEnlazada listaArmstrong = new ListaEnlazada();

        // Rellenar las listas con números entre 1 y 100
        for (int i = 1; i <= 100; i++)
        {
            if (EsPrimo(i))
                listaPrimos.AgregarAlFinal(i);

            if (EsArmstrong(i))
                listaArmstrong.AgregarAlInicio(i);
        }

        // Imprimir los resultados
        Console.WriteLine("Lista de números primos:");
        listaPrimos.ImprimirLista();
        Console.WriteLine("Lista de números Armstrong:");
        listaArmstrong.ImprimirLista();

        // Mostrar el número de elementos en cada lista
        Console.WriteLine($"Número de elementos en la lista de primos: {listaPrimos.ObtenerLongitud()}");
        Console.WriteLine($"Número de elementos en la lista de Armstrong: {listaArmstrong.ObtenerLongitud()}");

        // Comparar las listas
        if (listaPrimos.ObtenerLongitud() > listaArmstrong.ObtenerLongitud())
            Console.WriteLine("La lista de primos tiene más elementos.");
        else if (listaArmstrong.ObtenerLongitud() > listaPrimos.ObtenerLongitud())
            Console.WriteLine("La lista de Armstrong tiene más elementos.");
        else
            Console.WriteLine("Ambas listas tienen el mismo número de elementos.");
    }
}
