namespace GoodSalud.Models
{
    // Interfaz para la gestión de la agenda de turnos
    public interface IAgenda
    {
        void AddTurn(Turn turn);                      // Agrega un turno
        List<Turn> GetAllTurns();                     // Obtiene todos los turnos
        List<Turn> GetTurnsByDate(DateTime date);     // Obtiene turnos por fecha
        void DisplayAgenda();                         // Muestra la agenda completa
    }
}
