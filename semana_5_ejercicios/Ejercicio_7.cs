using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Inicializar una lista con el abecedario
        List<char> abecedario = new List<char>();

        // Llenar la lista con las letras del abecedario
        for (char letra = 'a'; letra <= 'z'; letra++)
        {
            abecedario.Add(letra);
        }

        // Eliminar las letras en posiciones múltiplos de 3
        for (int i = abecedario.Count - 1; i >= 0; i--)
        {
            if ((i + 1) % 3 == 0)
            {
                abecedario.RemoveAt(i);
            }
        }

        // Mostrar la lista resultante
        Console.WriteLine("Lista resultante del abecedario:");
        Console.WriteLine(string.Join(", ", abecedario));

        // Pausar para ver el resultado
        Console.ReadLine();
    }
}
