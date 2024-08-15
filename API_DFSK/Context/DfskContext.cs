using System;
using System.Collections.Generic;
using API_DFSK.Models.DFSK;
using Microsoft.EntityFrameworkCore;

namespace API_DFSK.Context;

public partial class DfskContext : DbContext
{
    public DfskContext()
    {
    }

    public DfskContext(DbContextOptions<DfskContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ApiArticulosBodega> ApiArticulosBodegas { get; set; }

    public virtual DbSet<ApiArticulosGrupo> ApiArticulosGrupos { get; set; }

    public virtual DbSet<ApiCodigosGrupo> ApiCodigosGrupos { get; set; }

    public virtual DbSet<ApiCodigosMarca> ApiCodigosMarcas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApiArticulosBodega>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("API_ARTICULOS_BODEGA");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Cif)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("CIF");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Existencia)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("existencia");
            entity.Property(e => e.Grupo)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("GRUPO");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODELO");
            entity.Property(e => e.Unidad)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.Venta)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("VENTA");
        });

        modelBuilder.Entity<ApiArticulosGrupo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("API_ARTICULOS_GRUPO");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Cif)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("CIF");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Existencia)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("existencia");
            entity.Property(e => e.Grupo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODELO");
            entity.Property(e => e.Unidad)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.Venta)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("VENTA");
        });

        modelBuilder.Entity<ApiCodigosGrupo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("API_CODIGOS_GRUPOS");

            entity.Property(e => e.Codigo)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("CODIGO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<ApiCodigosMarca>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("API_CODIGOS_MARCA");

            entity.Property(e => e.Codigo)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("CODIGO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
