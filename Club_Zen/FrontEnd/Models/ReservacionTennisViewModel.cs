namespace FrontEnd.Models
{
    public class ReservacionTennisViewModel
    {
        public int IdReservacionTennis { get; set; }
        public int IdTennisCourt { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public byte[] LogFecha { get; set; } = null!;
    }
}
