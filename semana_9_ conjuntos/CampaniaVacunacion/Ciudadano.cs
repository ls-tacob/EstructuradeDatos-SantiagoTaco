// Ciudadano.cs
public class Ciudadano
{
    public string Nombre { get; set; }
    public string VacunaRecibida { get; set; }

    public Ciudadano(string nombre, string vacunaRecibida)
    {
        Nombre = nombre;
        VacunaRecibida = vacunaRecibida;
    }
}
