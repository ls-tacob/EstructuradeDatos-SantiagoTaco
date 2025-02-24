// Reporte.cs
using System;
using System.Collections.Generic;

public static class Reporte
{
    public static void GenerarReporte(HashSet<Ciudadano> noVacunados, HashSet<Ciudadano> vacunadosAmbas, HashSet<Ciudadano> soloPfizer, HashSet<Ciudadano> soloAstraZeneca)
    {
        Console.WriteLine("Reporte de vacunación:");
        Console.WriteLine("-------------------------");
        Console.WriteLine($"Ciudadanos no vacunados: {noVacunados.Count}");
        Console.WriteLine($"Ciudadanos vacunados con ambas vacunas: {vacunadosAmbas.Count}");
        Console.WriteLine($"Ciudadanos solo vacunados con Pfizer: {soloPfizer.Count}");
        Console.WriteLine($"Ciudadanos solo vacunados con AstraZeneca: {soloAstraZeneca.Count}");

        // Aquí puedes agregar la lógica para generar un reporte en PDF si lo deseas
    }
}
