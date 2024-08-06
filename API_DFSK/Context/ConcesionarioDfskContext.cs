using System;
using System.Collections.Generic;
using API_DFSK.Models.ConcesionarioDFSK;
using Microsoft.EntityFrameworkCore;

namespace API_DFSK.Context;

public partial class ConcesionarioDfskContext : DbContext
{
    public ConcesionarioDfskContext()
    {
    }

    public ConcesionarioDfskContext(DbContextOptions<ConcesionarioDfskContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<Repuesto> Repuestos { get; set; }

    public virtual DbSet<Solicitude> Solicitudes { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    public virtual DbSet<Vendedore> Vendedores { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.IdEstado);

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Repuesto>(entity =>
        {
            entity.HasKey(e => e.IdRepuesto).HasName("PK__Repuesto__75B30774EDDF74CD");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdVehiculoNavigation).WithMany(p => p.Repuestos)
                .HasForeignKey(d => d.IdVehiculo)
                .HasConstraintName("FK__Repuestos__Vehic__29572725");
        });

        modelBuilder.Entity<Solicitude>(entity =>
        {
            entity.HasKey(e => e.IdSolicitud).HasName("PK__Solicitu__85E95DA75C3B08DD");

            entity.Property(e => e.FechaCompra).HasColumnType("datetime");
            entity.Property(e => e.FechaLlegada).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.Observacion)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Solicitudes)
                .HasForeignKey(d => d.IdEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Solicitudes_Estados");

            entity.HasOne(d => d.IdRepuestoNavigation).WithMany(p => p.Solicitudes)
                .HasForeignKey(d => d.IdRepuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Solicitud__Repue__2D27B809");

            entity.HasOne(d => d.IdVendedorNavigation).WithMany(p => p.Solicitudes)
                .HasForeignKey(d => d.IdVendedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Solicitud__Vende__2C3393D0");
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.HasKey(e => e.IdVehiculo).HasName("PK__Vehiculo__AA088620633F3CD2");

            entity.HasIndex(e => e.Vin, "UQ__Vehiculo__C5DF234C699ED050").IsUnique();

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Marca)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Modelo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Vin)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("VIN");
        });

        modelBuilder.Entity<Vendedore>(entity =>
        {
            entity.HasKey(e => e.IdVendedor).HasName("PK__Vendedor__2033EECC06D7C763");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
