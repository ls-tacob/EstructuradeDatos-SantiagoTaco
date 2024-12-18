using System; // Importa funcionalidades básicas de .NET

public class Cuadrado // Definimos una clase llamada Cuadrado
{
    private double lado; // Declaramos un atributo privado para almacenar la longitud del lado del cuadrado
    // Constructor de la clase Cuadrado, se ejecuta al crear un objeto y asigna un valor al lado
    public Cuadrado(double lado)
    {
        this.lado = lado; // El "this" se refiere al atributo de la clase
    }
    // Método que calcula el área del cuadrado
    public double CalcularArea()
    {
        return lado * lado; // Fórmula para el área del cuadrado: lado^2
    }
    // Método que calcula el perímetro del cuadrado
    public double CalcularPerimetro()
    {
        return 4 * lado; // Fórmula para el perímetro: 4 * lado
    }
}
