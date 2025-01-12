namespace GoodSalud.Models
{
    // Clase que representa a un paciente
    public class Patient
    {
        // Propiedad para almacenar el nombre del paciente
        public string Name { get; set; }
        
        // Propiedad para almacenar la edad del paciente
        public int Age { get; set; }
        
        // Propiedad para almacenar el número de teléfono del paciente
        public string PhoneNumber { get; set; }

        // Constructor que inicializa las propiedades de la clase
        public Patient(string name, int age, string phoneNumber)
        {
            // Asigna los valores proporcionados al crear el paciente
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
        }

        // Método que devuelve una representación del paciente en formato de texto
        public override string ToString()
        {
            // Devuelve una cadena con el nombre, edad y teléfono del paciente
            return $"Name: {Name}, Age: {Age}, Phone: {PhoneNumber}";
        }
    }
}
