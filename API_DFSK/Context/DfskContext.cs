using System;
using System.Collections.Generic;
using API_DFSK.Models;
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

    public virtual DbSet<Articulo> Articulos { get; set; }

    public virtual DbSet<ArticulosBodegaApi> ArticulosBodegaApis { get; set; }

    public virtual DbSet<Bodega> Bodegas { get; set; }

    public virtual DbSet<Codigo> Codigos { get; set; }

 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Modern_Spanish_CI_AS");

        modelBuilder.Entity<Articulo>(entity =>
        {
            entity.HasKey(e => e.Articulo1).HasName("ARTICULOS_PK");

            entity.ToTable("ARTICULOS", tb => tb.HasTrigger("MOD"));

            entity.HasIndex(e => e.Unidad, "ARTICULOS_IDX1");

            entity.Property(e => e.Articulo1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Activo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("SI")
                .HasColumnName("ACTIVO");
            entity.Property(e => e.Ano)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANO");
            entity.Property(e => e.Anof)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANOF");
            entity.Property(e => e.Anom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANOM");
            entity.Property(e => e.Capcarga)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CAPCARGA");
            entity.Property(e => e.Categoria)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CATEGORIA");
            entity.Property(e => e.Cbm)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("CBM");
            entity.Property(e => e.Cif)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("CIF");
            entity.Property(e => e.Cifm)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("CIFM");
            entity.Property(e => e.Clasei)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLASEI");
            entity.Property(e => e.Claset)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CLASET");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COLOR");
            entity.Property(e => e.Color1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("COLOR1");
            entity.Property(e => e.Color1t)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COLOR1T");
            entity.Property(e => e.Color2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("COLOR2");
            entity.Property(e => e.Color2t)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COLOR2T");
            entity.Property(e => e.Combustible)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("COMBUSTIBLE");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Descuento)
                .HasColumnType("numeric(5, 2)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.Ean)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("EAN");
            entity.Property(e => e.Ejesi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EJESI");
            entity.Property(e => e.Empaque)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("EMPAQUE");
            entity.Property(e => e.Exento)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("EXENTO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Fechaactual)
                .HasPrecision(0)
                .HasColumnName("FECHAACTUAL");
            entity.Property(e => e.Fechacif)
                .HasPrecision(0)
                .HasColumnName("FECHACIF");
            entity.Property(e => e.Garantia)
                .HasColumnType("numeric(7, 2)")
                .HasColumnName("GARANTIA");
            entity.Property(e => e.Grupo)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("GRUPO");
            entity.Property(e => e.Grupoa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("GRUPO 2")
                .HasColumnName("GRUPOA");
            entity.Property(e => e.Iva)
                .HasColumnType("numeric(4, 2)")
                .HasColumnName("IVA");
            entity.Property(e => e.Marca)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("MARCA");
            entity.Property(e => e.Marcai)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARCAI");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODELO");
            entity.Property(e => e.Modeloi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("MODELOI");
            entity.Property(e => e.Modificacion)
                .HasColumnType("datetime")
                .HasColumnName("MODIFICACION");
            entity.Property(e => e.Nrounico)
                .ValueGeneratedOnAdd()
                .HasColumnName("NROUNICO");
            entity.Property(e => e.Peso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PESO");
            entity.Property(e => e.Puertas)
                .HasDefaultValue(3)
                .HasColumnName("PUERTAS");
            entity.Property(e => e.Puestos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PUESTOS");
            entity.Property(e => e.Puntos)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("PUNTOS");
            entity.Property(e => e.Reposicion)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("REPOSICION");
            entity.Property(e => e.Rin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIN");
            entity.Property(e => e.Serie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SERIE");
            entity.Property(e => e.Servicio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SERVICIO");
            entity.Property(e => e.Stockminimo)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("STOCKMINIMO");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.Tipoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOC");
            entity.Property(e => e.Tipoi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TIPOI");
            entity.Property(e => e.Tipot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOT");
            entity.Property(e => e.Transmision)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((3))")
                .HasColumnName("TRANSMISION");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("UBICACION");
            entity.Property(e => e.Unidad)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.Uso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USO");
            entity.Property(e => e.Usoi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("USOI");
            entity.Property(e => e.Usot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USOT");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.Venta)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("VENTA");
        });

        modelBuilder.Entity<ArticulosBodegaApi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ARTICULOS_BODEGA_API");

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

        modelBuilder.Entity<Bodega>(entity =>
        {
            entity.HasKey(e => new { e.Articulo, e.Bodega1 }).HasName("BODEGAS_PK");

            entity.ToTable("BODEGAS");

            entity.HasIndex(e => e.Articulo, "BODEGAS_IDX1");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Bodega1)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BODEGA");
            entity.Property(e => e.Existencia)
                .HasColumnType("numeric(30, 2)")
                .HasColumnName("EXISTENCIA");

            entity.HasOne(d => d.ArticuloNavigation).WithMany(p => p.Bodegas)
                .HasForeignKey(d => d.Articulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("BODEGAS_FK1");
        });

        modelBuilder.Entity<Codigo>(entity =>
        {
            entity.HasKey(e => new { e.Codigo1, e.Tipo }).HasName("CODIGOS_PK");

            entity.ToTable("CODIGOS");

            entity.Property(e => e.Codigo1)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("CODIGO");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
