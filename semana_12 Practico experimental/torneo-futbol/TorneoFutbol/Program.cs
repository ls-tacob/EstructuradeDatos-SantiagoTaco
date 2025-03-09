using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear el torneo
        var torneo = new Torneo();

        // Crear equipos
        var equipoA = new Equipo("Equipo A");
        var equipoB = new Equipo("Equipo B");

        // Crear jugadores
        var jugadorA1 = new Jugador("Juan", "Delantero");
        var jugadorA2 = new Jugador("Carlos", "Defensa");
        var jugadorB1 = new Jugador("Pedro", "Portero");

        // Agregar jugadores a los equipos
        equipoA.AgregarJugador(jugadorA1);
        equipoA.AgregarJugador(jugadorA2);
        equipoB.AgregarJugador(jugadorB1);

        // Agregar equipos al torneo
        torneo.AgregarEquipo(equipoA);
        torneo.AgregarEquipo(equipoB);

        // Mostrar los equipos y sus jugadores
        torneo.MostrarEquipos();

        // Pausar para que el usuario vea los resultados
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey(); // Espera una tecla antes de cerrar
    }
}
