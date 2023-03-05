namespace FrontEnd.Models
{
    public class UsuarioViewModel
    {
        public int IdUsuario { get; set; }
        public int IdPermiso { get; set; }
        public int IdEstado { get; set; }
        public int? IdClubMember { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; } = null!;
        public string Contrasena { get; set; } = null!;
        public byte[] FechaRegistro { get; set; } = null!;

       
    }
}
