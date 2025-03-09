using System;
using System.Collections.Generic;

public class Torneo
{
    public List<Equipo> Equipos { get; set; }

    public Torneo()
    {
        Equipos = new List<Equipo>();
    }

    public void AgregarEquipo(Equipo equipo)
    {
        Equipos.Add(equipo);
    }

    public void MostrarEquipos()
    {
        Console.WriteLine("Equipos Registrados:");
        foreach (var equipo in Equipos)
        {
            Console.WriteLine(equipo.Nombre);
            equipo.MostrarJugadores(); // Mostrar jugadores por equipo
        }
    }
}
