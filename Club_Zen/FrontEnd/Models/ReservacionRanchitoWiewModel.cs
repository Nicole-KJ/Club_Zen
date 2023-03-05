namespace FrontEnd.Models
{
    public class ReservacionRanchitoWiewModel
    {
        public int IdReservacionRanchito { get; set; }
        public int IdRanchito { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaReserva { get; set; }
        public byte[] LogFecha { get; set; } = null!;
    }
}
