// Clase que representa un producto con sus propiedades y métodos asociados
public class Producto
{
    public int Id { get; set; }           // Identificador único del producto
    public string Nombre { get; set; }    // Nombre del producto
    public string Unidad { get; set; }    // Unidad de medida (ej. pieza, kg)
    public double PrecioPorUnidad { get; set; }  // Precio por unidad
    public double PrecioPorDocena { get; set; }  // Precio por docena
    public double PrecioMayoreo { get; set; }    // Precio al mayoreo

    // Constructor para inicializar un producto
    public Producto(int id, string nombre, string unidad, double precioPorUnidad, double precioPorDocena, double precioMayoreo)
    {
        Id = id;
        Nombre = nombre;
        Unidad = unidad;
        PrecioPorUnidad = precioPorUnidad;
        PrecioPorDocena = precioPorDocena;
        PrecioMayoreo = precioMayoreo;
    }

    // Método para mostrar la información del producto en la consola
    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Unidad: {Unidad}");
        Console.WriteLine($"Precio por unidad: {PrecioPorUnidad:C}");
        Console.WriteLine($"Precio por docena: {PrecioPorDocena:C}");
        Console.WriteLine($"Precio al mayoreo: {PrecioMayoreo:C}");
    }

    // Método para guardar un producto en un archivo de texto
    public static void GuardarEnArchivo(List<Producto> productos)
    {
        using (StreamWriter writer = new StreamWriter("productos.txt", true))
        {
            foreach (var producto in productos)
            {
                writer.WriteLine($"{producto.Id},{producto.Nombre},{producto.Unidad},{producto.PrecioPorUnidad},{producto.PrecioPorDocena},{producto.PrecioMayoreo}");
            }
        }
    }
}
