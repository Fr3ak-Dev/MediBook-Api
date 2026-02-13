namespace MediBookAPI.Models

{
    public class Cita

    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
        public DateTime FechaHora { get; set; }
        public string Motivo { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;  //  "Pendiente", "Confirmada", "Cancelada", "Completada"
        public string Observaciones { get; set; } = string.Empty;
    }
}