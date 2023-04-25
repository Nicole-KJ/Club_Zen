using System;
using System.Collections.Generic;
using Entities.Authentication;
using Entities.Utilities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entities.Entities
{
    public partial class BD_Club_ZenContext : IdentityDbContext<ApplicationUser>
    {
        public BD_Club_ZenContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<BD_Club_ZenContext>();
            optionsBuilder.UseSqlServer(Utilities.Util.ConnectionString);
        }

        public BD_Club_ZenContext(DbContextOptions<BD_Club_ZenContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ClubMember> ClubMembers { get; set; } = null!;
        public virtual DbSet<Estado> Estados { get; set; } = null!;
        public virtual DbSet<Evento> Eventos { get; set; } = null!;
        public virtual DbSet<Factura> Facturas { get; set; } = null!;
        public virtual DbSet<LineaFactura> LineaFacturas { get; set; } = null!;
        public virtual DbSet<Mesa> Mesas { get; set; } = null!;
        public virtual DbSet<MetodoPago> MetodoPagos { get; set; } = null!;
        public virtual DbSet<Permiso> Permisos { get; set; } = null!;
        public virtual DbSet<Ranchito> Ranchitos { get; set; } = null!;
        public virtual DbSet<ReservacionEvento> ReservacionEventos { get; set; } = null!;
        public virtual DbSet<ReservacionMesa> ReservacionMesas { get; set; } = null!;
        public virtual DbSet<ReservacionRanchito> ReservacionRanchitos { get; set; } = null!;
        public virtual DbSet<ReservacionTenni> ReservacionTennis { get; set; } = null!;
        public virtual DbSet<TennisCourt> TennisCourts { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<sp_GetAllUsuarios_Result> sp_GetAllUsuarios_Result { get; set; } = null!;
        public virtual DbSet<sp_GetMisReservacionesMesa_Result> sp_GetMisReservacionesMesa_Results { get; set; } = null!;



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Util.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ClubMember>(entity =>
            {
                entity.HasKey(e => e.IdClubMember);

                entity.ToTable("Club_Member");

                entity.Property(e => e.IdClubMember).HasColumnName("id_clubMember");

                entity.Property(e => e.Estado)
                    .HasMaxLength(15)
                    .HasColumnName("estado")
                    .IsFixedLength();

                entity.Property(e => e.FechaFin)
                    .HasColumnType("date")
                    .HasColumnName("fechaFin");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("fechaInicio");

                entity.Property(e => e.Pago)
                    .HasMaxLength(15)
                    .HasColumnName("pago")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.Estado1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("estado")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Evento>(entity =>
            {
                entity.HasKey(e => e.IdEvento);

                entity.Property(e => e.IdEvento).HasColumnName("id_evento");

                entity.Property(e => e.AsistenciaReservada).HasColumnName("asistenciaReservada");

                entity.Property(e => e.CupoMax).HasColumnName("cupoMax");

                entity.Property(e => e.Desc).HasColumnName("desc");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("precio");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.IdFactura);

                entity.Property(e => e.IdFactura).HasColumnName("id_factura");

                entity.Property(e => e.Fecha)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("fecha");

                entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodoPago");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("total");

                entity.HasOne(d => d.IdMetodoPagoNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdMetodoPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Facturas_Metodo_Pago");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Facturas_Usuarios");
            });

            modelBuilder.Entity<LineaFactura>(entity =>
            {
                entity.HasKey(e => e.IdLinea);

                entity.ToTable("Linea_Factura");

                entity.Property(e => e.IdLinea).HasColumnName("id_linea");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(50)
                    .HasColumnName("detalle");

                entity.Property(e => e.IdFactura).HasColumnName("id_factura");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("monto");

                entity.HasOne(d => d.IdFacturaNavigation)
                    .WithMany(p => p.LineaFacturas)
                    .HasForeignKey(d => d.IdFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Linea_Factura_Facturas");
            });

            modelBuilder.Entity<Mesa>(entity =>
            {
                entity.HasKey(e => e.IdMesa);

                entity.Property(e => e.IdMesa).HasColumnName("id_mesa");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            });

            modelBuilder.Entity<MetodoPago>(entity =>
            {
                entity.HasKey(e => e.IdMetodoPago);

                entity.ToTable("Metodo_Pago");

                entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodoPago");

                entity.Property(e => e.CodigoSeguridad).HasColumnName("codigoSeguridad");

                entity.Property(e => e.FechaExp)
                    .HasColumnType("date")
                    .HasColumnName("fechaExp");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.NumTarjeta).HasColumnName("numTarjeta");

                entity.Property(e => e.TipoTarjeta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tipoTarjeta")
                    .IsFixedLength();

                entity.Property(e => e.TitularTarjeta)
                    .HasMaxLength(50)
                    .HasColumnName("titularTarjeta");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.MetodoPagos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Metodo_Pago_Usuarios");
            });

            modelBuilder.Entity<Permiso>(entity =>
            {
                entity.HasKey(e => e.IdPermiso);

                entity.Property(e => e.IdPermiso).HasColumnName("id_permiso");

                entity.Property(e => e.Desc)
                    .HasMaxLength(50)
                    .HasColumnName("desc");
            });

            modelBuilder.Entity<Ranchito>(entity =>
            {
                entity.HasKey(e => e.IdRanchito);

                entity.Property(e => e.IdRanchito).HasColumnName("id_ranchito");

                entity.Property(e => e.Desc)
                    .HasMaxLength(50)
                    .HasColumnName("desc");
            });

            modelBuilder.Entity<ReservacionEvento>(entity =>
            {
                entity.HasKey(e => e.IdReservacionEvento);

                entity.ToTable("Reservacion_Eventos");

                entity.Property(e => e.IdReservacionEvento).HasColumnName("id_reservacionEvento");

                entity.Property(e => e.IdEvento).HasColumnName("id_evento");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

         
                entity.Property(e => e.Personas).HasColumnName("personas");

                entity.HasOne(d => d.IdEventoNavigation)
                    .WithMany(p => p.ReservacionEventos)
                    .HasForeignKey(d => d.IdEvento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservacion_Eventos_Eventos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ReservacionEventos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservacion_Eventos_Usuarios");
            });

            modelBuilder.Entity<ReservacionMesa>(entity =>
            {
                entity.HasKey(e => e.IdReservacionMesa);

                entity.ToTable("Reservacion_Mesa");

                entity.Property(e => e.IdReservacionMesa).HasColumnName("id_reservacionMesa");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaFin");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaInicio");

                entity.Property(e => e.IdMesa).HasColumnName("id_mesa");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Personas).HasColumnName("personas");

                entity.HasOne(d => d.IdMesaNavigation)
                    .WithMany(p => p.ReservacionMesas)
                    .HasForeignKey(d => d.IdMesa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservacion_Mesa_Mesas");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ReservacionMesas)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservacion_Mesa_Usuarios");
            });

            modelBuilder.Entity<ReservacionRanchito>(entity =>
            {
                entity.HasKey(e => e.IdReservacionRanchito);

                entity.ToTable("Reservacion_Ranchito");

                entity.Property(e => e.IdReservacionRanchito).HasColumnName("id_reservacionRanchito");

                entity.Property(e => e.FechaReserva)
                    .HasColumnType("date")
                    .HasColumnName("fechaReserva");

                entity.Property(e => e.IdRanchito).HasColumnName("id_ranchito");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.HasOne(d => d.IdRanchitoNavigation)
                   .WithMany(p => p.ReservacionRanchitos)
                    .HasForeignKey(d => d.IdRanchito)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservacion_Ranchito_Ranchitos");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ReservacionRanchitos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservacion_Ranchito_Usuarios");
            });

            modelBuilder.Entity<ReservacionTenni>(entity =>
            {
                entity.HasKey(e => e.IdReservacionTennis);

                entity.ToTable("Reservacion_Tennis");

                entity.Property(e => e.IdReservacionTennis).HasColumnName("id_reservacionTennis");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaFin");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaInicio");

                entity.Property(e => e.IdTennisCourt).HasColumnName("id_tennisCourt");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.HasOne(d => d.IdTennisCourtNavigation)
                    .WithMany(p => p.ReservacionTennis)
                    .HasForeignKey(d => d.IdTennisCourt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservacion_Tennis_Tennis_Courts");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ReservacionTennis)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservacion_Tennis_Usuarios");
            });

            modelBuilder.Entity<TennisCourt>(entity =>
            {
                entity.HasKey(e => e.IdTennisCourt);

                entity.ToTable("Tennis_Courts");

                entity.Property(e => e.IdTennisCourt).HasColumnName("id_tennisCourt");

                entity.Property(e => e.Desc)
                    .HasMaxLength(50)
                    .HasColumnName("desc");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .HasColumnName("apellido");

                entity.Property(e => e.Cedula).HasColumnName("cedula");

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(20)
                    .HasColumnName("contrasena");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .HasColumnName("correo");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaNacimiento");

                

                entity.Property(e => e.IdClubMember).HasColumnName("id_clubMember");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdPermiso).HasColumnName("id_permiso");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.IdClubMemberNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdClubMember)
                    .HasConstraintName("FK_Usuarios_Club_Member");

                /*entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuarios_Estados");

                entity.HasOne(d => d.IdPermisoNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdPermiso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuarios_Permisos");
                */
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
