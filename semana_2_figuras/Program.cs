using System; // Necesario para usar Console y otras clases básicas de .NET

class Program
{
    static void Main(string[] args)
    {
        // Pedir al usuario el radio del círculo
        Console.Write("Ingrese el radio del círculo: "); // Mostrar mensaje
        double radio = Convert.ToDouble(Console.ReadLine()); // Leer input del usuario y convertirlo a double

        // Crear un objeto Circulo con el radio ingresado
        Circulo miCirculo = new Circulo(radio);
        Console.WriteLine("Área del círculo: " + miCirculo.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + miCirculo.CalcularPerimetro());

        // Pedir al usuario el lado del cuadrado
        Console.Write("\nIngrese el lado del cuadrado: "); // Mostrar mensaje
        double lado = Convert.ToDouble(Console.ReadLine()); // Leer input del usuario y convertirlo a double

        // Crear un objeto Cuadrado con el lado ingresado
        Cuadrado miCuadrado = new Cuadrado(lado);
        Console.WriteLine("Área del cuadrado: " + miCuadrado.CalcularArea());
        Console.WriteLine("Perímetro del cuadrado: " + miCuadrado.CalcularPerimetro());
    }
}
