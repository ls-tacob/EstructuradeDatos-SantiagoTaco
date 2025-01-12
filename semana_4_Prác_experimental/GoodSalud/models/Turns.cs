namespace GoodSalud.Models
{
    // Clase que representa un turno de un paciente
    public class Turn
    {
        // Propiedad para almacenar la fecha y hora del turno
        public DateTime AppointmentDate { get; set; }
        
        // Propiedad para almacenar el paciente que tiene el turno
        public Patient AssignedPatient { get; set; }
        
        // Propiedad que indica si el turno ha sido confirmado
        public bool IsConfirmed { get; set; }

        // Constructor que inicializa el turno con la fecha, el paciente y el estado de confirmación
        public Turn(DateTime appointmentDate, Patient assignedPatient, bool isConfirmed)
        {
            AppointmentDate = appointmentDate;
            AssignedPatient = assignedPatient;
            IsConfirmed = isConfirmed;
        }

        // Método que devuelve una representación del turno en formato de texto
        public override string ToString()
        {
            return $"Appointment Date: {AppointmentDate}, Patient: {AssignedPatient.Name}, Confirmed: {IsConfirmed}";
        }
    }
}
