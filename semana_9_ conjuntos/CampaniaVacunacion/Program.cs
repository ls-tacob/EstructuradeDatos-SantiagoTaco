// Program.cs
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Registrar el proveedor de codificación
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

        // Crear ciudadanos
        var ciudadanos = new HashSet<Ciudadano>
        {
            new Ciudadano("Juan", "Ninguna"),
            new Ciudadano("Pedro", "Pfizer"),
            new Ciudadano("Maria", "AstraZeneca"),
            new Ciudadano("Ana", "Ambas"),
            new Ciudadano("Luis", "Pfizer"),
            new Ciudadano("Carlos", "AstraZeneca")
        };

        // Crear conjuntos de vacunados
        var noVacunados = new HashSet<Ciudadano>(ciudadanos.Where(c => c.VacunaRecibida == "Ninguna"));
        var vacunadosAmbas = new HashSet<Ciudadano>(ciudadanos.Where(c => c.VacunaRecibida == "Ambas"));
        var soloPfizer = new HashSet<Ciudadano>(ciudadanos.Where(c => c.VacunaRecibida == "Pfizer"));
        var soloAstraZeneca = new HashSet<Ciudadano>(ciudadanos.Where(c => c.VacunaRecibida == "AstraZeneca"));

        // Generar el reporte
        Reporte.GenerarReporte(noVacunados, vacunadosAmbas, soloPfizer, soloAstraZeneca);

        Console.WriteLine("Reporte generado correctamente.");
    }
}
