using System;

public class Hanoi
{
    public static void MoveDisks(int n, char from, char to, char auxiliary)
    {
        if (n == 1)
        {
            Console.WriteLine($"Mueva el disco 1 desde {from} hasta {to}");
            return;
        }
        MoveDisks(n - 1, from, auxiliary, to);
        Console.WriteLine($"Mueva el disco {n} desde {from} hasta {to}");
        MoveDisks(n - 1, auxiliary, to, from);
    }

    public static void Main()
    {
        int n = 3; // Número de discos
        MoveDisks(n, 'A', 'C', 'B');
    }
}
