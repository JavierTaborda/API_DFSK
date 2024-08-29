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

    public virtual DbSet<Lineatxt> Lineatxts { get; set; }

    public virtual DbSet<Resumentxt> Resumentxts { get; set; }

 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApiArticulosBodega>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("API_ARTICULOS_BODEGA");

            entity.Property(e => e.Ano)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANO");
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

            entity.Property(e => e.Ano)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANO");
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

        modelBuilder.Entity<Lineatxt>(entity =>
        {
            entity.HasKey(e => e.Idlineatxt).HasName("PK__LINEATXT__41DEF0C63683159D");

            entity.ToTable("LINEATXT");

            entity.Property(e => e.Idlineatxt).HasColumnName("IDLINEATXT");
            entity.Property(e => e.Anofabrica)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ANOFABRICA");
            entity.Property(e => e.Anomodelo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ANOMODELO");
            entity.Property(e => e.Capacidadcarga)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CAPACIDADCARGA");
            entity.Property(e => e.Certiorigen)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CERTIORIGEN");
            entity.Property(e => e.Claseabc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CLASEABC");
            entity.Property(e => e.Color)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COLOR");
            entity.Property(e => e.Colorsecundario)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("  ")
                .HasColumnName("COLORSECUNDARIO");
            entity.Property(e => e.Correlativoempresa)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CORRELATIVOEMPRESA");
            entity.Property(e => e.Diametrorueda)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("DIAMETRORUEDA");
            entity.Property(e => e.Fechacertificado)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("FECHACERTIFICADO");
            entity.Property(e => e.Fechafactura)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("FECHAFACTURA");
            entity.Property(e => e.Fechahomo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("FECHAHOMO");
            entity.Property(e => e.Fechaplanigra)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("FECHAPLANIGRA");
            entity.Property(e => e.Fecrafplaca)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("FECRAFPLACA");
            entity.Property(e => e.Ffactadqui)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("FFACTADQUI");
            entity.Property(e => e.Idresumentxt).HasColumnName("IDRESUMENTXT");
            entity.Property(e => e.Marca)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("D1L")
                .HasColumnName("MARCA");
            entity.Property(e => e.Modelo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MODELO");
            entity.Property(e => e.Movimiento)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MOVIMIENTO");
            entity.Property(e => e.Nfactadqui)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NFACTADQUI");
            entity.Property(e => e.Numejes)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("NUMEJES");
            entity.Property(e => e.Numfactura)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NUMFACTURA");
            entity.Property(e => e.Numhomo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NUMHOMO");
            entity.Property(e => e.Nummodificacion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("NUMMODIFICACION");
            entity.Property(e => e.Numplanigra)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NUMPLANIGRA");
            entity.Property(e => e.Numpuestos)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("NUMPUESTOS");
            entity.Property(e => e.Numrafplaca)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("NUMRAFPLACA");
            entity.Property(e => e.Numsecplaca)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .HasColumnName("NUMSECPLACA");
            entity.Property(e => e.Peso)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PESO");
            entity.Property(e => e.Placa)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("PLACA");
            entity.Property(e => e.Puertaentrada)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PUERTAENTRADA");
            entity.Property(e => e.Rif)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RIF");
            entity.Property(e => e.Serialcarroceria)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("SERIALCARROCERIA");
            entity.Property(e => e.Serialcarrozado)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasDefaultValue("                 ")
                .HasColumnName("SERIALCARROZADO");
            entity.Property(e => e.Serialchasis)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("SERIALCHASIS");
            entity.Property(e => e.Serialmotor)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("SERIALMOTOR");
            entity.Property(e => e.Serialniv)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("SERIALNIV");
            entity.Property(e => e.Serie)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SERIE");
            entity.Property(e => e.Serviciointt)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("SERVICIOINTT");
            entity.Property(e => e.Tipcombustible)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("((5))")
                .HasColumnName("TIPCOMBUSTIBLE");
            entity.Property(e => e.Tipoabc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TIPOABC");
            entity.Property(e => e.Tipocapacidad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((2))")
                .HasColumnName("TIPOCAPACIDAD");
            entity.Property(e => e.Usoabc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("USOABC");

            entity.HasOne(d => d.IdresumentxtNavigation).WithMany(p => p.Lineatxts)
                .HasForeignKey(d => d.Idresumentxt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LINEATXT_RESUMENTXT");
        });

        modelBuilder.Entity<Resumentxt>(entity =>
        {
            entity.HasKey(e => e.Idresumentxt);

            entity.ToTable("RESUMENTXT");

            entity.Property(e => e.Idresumentxt).HasColumnName("IDRESUMENTXT");
            entity.Property(e => e.Fecha)
                .HasComment("Fecha de Creacion")
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Fechaenvio)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasComment("FECHA DEL ENVIO")
                .HasColumnName("FECHAENVIO");
            entity.Property(e => e.Fechafin)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasComment("FECHA FIN DEL CONVENIO")
                .HasColumnName("FECHAFIN");
            entity.Property(e => e.Horaenvio)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasComment("HORA DEL ENVIO")
                .HasColumnName("HORAENVIO");
            entity.Property(e => e.Inicialempresa)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasComment("INICIALES DE LA EMPRESA (IM)")
                .HasColumnName("INICIALEMPRESA");
            entity.Property(e => e.Ma)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasComment("REGISTROS AGREGAR")
                .HasColumnName("MA");
            entity.Property(e => e.Me)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasComment("REGISTROS ELIMINAR")
                .HasColumnName("ME");
            entity.Property(e => e.Mm)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasComment("REGISTROS MODIF")
                .HasColumnName("MM");
            entity.Property(e => e.Nombreempresa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("NOMBRE DE EMPRESA")
                .HasColumnName("NOMBREEMPRESA");
            entity.Property(e => e.Numenvio)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasComment("NUMERO DE ENVIO")
                .HasColumnName("NUMENVIO");
            entity.Property(e => e.Rc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("RC")
                .HasComment("FIJO ALFANUMERICO DE LINEA FINAL")
                .HasColumnName("RC");
            entity.Property(e => e.Re)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("RE")
                .HasComment("fijo alfanumerico de txt")
                .HasColumnName("RE");
            entity.Property(e => e.Refeciv)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasComment("NUMERO DE REFECIV")
                .HasColumnName("REFECIV");
            entity.Property(e => e.Restolinea)
                .HasMaxLength(231)
                .IsUnicode(false)
                .HasDefaultValue("                                                                                                                                                                                                                                      *")
                .HasComment("RESTO DE LA LINEA INICIAL")
                .HasColumnName("RESTOLINEA");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
