using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Usuario
    {
        public Usuario()
        {
            Facturas = new HashSet<Factura>();
            MetodoPagos = new HashSet<MetodoPago>();
            ReservacionEventos = new HashSet<ReservacionEvento>();
            ReservacionMesas = new HashSet<ReservacionMesa>();
            ReservacionRanchitos = new HashSet<ReservacionRanchito>();
            ReservacionTennis = new HashSet<ReservacionTenni>();
        }

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
        public DateTime FechaRegistro { get; set; }

        public virtual ClubMember? IdClubMemberNavigation { get; set; }
        //public virtual Estado IdEstadoNavigation { get; set; } 
        //public virtual Permiso IdPermisoNavigation { get; set; } 
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<MetodoPago> MetodoPagos { get; set; }
        public virtual ICollection<ReservacionEvento> ReservacionEventos { get; set; }
        public virtual ICollection<ReservacionMesa> ReservacionMesas { get; set; }
        public virtual ICollection<ReservacionRanchito> ReservacionRanchitos { get; set; }
        public virtual ICollection<ReservacionTenni> ReservacionTennis { get; set; }
    }
}
