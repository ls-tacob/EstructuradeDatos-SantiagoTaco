namespace GoodSalud.Models
{
    // Clase que maneja los turnos de los pacientes, implementa IAgenda
    public class Agenda : IAgenda
    {
        private List<Turn> turns;

        // Constructor que inicializa la lista de turnos
        public Agenda()
        {
            turns = new List<Turn>();
        }

        // Implementación del método AddTurn
        public void AddTurn(Turn turn)
        {
            turns.Add(turn);
        }

        // Implementación del método GetAllTurns
        public List<Turn> GetAllTurns()
        {
            return turns;
        }

        // Implementación del método GetTurnsByDate
        public List<Turn> GetTurnsByDate(DateTime date)
        {
            return turns.Where(t => t.AppointmentDate.Date == date.Date).ToList();
        }

        // Implementación del método DisplayAgenda
        public void DisplayAgenda()
        {
            foreach (var turn in turns)
            {
                Console.WriteLine(turn);
            }
        }
    }
}
