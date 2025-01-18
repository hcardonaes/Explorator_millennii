using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Explorator_millennii.Models;

public partial class MillenniumContext : DbContext
{
    public MillenniumContext()
    {
    }

    public MillenniumContext(DbContextOptions<MillenniumContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["MillenniumDb"].ConnectionString;
            optionsBuilder.UseSqlite(connectionString);
        }
    }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<Institucione> Instituciones { get; set; }

    public virtual DbSet<LazosFamiliare> LazosFamiliares { get; set; }

    public virtual DbSet<Lugare> Lugares { get; set; }

    public virtual DbSet<Personaje> Personajes { get; set; }

    public virtual DbSet<ProtagonismosDeEvento> ProtagonismosDeEventos { get; set; }

    public virtual DbSet<RelacionesPersonale> RelacionesPersonales { get; set; }

    public virtual DbSet<RolPersonaje> RolPersonajes { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<TipoParentesco> TipoParentescos { get; set; }

    public virtual DbSet<TiposDeCargo> TiposDeCargos { get; set; }

    public virtual DbSet<TiposRelacionesPersonale> TiposRelacionesPersonales { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    if (!optionsBuilder.IsConfigured)
    //    {
    //        optionsBuilder.UseSqlite("Name=C:\\Users\\Ofel\\Source\\Repos\\Explorator_millennii\\Data\\Millennium.db");
    //    }
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.ToTable("cargos");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.InstitucionId).HasColumnName("institucion_id");
            entity.Property(e => e.PersonajeId).HasColumnName("personaje_id");
            entity.Property(e => e.TipoCargoId).HasColumnName("tipo_cargo_id");

            entity.HasOne(d => d.Institucion).WithMany(p => p.Cargos)
                .HasForeignKey(d => d.InstitucionId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Personaje).WithMany(p => p.Cargos)
                .HasForeignKey(d => d.PersonajeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TipoCargo).WithMany(p => p.Cargos)
                .HasForeignKey(d => d.TipoCargoId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.ToTable("eventos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion).HasColumnName("descripcion");
            entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.LugarId).HasColumnName("lugar_id");
            entity.Property(e => e.Nombre).HasColumnName("nombre");

            entity.HasOne(d => d.Lugar).WithMany(p => p.Eventos).HasForeignKey(d => d.LugarId);
        });

        modelBuilder.Entity<Institucione>(entity =>
        {
            entity.ToTable("instituciones");

            entity.HasIndex(e => e.Nombre, "IX_instituciones_nombre").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion).HasColumnName("descripcion");
            entity.Property(e => e.Nombre).HasColumnName("nombre");
        });

        modelBuilder.Entity<LazosFamiliare>(entity =>
        {
            entity.ToTable("lazosFamiliares");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.PersonajeId1).HasColumnName("personaje_id1");
            entity.Property(e => e.PersonajeId2).HasColumnName("personaje_id2");
            entity.Property(e => e.TipoRelacionId).HasColumnName("tipo_relacion_id");

            entity.HasOne(d => d.PersonajeId1Navigation).WithMany(p => p.LazosFamiliarePersonajeId1Navigations)
                .HasForeignKey(d => d.PersonajeId1)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.PersonajeId2Navigation).WithMany(p => p.LazosFamiliarePersonajeId2Navigations)
                .HasForeignKey(d => d.PersonajeId2)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TipoRelacion).WithMany(p => p.LazosFamiliares)
                .HasForeignKey(d => d.TipoRelacionId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Lugare>(entity =>
        {
            entity.ToTable("lugares");

            entity.HasIndex(e => e.Nombre, "IX_lugares_nombre").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion).HasColumnName("descripcion");
            entity.Property(e => e.Latitud).HasColumnName("latitud");
            entity.Property(e => e.Longitud).HasColumnName("longitud");
            entity.Property(e => e.Nombre).HasColumnName("nombre");
        });

        modelBuilder.Entity<Personaje>(entity =>
        {
            entity.ToTable("personajes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellido).HasColumnName("apellido");
            entity.Property(e => e.Biografia).HasColumnName("biografia");
            entity.Property(e => e.FechaMuerte).HasColumnName("fecha_muerte");
            entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
            entity.Property(e => e.Importancia).HasColumnName("importancia");
            entity.Property(e => e.Mote).HasColumnName("mote");
            entity.Property(e => e.Nombre).HasColumnName("nombre");
        });

        modelBuilder.Entity<ProtagonismosDeEvento>(entity =>
        {
            entity.ToTable("protagonismos_de_eventos");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Descripcion).HasColumnName("descripcion");
            entity.Property(e => e.EventoId).HasColumnName("evento_id");
            entity.Property(e => e.PersonajeId).HasColumnName("personaje_id");
            entity.Property(e => e.RolId).HasColumnName("rol_id");

            entity.HasOne(d => d.Evento).WithMany(p => p.ProtagonismosDeEventos)
                .HasForeignKey(d => d.EventoId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Personaje).WithMany(p => p.ProtagonismosDeEventos)
                .HasForeignKey(d => d.PersonajeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Rol).WithMany(p => p.ProtagonismosDeEventos)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<RelacionesPersonale>(entity =>
        {
            entity.ToTable("relacionesPersonales");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.PersonajeId1).HasColumnName("personaje_id1");
            entity.Property(e => e.PersonajeId2).HasColumnName("personaje_id2");
            entity.Property(e => e.TipoRelacionId).HasColumnName("tipo_relacion_id");

            entity.HasOne(d => d.PersonajeId1Navigation).WithMany(p => p.RelacionesPersonalePersonajeId1Navigations)
                .HasForeignKey(d => d.PersonajeId1)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.PersonajeId2Navigation).WithMany(p => p.RelacionesPersonalePersonajeId2Navigations)
                .HasForeignKey(d => d.PersonajeId2)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TipoRelacion).WithMany(p => p.RelacionesPersonales)
                .HasForeignKey(d => d.TipoRelacionId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<RolPersonaje>(entity =>
        {
            entity.ToTable("rolPersonajes");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.EventoId).HasColumnName("evento_id");
            entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.PersonajeId).HasColumnName("personaje_id");
            entity.Property(e => e.RolId).HasColumnName("rol_id");

            entity.HasOne(d => d.Evento).WithMany(p => p.RolPersonajes).HasForeignKey(d => d.EventoId);

            entity.HasOne(d => d.Personaje).WithMany(p => p.RolPersonajes)
                .HasForeignKey(d => d.PersonajeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Rol).WithMany(p => p.RolPersonajes)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion).HasColumnName("descripcion");
            entity.Property(e => e.Nombre).HasColumnName("nombre");
        });

        modelBuilder.Entity<TipoParentesco>(entity =>
        {
            entity.ToTable("tipoParentesco");

            entity.HasIndex(e => e.Nombre, "IX_tipoParentesco_nombre").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre).HasColumnName("nombre");
            entity.Property(e => e.Reciproca).HasColumnName("reciproca");
        });

        modelBuilder.Entity<TiposDeCargo>(entity =>
        {
            entity.ToTable("tipos_de_cargos");

            entity.HasIndex(e => e.Nombre, "IX_tipos_de_cargos_nombre").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre).HasColumnName("nombre");
        });

        modelBuilder.Entity<TiposRelacionesPersonale>(entity =>
        {
            entity.ToTable("tipos_relaciones_personales");

            entity.HasIndex(e => e.Nombre, "IX_tipos_relaciones_personales_nombre").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre).HasColumnName("nombre");
            entity.Property(e => e.Reciproca).HasColumnName("reciproca");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
