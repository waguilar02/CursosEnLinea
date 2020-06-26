using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CursosEnLinea.Models
{
    public partial class CursosOnlineContext : DbContext
    {
        public CursosOnlineContext()
        {
        }

        public CursosOnlineContext(DbContextOptions<CursosOnlineContext> options)
            : base(options)
        {
        }


        public virtual DbSet<vm_RangoEdad> Rangos_Edad { get; set; }
        public virtual DbSet<vm_RangoGenero> Rangos_Genero { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Cursos> Cursos { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
        public virtual DbSet<LineaCarrera> LineaCarrera { get; set; }
        public virtual DbSet<Modalidades> Modalidades { get; set; }
        public virtual DbSet<Personas> Personas { get; set; }
        public virtual DbSet<PersonasCursos> PersonasCursos { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<TiposDeCurso> TiposDeCurso { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=CursosOnline;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorias>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.Property(e => e.IdCategoria).HasColumnName("Id_Categoria");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vm_RangoEdad>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<vm_RangoGenero>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Cursos>(entity =>
            {
                entity.HasKey(e => e.IdCurso);

                entity.Property(e => e.IdCurso).HasColumnName("Id_Curso");

                entity.Property(e => e.Duracion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LineaCarrera).HasColumnName("Linea_carrera");

                entity.Property(e => e.NombreCurso)
                    .HasColumnName("Nombre_Curso")
                    .HasMaxLength(1200)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCurso).HasColumnName("Tipo_Curso");

                entity.HasOne(d => d.CategoriaNavigation)
                    .WithMany(p => p.Cursos)
                    .HasForeignKey(d => d.Categoria)
                    .HasConstraintName("FK_Cursos_Categorias");

                entity.HasOne(d => d.LineaCarreraNavigation)
                    .WithMany(p => p.Cursos)
                    .HasForeignKey(d => d.LineaCarrera)
                    .HasConstraintName("FK_Cursos_Linea_Carrera");

                entity.HasOne(d => d.ModalidadNavigation)
                    .WithMany(p => p.Cursos)
                    .HasForeignKey(d => d.Modalidad)
                    .HasConstraintName("FK_Cursos_Modalidades");

                entity.HasOne(d => d.TipoCursoNavigation)
                    .WithMany(p => p.Cursos)
                    .HasForeignKey(d => d.TipoCurso)
                    .HasConstraintName("FK_Cursos_Tipos_De_Curso");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.TipoGenero);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LineaCarrera>(entity =>
            {
                entity.HasKey(e => e.IdLineaCarrera);

                entity.ToTable("Linea_Carrera");

                entity.Property(e => e.IdLineaCarrera).HasColumnName("Id_Linea_Carrera");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Modalidades>(entity =>
            {
                entity.HasKey(e => e.IdModalidad);

                entity.Property(e => e.IdModalidad).HasColumnName("Id_Modalidad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Personas>(entity =>
            {
                entity.HasKey(e => e.NumeroIdentificacion);

                entity.Property(e => e.NumeroIdentificacion)
                    .HasColumnName("Numero_Identificacion")
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Hobbies)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LugarNacimiento)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.GeneroNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.Genero)
                    .HasConstraintName("FK_Personas_Genero");

                entity.HasOne(d => d.RolNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.Rol)
                    .HasConstraintName("FK_Personas_Roles");
            });

            modelBuilder.Entity<PersonasCursos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Personas_Cursos");

                entity.Property(e => e.IdCurso).HasColumnName("Id_Curso");

                entity.Property(e => e.IdPersona).HasColumnName("Id_Persona");

                entity.HasOne(d => d.IdCursoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCurso)
                    .HasConstraintName("FK_Personas_Cursos_Cursos");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK_Personas_Cursos_Personas");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.IdRol);

                entity.Property(e => e.IdRol).HasColumnName("Id_Rol");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposDeCurso>(entity =>
            {
                entity.HasKey(e => e.IdTipoCurso);

                entity.ToTable("Tipos_De_Curso");

                entity.Property(e => e.IdTipoCurso).HasColumnName("Id_Tipo_Curso");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
