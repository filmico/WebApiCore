using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Persistence
{
    public partial class RRHHContext : DbContext
    {
        public RRHHContext(DbContextOptions<RRHHContext> options): base(options)
        {
        }        

        public virtual DbSet<Aplicaciones> Aplicaciones { get; set; }
        public virtual DbSet<AplicacionesLog> AplicacionesLog { get; set; }
        public virtual DbSet<Archivos> Archivos { get; set; }
        public virtual DbSet<ArchivosLog> ArchivosLog { get; set; }
        public virtual DbSet<Colores> Colores { get; set; }
        public virtual DbSet<Contenidos> Contenidos { get; set; }
        public virtual DbSet<ContenidosArchivos> ContenidosArchivos { get; set; }
        public virtual DbSet<ContenidosLog> ContenidosLog { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<Grupos> Grupos { get; set; }
        public virtual DbSet<GruposAplicaciones> GruposAplicaciones { get; set; }
        public virtual DbSet<GruposAplicacionesLog> GruposAplicacionesLog { get; set; }
        public virtual DbSet<GruposContenidos> GruposContenidos { get; set; }
        public virtual DbSet<GruposContenidosLog> GruposContenidosLog { get; set; }
        public virtual DbSet<GruposLog> GruposLog { get; set; }
        public virtual DbSet<Iconos> Iconos { get; set; }
        public virtual DbSet<Personas> Personas { get; set; }
        public virtual DbSet<PersonasLog> PersonasLog { get; set; }
        public virtual DbSet<RPersonal> RPersonal { get; set; }
        public virtual DbSet<RPersonalLog> RPersonalLog { get; set; }
        public virtual DbSet<Sectores> Sectores { get; set; }
        public virtual DbSet<SectoresLog> SectoresLog { get; set; }
        public virtual DbSet<TiposContenido> TiposContenido { get; set; }
        public virtual DbSet<Ubicaciones> Ubicaciones { get; set; }
        public virtual DbSet<UbicacionesLog> UbicacionesLog { get; set; }
        public virtual DbSet<VPersonalInfo> VPersonalInfo { get; set; }
        public virtual DbSet<vEstructuraCNV> vEstructuraCNV { get; set; }
        public virtual DbSet<vGruposAplicaciones> vGruposAplicaciones { get; set; }
        public virtual DbSet<vUbicacionesCNV> vUbicacionesCNV { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Aplicaciones>(entity =>
            {
                entity.HasKey(e => e.AplicacionId);

                entity.ToTable("Aplicaciones", "RRHH");

                entity.Property(e => e.Descripcion).HasMaxLength(1000);

                entity.Property(e => e.Link).HasMaxLength(200);

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<AplicacionesLog>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("AplicacionesLog", "RRHH");

                entity.Property(e => e.Descripcion).HasMaxLength(1000);

                entity.Property(e => e.Link).HasMaxLength(200);

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<Archivos>(entity =>
            {
                entity.HasKey(e => e.ArchivoId);

                entity.ToTable("Archivos", "RRHH");

                entity.Property(e => e.Extension).HasMaxLength(10);

                entity.Property(e => e.Nombre).HasMaxLength(300);

                entity.Property(e => e.TipoContenido).HasMaxLength(100);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<ArchivosLog>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("ArchivosLog", "RRHH");

                entity.Property(e => e.Extension).HasMaxLength(10);

                entity.Property(e => e.Nombre).HasMaxLength(300);

                entity.Property(e => e.TipoContenido).HasMaxLength(100);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<Colores>(entity =>
            {
                entity.HasKey(e => e.ColorId);

                entity.ToTable("Colores", "RRHH");

                entity.Property(e => e.Hexa).HasMaxLength(6);

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<Contenidos>(entity =>
            {
                entity.HasKey(e => e.ContenidoId);

                entity.ToTable("Contenidos", "RRHH");

                entity.HasIndex(e => e.TipoContenidoId, "IXFK_Contenidos_TiposContenido");

                entity.Property(e => e.Descripcion).HasMaxLength(4000);

                entity.Property(e => e.Link).HasMaxLength(300);

                entity.Property(e => e.Nombre).HasMaxLength(500);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);

                entity.HasOne(d => d.TipoContenido)
                    .WithMany(p => p.Contenidos)
                    .HasForeignKey(d => d.TipoContenidoId)
                    .HasConstraintName("FK_Contenidos_TiposContenido");
            });

            modelBuilder.Entity<ContenidosArchivos>(entity =>
            {
                entity.HasKey(e => e.ContenidoArchivoId);

                entity.ToTable("ContenidosArchivos", "RRHH");

                entity.HasIndex(e => e.ArchivoId, "IXFK_ContenidosArchivos_Archivos");

                entity.HasIndex(e => e.ContenidoId, "IXFK_ContenidosArchivos_Contenidos");

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);

                entity.HasOne(d => d.Archivo)
                    .WithMany(p => p.ContenidosArchivos)
                    .HasForeignKey(d => d.ArchivoId)
                    .HasConstraintName("FK_ContenidosArchivos_Archivos");

                entity.HasOne(d => d.Contenido)
                    .WithMany(p => p.ContenidosArchivos)
                    .HasForeignKey(d => d.ContenidoId)
                    .HasConstraintName("FK_ContenidosArchivos_Contenidos");
            });

            modelBuilder.Entity<ContenidosLog>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("ContenidosLog", "RRHH");

                entity.Property(e => e.Descripcion).HasMaxLength(4000);

                entity.Property(e => e.Link).HasMaxLength(300);

                entity.Property(e => e.Nombre).HasMaxLength(500);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<Estados>(entity =>
            {
                entity.HasKey(e => e.EstadoId);

                entity.ToTable("Estados", "RRHH");

                entity.Property(e => e.Descripcion).HasMaxLength(250);

                entity.Property(e => e.Prefijo).HasMaxLength(3);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<Grupos>(entity =>
            {
                entity.HasKey(e => e.GrupoId);

                entity.ToTable("Grupos", "RRHH");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<GruposAplicaciones>(entity =>
            {
                entity.ToTable("GruposAplicaciones", "RRHH");

                entity.HasIndex(e => e.AplicacionId, "IXFK_GruposAplicaciones_Aplicaciones");

                entity.HasIndex(e => e.ColorId, "IXFK_GruposAplicaciones_Colores");

                entity.HasIndex(e => e.GrupoId, "IXFK_GruposAplicaciones_Grupos");

                entity.HasIndex(e => e.IconoId, "IXFK_GruposAplicaciones_Iconos");

                entity.Property(e => e.Descripcion).HasMaxLength(1000);

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);

                entity.HasOne(d => d.Aplicacion)
                    .WithMany(p => p.GruposAplicaciones)
                    .HasForeignKey(d => d.AplicacionId)
                    .HasConstraintName("FK_GruposAplicaciones_Aplicaciones");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.GruposAplicaciones)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_GruposAplicaciones_Colores");

                entity.HasOne(d => d.Grupo)
                    .WithMany(p => p.GruposAplicaciones)
                    .HasForeignKey(d => d.GrupoId)
                    .HasConstraintName("FK_GruposAplicaciones_Grupos");

                entity.HasOne(d => d.Icono)
                    .WithMany(p => p.GruposAplicaciones)
                    .HasForeignKey(d => d.IconoId)
                    .HasConstraintName("FK_GruposAplicaciones_Iconos");
            });

            modelBuilder.Entity<GruposAplicacionesLog>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("GruposAplicacionesLog", "RRHH");

                entity.Property(e => e.Descripcion).HasMaxLength(1000);

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<GruposContenidos>(entity =>
            {
                entity.ToTable("GruposContenidos", "RRHH");

                entity.HasIndex(e => e.ColorId, "IXFK_GruposContenidos_Colores");

                entity.HasIndex(e => e.ContenidoId, "IXFK_GruposContenidos_Contenidos");

                entity.HasIndex(e => e.GrupoId, "IXFK_GruposContenidos_Grupos");

                entity.HasIndex(e => e.IconoId, "IXFK_GruposContenidos_Iconos");

                entity.Property(e => e.Descripcion).HasMaxLength(1000);

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.GruposContenidos)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_GruposContenidos_Colores");

                entity.HasOne(d => d.Contenido)
                    .WithMany(p => p.GruposContenidos)
                    .HasForeignKey(d => d.ContenidoId)
                    .HasConstraintName("FK_GruposContenidos_Contenidos");

                entity.HasOne(d => d.Grupo)
                    .WithMany(p => p.GruposContenidos)
                    .HasForeignKey(d => d.GrupoId)
                    .HasConstraintName("FK_GruposContenidos_Grupos");

                entity.HasOne(d => d.Icono)
                    .WithMany(p => p.GruposContenidos)
                    .HasForeignKey(d => d.IconoId)
                    .HasConstraintName("FK_GruposContenidos_Iconos");
            });

            modelBuilder.Entity<GruposContenidosLog>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("GruposContenidosLog", "RRHH");

                entity.Property(e => e.Descripcion).HasMaxLength(1000);

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<GruposLog>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("GruposLog", "RRHH");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<Iconos>(entity =>
            {
                entity.HasKey(e => e.IconoId);

                entity.ToTable("Iconos", "RRHH");

                entity.Property(e => e.Libreria).HasMaxLength(50);

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<Personas>(entity =>
            {
                entity.HasKey(e => e.PersonaId);

                entity.ToTable("Personas", "RRHH");

                entity.Property(e => e.Apellidos).HasMaxLength(200);

                entity.Property(e => e.CUIL).HasMaxLength(11);

                entity.Property(e => e.CorreoElectronico).HasMaxLength(300);

                entity.Property(e => e.Funcion).HasMaxLength(250);

                entity.Property(e => e.Nombres).HasMaxLength(200);

                entity.Property(e => e.Telefono).HasMaxLength(50);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<PersonasLog>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("PersonasLog", "RRHH");

                entity.Property(e => e.Apellidos).HasMaxLength(200);

                entity.Property(e => e.CUIL).HasMaxLength(11);

                entity.Property(e => e.CorreoElectronico).HasMaxLength(300);

                entity.Property(e => e.Funcion).HasMaxLength(250);

                entity.Property(e => e.Nombres).HasMaxLength(200);

                entity.Property(e => e.Telefono).HasMaxLength(50);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<RPersonal>(entity =>
            {
                entity.ToTable("RPersonal", "RRHH");

                entity.HasIndex(e => e.ArchivoId, "IXFK_RPersonal_Archivos");

                entity.HasIndex(e => e.PersonaId, "IXFK_RPersonal_Personas");

                entity.HasIndex(e => e.SectorId, "IXFK_RPersonal_Sectores");

                entity.HasIndex(e => e.UbicacionId, "IXFK_RPersonal_Ubicaciones");

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);

                entity.HasOne(d => d.Archivo)
                    .WithMany(p => p.RPersonal)
                    .HasForeignKey(d => d.ArchivoId)
                    .HasConstraintName("FK_RPersonal_Archivos");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.RPersonal)
                    .HasForeignKey(d => d.PersonaId)
                    .HasConstraintName("FK_RPersonal_Personas");

                entity.HasOne(d => d.Sector)
                    .WithMany(p => p.RPersonal)
                    .HasForeignKey(d => d.SectorId)
                    .HasConstraintName("FK_RPersonal_Sectores");

                entity.HasOne(d => d.Ubicacion)
                    .WithMany(p => p.RPersonal)
                    .HasForeignKey(d => d.UbicacionId)
                    .HasConstraintName("FK_RPersonal_Ubicaciones");
            });

            modelBuilder.Entity<RPersonalLog>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("RPersonalLog", "RRHH");

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<Sectores>(entity =>
            {
                entity.HasKey(e => e.SectorId);

                entity.ToTable("Sectores", "RRHH");

                entity.Property(e => e.Descripcion).HasMaxLength(250);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<SectoresLog>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("SectoresLog", "RRHH");

                entity.Property(e => e.Descripcion).HasMaxLength(250);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<TiposContenido>(entity =>
            {
                entity.HasKey(e => e.TipoContenidoId);

                entity.ToTable("TiposContenido", "RRHH");

                entity.Property(e => e.Descripcion).HasMaxLength(4000);

                entity.Property(e => e.Nombre).HasMaxLength(500);

                entity.Property(e => e.Prefijo).HasMaxLength(5);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<Ubicaciones>(entity =>
            {
                entity.HasKey(e => e.UbicacionId);

                entity.ToTable("Ubicaciones", "RRHH");

                entity.Property(e => e.Descripcion).HasMaxLength(250);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<UbicacionesLog>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("UbicacionesLog", "RRHH");

                entity.Property(e => e.Descripcion).HasMaxLength(250);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<VPersonalInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VPersonalInfo", "RRHH");

                entity.Property(e => e.Apellidos).HasMaxLength(200);

                entity.Property(e => e.ApellidoyNombre).HasMaxLength(402);

                entity.Property(e => e.CUIL).HasMaxLength(11);

                entity.Property(e => e.CorreoElectronico).HasMaxLength(300);

                entity.Property(e => e.Estado).HasMaxLength(250);

                entity.Property(e => e.Funcion).HasMaxLength(250);

                entity.Property(e => e.Nombres).HasMaxLength(200);

                entity.Property(e => e.PrefijoEstado).HasMaxLength(3);

                entity.Property(e => e.Sector).HasMaxLength(250);

                entity.Property(e => e.SectorDependeDe).HasMaxLength(250);

                entity.Property(e => e.Telefono).HasMaxLength(50);

                entity.Property(e => e.Ubicacion).HasMaxLength(500);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<vEstructuraCNV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEstructuraCNV", "RRHH");

                entity.Property(e => e.Descripcion).HasMaxLength(250);
            });

            modelBuilder.Entity<vGruposAplicaciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vGruposAplicaciones", "RRHH");

                entity.Property(e => e.Aplicacion).HasMaxLength(100);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.DescripcionAplicacion).HasMaxLength(1000);

                entity.Property(e => e.DescripcionGrupoApp).HasMaxLength(1000);

                entity.Property(e => e.Grupo).HasMaxLength(100);

                entity.Property(e => e.Hexa).HasMaxLength(6);

                entity.Property(e => e.Icono).HasMaxLength(100);

                entity.Property(e => e.Libreria).HasMaxLength(50);

                entity.Property(e => e.Link).HasMaxLength(200);

                entity.Property(e => e.NombreGrupoApp).HasMaxLength(100);

                entity.Property(e => e.UsuarioAD).HasMaxLength(100);
            });

            modelBuilder.Entity<vUbicacionesCNV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUbicacionesCNV", "RRHH");

                entity.Property(e => e.Descripcion).HasMaxLength(250);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
