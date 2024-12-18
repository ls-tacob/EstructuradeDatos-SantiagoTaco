using System; // Importa funcionalidades básicas de .NET, matemáticas, entradas/salidas

public class Circulo // Definimos una clase 
{
    private double radio; // Declaramos un atributo privado para almacenar el radio 

    // Constructor de la clase Circulo, se ejecuta al crear un objeto y asigna un valor al radio
    public Circulo(double radio)
    {
        this.radio = radio; // El "this" se usa para referirse al atributo de la clase
    }

    // Método que calcula el área del círculo
    public double CalcularArea()
    {
        return Math.PI * radio * radio; // Fórmula para el área del círculo: π * radio^2
    }

    // Método que calcula el perímetro del círculo
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio; // Fórmula para el perímetro: 2 * π * radio
    }
}
