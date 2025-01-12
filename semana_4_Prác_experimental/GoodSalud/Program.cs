using GoodSalud.Models;

class Program
{
    static void Main(string[] args)
    {
        // Creamos una agenda vacía
        var agenda = new Agenda();

        // Ciclo para mostrar el menú de opciones
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a la Agenda de Turnos GoodSalud");
            Console.WriteLine("1. Ver todos los turnos");
            Console.WriteLine("2. Agregar un nuevo turno");
            Console.WriteLine("3. Buscar turnos por fecha");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción (1-4): ");
            
            string option = Console.ReadLine();

            if (option == "1")
            {
                // Mostrar todos los turnos
                Console.WriteLine("\nAgenda de Turnos:");
                agenda.DisplayAgenda();
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
            else if (option == "2")
            {
                // Agregar un nuevo turno
                Console.Write("\nIngrese el nombre del paciente: ");
                string patientName = Console.ReadLine();
                Console.Write("Ingrese la fecha del turno (YYYY-MM-DD HH:MM): ");
                DateTime appointmentDate = DateTime.Parse(Console.ReadLine());
                Console.Write("¿Está confirmado? (true/false): ");
                bool isConfirmed = bool.Parse(Console.ReadLine());

                var patient = new Patient(patientName, 0, ""); // Edad y teléfono por ahora no son requeridos
                var newTurn = new Turn(appointmentDate, patient, isConfirmed);
                agenda.AddTurn(newTurn);

                Console.WriteLine("\nTurno agregado con éxito.");
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
            else if (option == "3")
            {
                // Buscar turnos por fecha
                Console.Write("\nIngrese la fecha (YYYY-MM-DD) para buscar los turnos: ");
                DateTime searchDate = DateTime.Parse(Console.ReadLine());
                var turnsOnDate = agenda.GetTurnsByDate(searchDate);

                Console.WriteLine("\nTurnos para el " + searchDate.ToString("yyyy-MM-dd") + ":");
                if (turnsOnDate.Count > 0)
                {
                    foreach (var turn in turnsOnDate)
                    {
                        Console.WriteLine(turn);
                    }
                }
                else
                {
                    Console.WriteLine("No hay turnos para esa fecha.");
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
            else if (option == "4")
            {
                // Salir del programa
                Console.WriteLine("\nGracias por usar la Agenda de Turnos GoodSalud.");
                break;
            }
            else
            {
                Console.WriteLine("\nOpción no válida. Presione cualquier tecla para intentar nuevamente.");
                Console.ReadKey();
            }
        }
    }
}
