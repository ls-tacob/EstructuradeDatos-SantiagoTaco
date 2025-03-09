public class Jugador
{
    public string Nombre { get; set; }
    public string Posicion { get; set; }

    public Jugador(string nombre, string posicion)
    {
        Nombre = nombre;
        Posicion = posicion;
    }
}
