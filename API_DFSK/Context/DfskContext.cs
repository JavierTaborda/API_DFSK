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

    public virtual DbSet<A1> A1s { get; set; }

    public virtual DbSet<A2> A2s { get; set; }

    public virtual DbSet<A3> A3s { get; set; }

    public virtual DbSet<Actcliente> Actclientes { get; set; }

    public virtual DbSet<ActualizaCliente> ActualizaClientes { get; set; }

    public virtual DbSet<Analisis46> Analisis46s { get; set; }

    public virtual DbSet<AnalistaCobranza> AnalistaCobranzas { get; set; }

    public virtual DbSet<AnuSer> AnuSers { get; set; }

    public virtual DbSet<Artcliente> Artclientes { get; set; }

    public virtual DbSet<Articulo> Articulos { get; set; }

    public virtual DbSet<Articulosficha> Articulosfichas { get; set; }

    public virtual DbSet<Articulosubicacione> Articulosubicaciones { get; set; }

    public virtual DbSet<Auxiliar> Auxiliars { get; set; }

    public virtual DbSet<Bodega> Bodegas { get; set; }

    public virtual DbSet<CSerial> CSerials { get; set; }

    public virtual DbSet<CSerializadum> CSerializada { get; set; }

    public virtual DbSet<CajaSerial> CajaSerials { get; set; }

    public virtual DbSet<Cantmarca> Cantmarcas { get; set; }

    public virtual DbSet<Cartera> Carteras { get; set; }

    public virtual DbSet<CarteraCierre> CarteraCierres { get; set; }

    public virtual DbSet<Carteraimb> Carteraimbs { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Cdtv> Cdtvs { get; set; }

    public virtual DbSet<Certificado> Certificados { get; set; }

    public virtual DbSet<Cintum> Cinta { get; set; }

    public virtual DbSet<Ciudade> Ciudades { get; set; }

    public virtual DbSet<Clafe> Claves { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ClientesAct> ClientesActs { get; set; }

    public virtual DbSet<Clientesat> Clientesats { get; set; }

    public virtual DbSet<Codigo> Codigos { get; set; }

    public virtual DbSet<Codigosiva> Codigosivas { get; set; }

    public virtual DbSet<Codigosvalor> Codigosvalors { get; set; }

    public virtual DbSet<Codigounidade> Codigounidades { get; set; }

    public virtual DbSet<Compania> Companias { get; set; }

    public virtual DbSet<Costo> Costos { get; set; }

    public virtual DbSet<CostosRma> CostosRmas { get; set; }

    public virtual DbSet<Cotizacione> Cotizaciones { get; set; }

    public virtual DbSet<Cotizacionesmov> Cotizacionesmovs { get; set; }

    public virtual DbSet<Cotizacionesped> Cotizacionespeds { get; set; }

    public virtual DbSet<CuentaNotum> CuentaNota { get; set; }

    public virtual DbSet<CuentaZoho> CuentaZohos { get; set; }

    public virtual DbSet<CuotaImb> CuotaImbs { get; set; }

    public virtual DbSet<Cxc> Cxcs { get; set; }

    public virtual DbSet<Cxc2> Cxc2s { get; set; }

    public virtual DbSet<DbLobOutputSession> DbLobOutputSessions { get; set; }

    public virtual DbSet<DbStorageCurrent> DbStorageCurrents { get; set; }

    public virtual DbSet<Descuento> Descuentos { get; set; }

    public virtual DbSet<Descuentosiva> Descuentosivas { get; set; }

    public virtual DbSet<Despacho> Despachos { get; set; }

    public virtual DbSet<Despachosmov> Despachosmovs { get; set; }

    public virtual DbSet<Dne> Dnes { get; set; }

    public virtual DbSet<Documento> Documentos { get; set; }

    public virtual DbSet<Documentoslogistica> Documentoslogisticas { get; set; }

    public virtual DbSet<DtvHist> DtvHists { get; set; }

    public virtual DbSet<EdoCtaSimple> EdoCtaSimples { get; set; }

    public virtual DbSet<EdoCtaSimple2> EdoCtaSimple2s { get; set; }

    public virtual DbSet<EdoCtaSimple3> EdoCtaSimple3s { get; set; }

    public virtual DbSet<EdoCuenta2> EdoCuenta2s { get; set; }

    public virtual DbSet<EdoCuentum> EdoCuenta { get; set; }

    public virtual DbSet<Ensamble> Ensambles { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<Estadofiltro> Estadofiltros { get; set; }

    public virtual DbSet<F> Fs { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Facturasmov> Facturasmovs { get; set; }

    public virtual DbSet<Facturasped> Facturaspeds { get; set; }

    public virtual DbSet<Facturassaldo> Facturassaldos { get; set; }

    public virtual DbSet<FacturassaldoCierre> FacturassaldoCierres { get; set; }

    public virtual DbSet<FacturassaldosHist> FacturassaldosHists { get; set; }

    public virtual DbSet<FacturassaldosMod> FacturassaldosMods { get; set; }

    public virtual DbSet<Financiador> Financiadors { get; set; }

    public virtual DbSet<Garantia> Garantias { get; set; }

    public virtual DbSet<Garantiasactual> Garantiasactuals { get; set; }

    public virtual DbSet<Garantiasmov> Garantiasmovs { get; set; }

    public virtual DbSet<HistSma> HistSmas { get; set; }

    public virtual DbSet<Importacione> Importaciones { get; set; }

    public virtual DbSet<Importacionesmov> Importacionesmovs { get; set; }

    public virtual DbSet<Impresione> Impresiones { get; set; }

    public virtual DbSet<Impresora> Impresoras { get; set; }

    public virtual DbSet<Kardex> Kardices { get; set; }

    public virtual DbSet<Kardexold> Kardexolds { get; set; }

    public virtual DbSet<Kardold> Kardolds { get; set; }

    public virtual DbSet<LatestFob> LatestFobs { get; set; }

    public virtual DbSet<Leap> Leaps { get; set; }

    public virtual DbSet<Listap> Listaps { get; set; }

    public virtual DbSet<Logcliente> Logclientes { get; set; }

    public virtual DbSet<Logcobranza> Logcobranzas { get; set; }

    public virtual DbSet<Logistica> Logisticas { get; set; }

    public virtual DbSet<Logisticamov> Logisticamovs { get; set; }

    public virtual DbSet<Logisticamovart> Logisticamovarts { get; set; }

    public virtual DbSet<Logisticaseg> Logisticasegs { get; set; }

    public virtual DbSet<Logisticaseriale> Logisticaseriales { get; set; }

    public virtual DbSet<Masteraccount> Masteraccounts { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<Menuydocumento> Menuydocumentos { get; set; }

    public virtual DbSet<Modif> Modifs { get; set; }

    public virtual DbSet<Modusuario> Modusuarios { get; set; }

    public virtual DbSet<Moneda> Monedas { get; set; }

    public virtual DbSet<Monedashistorico> Monedashistoricos { get; set; }

    public virtual DbSet<Orctransito> Orctransitos { get; set; }

    public virtual DbSet<Pcompra> Pcompras { get; set; }

    public virtual DbSet<PedidosZoho> PedidosZohos { get; set; }

    public virtual DbSet<Pedynota2> Pedynota2s { get; set; }

    public virtual DbSet<Pedynotah> Pedynotahs { get; set; }

    public virtual DbSet<Pedynotah2> Pedynotah2s { get; set; }

    public virtual DbSet<Pedynotum> Pedynota { get; set; }

    public virtual DbSet<PlantillaStandard> PlantillaStandards { get; set; }

    public virtual DbSet<Profit> Profits { get; set; }

    public virtual DbSet<Profit2019> Profit2019s { get; set; }

    public virtual DbSet<PuntajeTiempo> PuntajeTiempos { get; set; }

    public virtual DbSet<Recibo> Recibos { get; set; }

    public virtual DbSet<Recibosmov> Recibosmovs { get; set; }

    public virtual DbSet<Recibosmovfp> Recibosmovfps { get; set; }

    public virtual DbSet<Recibosmovfpold> Recibosmovfpolds { get; set; }

    public virtual DbSet<Recibosmovfpold1> Recibosmovfpold1s { get; set; }

    public virtual DbSet<Recibosprov> Recibosprovs { get; set; }

    public virtual DbSet<Recordanula> Recordanulas { get; set; }

    public virtual DbSet<RentaCobro> RentaCobros { get; set; }

    public virtual DbSet<Reportevt> Reportevts { get; set; }

    public virtual DbSet<Reportevt2> Reportevt2s { get; set; }

    public virtual DbSet<Reportevtr> Reportevtrs { get; set; }

    public virtual DbSet<Rev> Revs { get; set; }

    public virtual DbSet<Revcicpc> Revcicpcs { get; set; }

    public virtual DbSet<Revision> Revisions { get; set; }

    public virtual DbSet<Revision2> Revision2s { get; set; }

    public virtual DbSet<Revision3> Revision3s { get; set; }

    public virtual DbSet<Revseriale> Revseriales { get; set; }

    public virtual DbSet<Sdirectv> Sdirectvs { get; set; }

    public virtual DbSet<Sellin> Sellins { get; set; }

    public virtual DbSet<Ser> Sers { get; set; }

    public virtual DbSet<Serial> Serials { get; set; }

    public virtual DbSet<Seriale> Seriales { get; set; }

    public virtual DbSet<SerialesAuto> SerialesAutos { get; set; }

    public virtual DbSet<Serialesvehiculo> Serialesvehiculos { get; set; }

    public virtual DbSet<SmaBrakepad> SmaBrakepads { get; set; }

    public virtual DbSet<StockGroup> StockGroups { get; set; }

    public virtual DbSet<Stockvalue> Stockvalues { get; set; }

    public virtual DbSet<Sucursal> Sucursals { get; set; }

    public virtual DbSet<Suli> Sulis { get; set; }

    public virtual DbSet<Svehiculo> Svehiculos { get; set; }

    public virtual DbSet<Ti> Tis { get; set; }

    public virtual DbSet<Tpcliente> Tpclientes { get; set; }

    public virtual DbSet<Tpcopium> Tpcopia { get; set; }

    public virtual DbSet<Tpdepo> Tpdepos { get; set; }

    public virtual DbSet<Tpdepor> Tpdepors { get; set; }

    public virtual DbSet<TplinkCChannel> TplinkCChannels { get; set; }

    public virtual DbSet<TplinkCGroup> TplinkCGroups { get; set; }

    public virtual DbSet<TplinkSaleGroup> TplinkSaleGroups { get; set; }

    public virtual DbSet<Tplinkchannel> Tplinkchannels { get; set; }

    public virtual DbSet<Tplinkg> Tplinkgs { get; set; }

    public virtual DbSet<Tplinkgroup> Tplinkgroups { get; set; }

    public virtual DbSet<Tplinkproduct> Tplinkproducts { get; set; }

    public virtual DbSet<Tpprod> Tpprods { get; set; }

    public virtual DbSet<Tpproducto> Tpproductos { get; set; }

    public virtual DbSet<Tpreserva> Tpreservas { get; set; }

    public virtual DbSet<Tptasa> Tptasas { get; set; }

    public virtual DbSet<Tptotal> Tptotals { get; set; }

    public virtual DbSet<Txt> Txts { get; set; }

    public virtual DbSet<Ubi> Ubis { get; set; }

    public virtual DbSet<Uiproperty> Uiproperties { get; set; }

    public virtual DbSet<UltDespacho> UltDespachos { get; set; }

    public virtual DbSet<UltDespachosmov> UltDespachosmovs { get; set; }

    public virtual DbSet<UltLogistica> UltLogisticas { get; set; }

    public virtual DbSet<UltLogisticamov> UltLogisticamovs { get; set; }

    public virtual DbSet<UltLogisticaseriale> UltLogisticaseriales { get; set; }

    public virtual DbSet<UltZfacturasmovdep> UltZfacturasmovdeps { get; set; }

    public virtual DbSet<UltZohodespacho> UltZohodespachos { get; set; }

    public virtual DbSet<Usuariosfi> Usuariosfis { get; set; }

    public virtual DbSet<Usuariospermiso> Usuariospermisos { get; set; }

    public virtual DbSet<VBuiltinfunction> VBuiltinfunctions { get; set; }

    public virtual DbSet<VDbmsSqlBindVariable> VDbmsSqlBindVariables { get; set; }

    public virtual DbSet<VDbmsSqlCursor> VDbmsSqlCursors { get; set; }

    public virtual DbSet<VDbmsSqlDefineColumn> VDbmsSqlDefineColumns { get; set; }

    public virtual DbSet<VDbmsSqlRecordset> VDbmsSqlRecordsets { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    public virtual DbSet<Vencida> Vencidas { get; set; }

    public virtual DbSet<Vencimiento> Vencimientos { get; set; }

    public virtual DbSet<VentaDirectv> VentaDirectvs { get; set; }

    public virtual DbSet<Ventamarca> Ventamarcas { get; set; }

    public virtual DbSet<Ventamarcas2> Ventamarcas2s { get; set; }

    public virtual DbSet<Ventasmasrcas2> Ventasmasrcas2s { get; set; }

    public virtual DbSet<View1> View1s { get; set; }

    public virtual DbSet<Wcartera> Wcarteras { get; set; }

    public virtual DbSet<Wholesaler> Wholesalers { get; set; }

    public virtual DbSet<Zactdespacho> Zactdespachos { get; set; }

    public virtual DbSet<Zliberada> Zliberadas { get; set; }

    public virtual DbSet<ZohoArticulo> ZohoArticulos { get; set; }

    public virtual DbSet<ZohoCartera> ZohoCarteras { get; set; }

    public virtual DbSet<ZohoCliente> ZohoClientes { get; set; }

    public virtual DbSet<ZohoContacto> ZohoContactos { get; set; }

    public virtual DbSet<ZohoDespacho> ZohoDespachos { get; set; }

    public virtual DbSet<ZohoDeudum> ZohoDeuda { get; set; }

    public virtual DbSet<ZohoEdodet> ZohoEdodets { get; set; }

    public virtual DbSet<ZohoEstadoCuentum> ZohoEstadoCuenta { get; set; }

    public virtual DbSet<ZohoEstadocuenta> ZohoEstadocuentas { get; set; }

    public virtual DbSet<ZohoEvento> ZohoEventos { get; set; }

    public virtual DbSet<ZohoFact> ZohoFacts { get; set; }

    public virtual DbSet<ZohoItemfac> ZohoItemfacs { get; set; }

    public virtual DbSet<ZohoNotificacion> ZohoNotificacions { get; set; }

    public virtual DbSet<ZohoNotificacione> ZohoNotificaciones { get; set; }

    public virtual DbSet<ZohoVendedor> ZohoVendedors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=MRQLTA8F4\\Prueba;Database=dfsk;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<A1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("A1");

            entity.Property(e => e.Bodega)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BODEGA");
            entity.Property(e => e.Bodegaf)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BODEGAF");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.Impresora)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IMPRESORA");
            entity.Property(e => e.Progasoc)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PROGASOC");
            entity.Property(e => e.Programa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PROGRAMA");
        });

        modelBuilder.Entity<A2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("a2");

            entity.Property(e => e.Banco).HasColumnName("banco");
            entity.Property(e => e.Cheque).HasColumnName("cheque");
            entity.Property(e => e.Cliente)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("fecha_asoc");
            entity.Property(e => e.Fecharef)
                .HasPrecision(0)
                .HasColumnName("fecharef");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_asoc");
            entity.Property(e => e.Precio).HasColumnName("precio");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.TipoAsoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_ASOC");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Valor)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("valor");
        });

        modelBuilder.Entity<A3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("A3");

            entity.Property(e => e.Serial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERIAL");
        });

        modelBuilder.Entity<Actcliente>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACTCLIENTES");

            entity.Property(e => e.Cumpleanos)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CUMPLEANOS");
            entity.Property(e => e.Direccion1)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DIRECCION1");
            entity.Property(e => e.Direccion2)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DIRECCION2");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Hora)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("HORA");
            entity.Property(e => e.Instagram)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("INSTAGRAM");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Propietario)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PROPIETARIO");
            entity.Property(e => e.Rif)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RIF");
            entity.Property(e => e.Telefono)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TelefonoDespacho)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TELEFONO_DESPACHO");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("VENDEDOR");
        });

        modelBuilder.Entity<ActualizaCliente>(entity =>
        {
            entity.HasKey(e => e.Cliente);

            entity.ToTable("ActualizaCliente");

            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Telefono)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
        });

        modelBuilder.Entity<Analisis46>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ANALISIS46");

            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Costot)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("COSTOT");
            entity.Property(e => e.Costou)
                .HasColumnType("numeric(28, 14)")
                .HasColumnName("COSTOU");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Destino)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("DESTINO");
            entity.Property(e => e.Doc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("DOC");
            entity.Property(e => e.Fecha).HasColumnName("FECHA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MARCA");
            entity.Property(e => e.Mes)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("MES");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODELO");
            entity.Property(e => e.Origen)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("ORIGEN");
            entity.Property(e => e.Tipo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<AnalistaCobranza>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ANALISTA_COBRANZA");

            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
        });

        modelBuilder.Entity<AnuSer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ANU_SER");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Canu)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("CANU");
            entity.Property(e => e.Docasoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DOCASOC");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Fechaasoc)
                .HasPrecision(0)
                .HasColumnName("FECHAASOC");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Numeroasoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMEROASOC");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<Artcliente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ARTCLIENTE");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Cant)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("cant");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estado)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("ESTADO");
        });

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

        modelBuilder.Entity<Articulosficha>(entity =>
        {
            entity.HasKey(e => e.Articulo).HasName("FICHAS_PK");

            entity.ToTable("ARTICULOSFICHAS");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Caracteristicas)
                .IsUnicode(false)
                .HasColumnName("CARACTERISTICAS");
            entity.Property(e => e.Foto).HasColumnName("FOTO");
        });

        modelBuilder.Entity<Articulosubicacione>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ARTICULOSUBICACIONES");

            entity.Property(e => e.Articulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UBICACION");
        });

        modelBuilder.Entity<Auxiliar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AUXILIAR");

            entity.Property(e => e.Campo1)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAMPO1");
            entity.Property(e => e.Campo10)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAMPO10");
            entity.Property(e => e.Campo11)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAMPO11");
            entity.Property(e => e.Campo12)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAMPO12");
            entity.Property(e => e.Campo13)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAMPO13");
            entity.Property(e => e.Campo14)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAMPO14");
            entity.Property(e => e.Campo15)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAMPO15");
            entity.Property(e => e.Campo16)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAMPO16");
            entity.Property(e => e.Campo17)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAMPO17");
            entity.Property(e => e.Campo2)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAMPO2");
            entity.Property(e => e.Campo3)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAMPO3");
            entity.Property(e => e.Campo4)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAMPO4");
            entity.Property(e => e.Campo5)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAMPO5");
            entity.Property(e => e.Campo6)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAMPO6");
            entity.Property(e => e.Campo7)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAMPO7");
            entity.Property(e => e.Campo8)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAMPO8");
            entity.Property(e => e.Campo9)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CAMPO9");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
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

        modelBuilder.Entity<CSerial>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("C_SERIAL");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Docasoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DOCASOC");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Fechaasoc)
                .HasPrecision(0)
                .HasColumnName("FECHAASOC");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Numeroasoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMEROASOC");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<CSerializadum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("C_SERIALIZADA");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Docasoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DOCASOC");
            entity.Property(e => e.Expr1).HasColumnType("numeric(38, 0)");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Fechaasoc)
                .HasPrecision(0)
                .HasColumnName("FECHAASOC");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Numeroasoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMEROASOC");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<CajaSerial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CAJA_SERIAL");

            entity.Property(e => e.Articulo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Caja).HasColumnName("CAJA");
            entity.Property(e => e.Paleta).HasColumnName("PALETA");
            entity.Property(e => e.Serial)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SERIAL");
        });

        modelBuilder.Entity<Cantmarca>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CANTMARCAS");

            entity.Property(e => e.Cantmarca1).HasColumnName("CANTMARCA");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Periodo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("PERIODO");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<Cartera>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CARTERAS");

            entity.Property(e => e.Ciudad)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("ciudad");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cliente");
            entity.Property(e => e.Comentario)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("fecha");
            entity.Property(e => e.FechaLog)
                .HasPrecision(0)
                .HasColumnName("fecha_log");
            entity.Property(e => e.Iva)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("iva");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("numero");
            entity.Property(e => e.Plazo)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("plazo");
            entity.Property(e => e.ReciboNro)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("Recibo_NRO");
            entity.Property(e => e.ReciboRet)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("Recibo_Ret");
            entity.Property(e => e.Recolecta)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("RECOLECTA");
            entity.Property(e => e.Retencion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("retencion");
            entity.Property(e => e.Saldo)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("saldo");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("tasa");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("tipo_doc");
            entity.Property(e => e.TipoLog)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("tipo_log");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("total");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<CarteraCierre>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cartera_cierre");

            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Comentario)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.Contacto)
                .HasMaxLength(85)
                .IsUnicode(false)
                .HasColumnName("CONTACTO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaLog)
                .HasPrecision(0)
                .HasColumnName("FECHA_LOG");
            entity.Property(e => e.Iva)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("IVA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_ASOC");
            entity.Property(e => e.NumeroLog)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_LOG");
            entity.Property(e => e.Plazo)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("PLAZO");
            entity.Property(e => e.Recibo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("RECIBO");
            entity.Property(e => e.Retencion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RETENCION");
            entity.Property(e => e.Saldo)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("SALDO");
            entity.Property(e => e.Sede)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SEDE");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASA");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.TipoLog)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_LOG");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("TOTAL");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VENDEDOR");
        });

        modelBuilder.Entity<Carteraimb>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("carteraimb");

            entity.Property(e => e.A2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("a2");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Comentario)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.Contacto)
                .HasMaxLength(85)
                .IsUnicode(false)
                .HasColumnName("CONTACTO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Ejecutivo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EJECUTIVO");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("FECHA_ASOC");
            entity.Property(e => e.FechaLog)
                .HasPrecision(0)
                .HasColumnName("FECHA_LOG");
            entity.Property(e => e.Interes)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("interes");
            entity.Property(e => e.Iva)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("IVA");
            entity.Property(e => e.N2)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("n2");
            entity.Property(e => e.Ncuotas)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NCUOTAS");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroAsoc1)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_ASOC");
            entity.Property(e => e.NumeroLog)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_LOG");
            entity.Property(e => e.Numeroasoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMEROASOC");
            entity.Property(e => e.Plazo)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("PLAZO");
            entity.Property(e => e.R2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("r2");
            entity.Property(e => e.Recibo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("RECIBO");
            entity.Property(e => e.Retencion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RETENCION");
            entity.Property(e => e.Saldo)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("SALDO");
            entity.Property(e => e.Sede)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sede");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASA");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TipoAsoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_ASOC");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.TipoLog)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_LOG");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("TOTAL");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vendedor");
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CATEGORIAS");

            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<Cdtv>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CDTV");

            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MARCA");
        });

        modelBuilder.Entity<Certificado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CERTIFICADO");

            entity.Property(e => e.Av)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("AV");
            entity.Property(e => e.Casa)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CASA");
            entity.Property(e => e.Cicomprador)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CICOMPRADOR");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.Codarea1)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CODAREA1");
            entity.Property(e => e.Codpostal)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CODPOSTAL");
            entity.Property(e => e.Consecionario1)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CONSECIONARIO1");
            entity.Property(e => e.Consecionario2)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CONSECIONARIO2");
            entity.Property(e => e.Consignado1)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CONSIGNADO1");
            entity.Property(e => e.Consignado2)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CONSIGNADO2");
            entity.Property(e => e.Distrito)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DISTRITO");
            entity.Property(e => e.Ent)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ENT");
            entity.Property(e => e.Fechae)
                .HasPrecision(0)
                .HasColumnName("FECHAE");
            entity.Property(e => e.Ncertificado)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NCERTIFICADO");
            entity.Property(e => e.Ncontrol)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NCONTROL");
            entity.Property(e => e.Nombcomprador)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOMBCOMPRADOR");
            entity.Property(e => e.Propiedad1)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PROPIEDAD1");
            entity.Property(e => e.Propiedad2)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PROPIEDAD2");
            entity.Property(e => e.Reserva)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RESERVA");
            entity.Property(e => e.Reserva1)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RESERVA1");
            entity.Property(e => e.Rif1)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RIF1");
            entity.Property(e => e.Rif2)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RIF2");
            entity.Property(e => e.Serialm)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SERIALM");
            entity.Property(e => e.Tlfcasa)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TLFCASA");
            entity.Property(e => e.Urb)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URB");
        });

        modelBuilder.Entity<Cintum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CINTA");

            entity.Property(e => e.Cinta)
                .IsUnicode(false)
                .HasColumnName("CINTA");
        });

        modelBuilder.Entity<Ciudade>(entity =>
        {
            entity.HasKey(e => new { e.Estado, e.Descripcion }).HasName("CIUDADES_PK");

            entity.ToTable("CIUDADES");

            entity.HasIndex(e => e.Estado, "CIUDADES_IDX1");

            entity.Property(e => e.Estado).HasColumnName("ESTADO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");

            entity.HasOne(d => d.EstadoNavigation).WithMany(p => p.Ciudades)
                .HasForeignKey(d => d.Estado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CIUDADES_FK1");
        });

        modelBuilder.Entity<Clafe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CLAVES");

            entity.Property(e => e.Clave)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CLAVE");
            entity.Property(e => e.Prioridad)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("PRIORIDAD");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Cliente1).HasName("CLIENTES_PK");

            entity.ToTable("CLIENTES", tb =>
                {
                    tb.HasTrigger("ACTC");
                    tb.HasTrigger("MODC");
                });

            entity.HasIndex(e => e.Estado, "CLIENTES_IDX1");

            entity.Property(e => e.Cliente1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.C1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.C2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.C3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.C4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.C5)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.C6)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Categoria)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("CATEGORIA");
            entity.Property(e => e.Categoria1)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("CATEGORIA1");
            entity.Property(e => e.Cdescuento)
                .HasColumnType("numeric(5, 2)")
                .HasColumnName("CDESCUENTO");
            entity.Property(e => e.Cedula)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CEDULA");
            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CELULAR");
            entity.Property(e => e.Celular2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CELULAR2");
            entity.Property(e => e.Celular3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CELULAR3");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.Clase)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLASE");
            entity.Property(e => e.Comentario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.Contacto)
                .HasMaxLength(85)
                .IsUnicode(false)
                .HasColumnName("CONTACTO");
            entity.Property(e => e.Cumpleano)
                .HasPrecision(0)
                .HasColumnName("CUMPLEANO");
            entity.Property(e => e.Cupo)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("CUPO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Dirdespacho)
                .IsUnicode(false)
                .HasColumnName("DIRDESPACHO");
            entity.Property(e => e.Direccion)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Dirres)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DIRRES");
            entity.Property(e => e.E1)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(3, 0)");
            entity.Property(e => e.E2)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(3, 0)");
            entity.Property(e => e.E3)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(3, 0)");
            entity.Property(e => e.E4)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(3, 0)");
            entity.Property(e => e.E5)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(3, 0)");
            entity.Property(e => e.E6)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(3, 0)");
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Estado)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("ESTADO");
            entity.Property(e => e.Estado1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESTADO1");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAX");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Fecha1)
                .HasColumnType("datetime")
                .HasColumnName("FECHA1");
            entity.Property(e => e.Fecha2)
                .HasColumnType("datetime")
                .HasColumnName("FECHA2");
            entity.Property(e => e.Fecha3)
                .HasColumnType("datetime")
                .HasColumnName("FECHA3");
            entity.Property(e => e.Fechaactual)
                .HasPrecision(0)
                .HasColumnName("FECHAACTUAL");
            entity.Property(e => e.Iva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IVA");
            entity.Property(e => e.Lista)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("LISTA");
            entity.Property(e => e.Marca)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .HasColumnName("MARCA");
            entity.Property(e => e.Master)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MASTER");
            entity.Property(e => e.Modificacion)
                .HasColumnType("datetime")
                .HasColumnName("MODIFICACION");
            entity.Property(e => e.Ncelular)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NCELULAR");
            entity.Property(e => e.Ncelular2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NCELULAR2");
            entity.Property(e => e.Ncelular3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NCELULAR3");
            entity.Property(e => e.Nrounico)
                .ValueGeneratedOnAdd()
                .HasColumnName("NROUNICO");
            entity.Property(e => e.Parroquia)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("PARROQUIA");
            entity.Property(e => e.Plazo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("PLAZO");
            entity.Property(e => e.Plazom)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("PLAZOM");
            entity.Property(e => e.Pts).HasColumnName("PTS");
            entity.Property(e => e.Referencia)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("REFERENCIA");
            entity.Property(e => e.Retencion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RETENCION");
            entity.Property(e => e.S1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.S2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.S3)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.S4)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.S5)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.S6)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Silenciar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .HasColumnName("SILENCIAR");
            entity.Property(e => e.T1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.T2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.T3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.T4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.T5)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.T6)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.Telres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELRES");
            entity.Property(e => e.Tipocliente)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPOCLIENTE");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VENDEDOR");
            entity.Property(e => e.Zona)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("ZONA");
        });

        modelBuilder.Entity<ClientesAct>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CLIENTES_ACT");

            entity.Property(e => e.C1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.C2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.C3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.C4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.C5)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.C6)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Categoria)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("CATEGORIA");
            entity.Property(e => e.Categoria1)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("CATEGORIA1");
            entity.Property(e => e.Cdescuento)
                .HasColumnType("numeric(5, 2)")
                .HasColumnName("CDESCUENTO");
            entity.Property(e => e.Cedula)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CEDULA");
            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CELULAR");
            entity.Property(e => e.Celular2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CELULAR2");
            entity.Property(e => e.Celular3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CELULAR3");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.Clase)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLASE");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Comentario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.Contacto)
                .HasMaxLength(85)
                .IsUnicode(false)
                .HasColumnName("CONTACTO");
            entity.Property(e => e.Cumpleano)
                .HasPrecision(0)
                .HasColumnName("CUMPLEANO");
            entity.Property(e => e.Cupo)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("CUPO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Dirdespacho)
                .IsUnicode(false)
                .HasColumnName("DIRDESPACHO");
            entity.Property(e => e.Direccion)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Dirres)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DIRRES");
            entity.Property(e => e.E1).HasColumnType("numeric(3, 0)");
            entity.Property(e => e.E2).HasColumnType("numeric(3, 0)");
            entity.Property(e => e.E3).HasColumnType("numeric(3, 0)");
            entity.Property(e => e.E4).HasColumnType("numeric(3, 0)");
            entity.Property(e => e.E5).HasColumnType("numeric(3, 0)");
            entity.Property(e => e.E6).HasColumnType("numeric(3, 0)");
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Estado)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("ESTADO");
            entity.Property(e => e.Estado1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESTADO1");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAX");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Fecha1)
                .HasColumnType("datetime")
                .HasColumnName("FECHA1");
            entity.Property(e => e.Fecha2)
                .HasColumnType("datetime")
                .HasColumnName("FECHA2");
            entity.Property(e => e.Fecha3)
                .HasColumnType("datetime")
                .HasColumnName("FECHA3");
            entity.Property(e => e.Fechaactual)
                .HasPrecision(0)
                .HasColumnName("FECHAACTUAL");
            entity.Property(e => e.Iva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IVA");
            entity.Property(e => e.Lista)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("LISTA");
            entity.Property(e => e.Master)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MASTER");
            entity.Property(e => e.Modificacion)
                .HasColumnType("datetime")
                .HasColumnName("MODIFICACION");
            entity.Property(e => e.Ncelular)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NCELULAR");
            entity.Property(e => e.Ncelular2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NCELULAR2");
            entity.Property(e => e.Ncelular3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NCELULAR3");
            entity.Property(e => e.Nrounico)
                .ValueGeneratedOnAdd()
                .HasColumnName("NROUNICO");
            entity.Property(e => e.Parroquia)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("PARROQUIA");
            entity.Property(e => e.Plazo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("PLAZO");
            entity.Property(e => e.Referencia)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("REFERENCIA");
            entity.Property(e => e.Retencion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RETENCION");
            entity.Property(e => e.S1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.S2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.S3)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.S4)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.S5)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.S6)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.T1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.T2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.T3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.T4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.T5)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.T6)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.Telres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELRES");
            entity.Property(e => e.Tipocliente)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPOCLIENTE");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VENDEDOR");
            entity.Property(e => e.Zona)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("ZONA");
        });

        modelBuilder.Entity<Clientesat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CLIENTESAT");

            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Periodo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("PERIODO");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
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

        modelBuilder.Entity<Codigosiva>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("CODIGOSIVA_PK");

            entity.ToTable("CODIGOSIVA");

            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Valor)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("VALOR");
        });

        modelBuilder.Entity<Codigosvalor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CODIGOSVALOR");

            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.Valor)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("VALOR");
        });

        modelBuilder.Entity<Codigounidade>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("CODIGOUNIDADES_PK");

            entity.ToTable("CODIGOUNIDADES");

            entity.Property(e => e.Codigo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Valor)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("VALOR");
        });

        modelBuilder.Entity<Compania>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("COMPANIAS");

            entity.Property(e => e.BodCostos)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BOD_COSTOS");
            entity.Property(e => e.BodMalas)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BOD_MALAS");
            entity.Property(e => e.BodProceso)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BOD_PROCESO");
            entity.Property(e => e.BodVentas)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BOD_VENTAS");
            entity.Property(e => e.Cambio)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("CAMBIO");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.Codigo)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Costoventa)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("COSTOVENTA");
            entity.Property(e => e.Diaspedidos)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("DIASPEDIDOS");
            entity.Property(e => e.Direccion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Email)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Fax)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("FAX");
            entity.Property(e => e.Fconvenio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FCONVENIO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Fechadia)
                .HasPrecision(0)
                .HasColumnName("FECHADIA");
            entity.Property(e => e.Fraccion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("FRACCION");
            entity.Property(e => e.Iva)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("IVA");
            entity.Property(e => e.Lineasfacturas)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("LINEASFACTURAS");
            entity.Property(e => e.Moneda)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MONEDA");
            entity.Property(e => e.Nit)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("NIT");
            entity.Property(e => e.Nombre)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Pedidos)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("PEDIDOS");
            entity.Property(e => e.Porventa)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("PORVENTA");
            entity.Property(e => e.Precisionc)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("PRECISIONC");
            entity.Property(e => e.Precisione)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("PRECISIONE");
            entity.Property(e => e.Precisionv)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("PRECISIONV");
            entity.Property(e => e.Refecif)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REFECIF");
            entity.Property(e => e.Retencion)
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("RETENCION");
            entity.Property(e => e.Rif)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("RIF");
            entity.Property(e => e.Tamarticulo)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("TAMARTICULO");
            entity.Property(e => e.Tamcliente)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("TAMCLIENTE");
            entity.Property(e => e.Tampagina)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("TAMPAGINA");
            entity.Property(e => e.Telefono)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("TELEFONO");
            entity.Property(e => e.Vendedor)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("VENDEDOR");
        });

        modelBuilder.Entity<Costo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("COSTOS");

            entity.Property(e => e.Costo1)
                .HasColumnType("numeric(38, 5)")
                .HasColumnName("COSTO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(16, 3)")
                .HasColumnName("MONTO");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASA");
            entity.Property(e => e.Tasasf)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASASF");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<CostosRma>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("COSTOS_RMA");

            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Costot)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("COSTOT");
            entity.Property(e => e.Costou)
                .HasColumnType("numeric(28, 14)")
                .HasColumnName("COSTOU");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Destino)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("DESTINO");
            entity.Property(e => e.Doc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("DOC");
            entity.Property(e => e.Fecha).HasColumnName("FECHA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MARCA");
            entity.Property(e => e.Mes)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("MES");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODELO");
            entity.Property(e => e.Origen)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("ORIGEN");
            entity.Property(e => e.Tipo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<Cotizacione>(entity =>
        {
            entity.HasKey(e => new { e.Fecha, e.TipoDoc, e.Numero }).HasName("COTIZACIONES_PK");

            entity.ToTable("COTIZACIONES");

            entity.HasIndex(e => e.Cliente, "COTIZACIONES_IDX1");

            entity.HasIndex(e => e.TipoDoc, "COTIZACIONES_IDX2");

            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Bodega)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BODEGA");
            entity.Property(e => e.Cambio)
                .HasColumnType("numeric(11, 3)")
                .HasColumnName("CAMBIO");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Comentario)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.Cuotai)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("CUOTAI");
            entity.Property(e => e.Descuento)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.Dias)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("DIAS");
            entity.Property(e => e.FEmb)
                .HasColumnType("datetime")
                .HasColumnName("f_emb");
            entity.Property(e => e.FEnt)
                .HasColumnType("datetime")
                .HasColumnName("f_ent");
            entity.Property(e => e.FNac)
                .HasColumnType("datetime")
                .HasColumnName("f_nac");
            entity.Property(e => e.FProd)
                .HasColumnType("datetime")
                .HasColumnName("f_prod");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("FECHA_ASOC");
            entity.Property(e => e.Fechai)
                .HasColumnType("datetime")
                .HasColumnName("FECHAI");
            entity.Property(e => e.Interes)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("INTERES");
            entity.Property(e => e.Iva)
                .HasColumnType("numeric(14, 2)")
                .HasColumnName("IVA");
            entity.Property(e => e.Ncuotas)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NCUOTAS");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_ASOC");
            entity.Property(e => e.Pago)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("PAGO");
            entity.Property(e => e.Solicitud)
                .HasDefaultValue(0)
                .HasColumnName("SOLICITUD");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(11, 3)")
                .HasColumnName("TASA");
            entity.Property(e => e.TipoAsoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_ASOC");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(14, 2)")
                .HasColumnName("TOTAL");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VENDEDOR");

            entity.HasOne(d => d.TipoDocNavigation).WithMany(p => p.Cotizaciones)
                .HasForeignKey(d => d.TipoDoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("COTIZACIONES_FK2");
        });

        modelBuilder.Entity<Cotizacionesmov>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("COTIZACIONESMOV", tb => tb.HasTrigger("COSTO"));

            entity.HasIndex(e => new { e.Fecha, e.TipoDoc, e.Numero }, "COTIZACIONESMOV_IDX1");

            entity.HasIndex(e => e.Articulo, "COTIZACIONESMOV_IDX2");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Bodega)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("BODEGA");
            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Costo)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("COSTO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Precio)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("PRECIO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Valor)
                .HasColumnType("numeric(14, 2)")
                .HasColumnName("VALOR");
        });

        modelBuilder.Entity<Cotizacionesped>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("COTIZACIONESPED");

            entity.HasIndex(e => new { e.Fecha, e.TipoDoc, e.Numero }, "COTIZACIONESPED_IDX1");

            entity.HasIndex(e => e.Articulo, "COTIZACIONESPED_IDX2");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Bodega)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BODEGA");
            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Valor)
                .HasColumnType("numeric(14, 2)")
                .HasColumnName("VALOR");

            entity.HasOne(d => d.ArticuloNavigation).WithMany()
                .HasForeignKey(d => d.Articulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("COTIZACIONESPED_FK2");
        });

        modelBuilder.Entity<CuentaNotum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CUENTA_NOTA");

            entity.Property(e => e.Cadena)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CADENA");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<CuentaZoho>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CUENTA_ZOHO");

            entity.Property(e => e.Detalle).HasColumnName("DETALLE");
            entity.Property(e => e.Rif)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIF");
        });

        modelBuilder.Entity<CuotaImb>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cuota_imb");

            entity.Property(e => e.Articulo)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Fcuota)
                .HasColumnType("datetime")
                .HasColumnName("FCUOTA");
            entity.Property(e => e.Interes)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("INTERES");
            entity.Property(e => e.Nombre)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Nrocuota)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NROCUOTA");
            entity.Property(e => e.Nrofact)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NROFACT");
            entity.Property(e => e.Placa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLACA");
            entity.Property(e => e.Saldo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SALDO");
            entity.Property(e => e.Serialm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERIALM");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TelefonoAnalista)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO_ANALISTA");
            entity.Property(e => e.Tipofac)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPOFAC");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("vendedor");
        });

        modelBuilder.Entity<Cxc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CXC");

            entity.Property(e => e.Ciudad)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Comentario)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.Contacto)
                .HasMaxLength(85)
                .IsUnicode(false)
                .HasColumnName("CONTACTO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Expr1)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaLog)
                .HasPrecision(0)
                .HasColumnName("FECHA_LOG");
            entity.Property(e => e.Iva)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("IVA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_ASOC");
            entity.Property(e => e.NumeroLog)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_LOG");
            entity.Property(e => e.Plazo)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("PLAZO");
            entity.Property(e => e.Recibo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("RECIBO");
            entity.Property(e => e.Retencion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RETENCION");
            entity.Property(e => e.Saldo)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("SALDO");
            entity.Property(e => e.Saldod)
                .HasColumnType("numeric(28, 14)")
                .HasColumnName("saldod");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASA");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.TipoLog)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_LOG");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("TOTAL");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("vendedor");
        });

        modelBuilder.Entity<Cxc2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cxc2");

            entity.Property(e => e.Ciudad)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Comentario)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.Contacto)
                .HasMaxLength(85)
                .IsUnicode(false)
                .HasColumnName("CONTACTO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Expr1)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaLog)
                .HasPrecision(0)
                .HasColumnName("FECHA_LOG");
            entity.Property(e => e.Iva)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("IVA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_ASOC");
            entity.Property(e => e.NumeroLog)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_LOG");
            entity.Property(e => e.Plazo)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("PLAZO");
            entity.Property(e => e.Recibo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("RECIBO");
            entity.Property(e => e.Retencion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RETENCION");
            entity.Property(e => e.Saldo)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("SALDO");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASA");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.TipoLog)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_LOG");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("TOTAL");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("vendedor");
        });

        modelBuilder.Entity<DbLobOutputSession>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("db_LOB_output_session", "ssma_oracle");

            entity.Property(e => e.BValue).HasColumnName("b_value");
            entity.Property(e => e.CValue)
                .IsUnicode(false)
                .HasColumnName("c_value");
            entity.Property(e => e.NcValue).HasColumnName("nc_value");
            entity.Property(e => e.Ordinal).HasColumnName("ordinal");
        });

        modelBuilder.Entity<DbStorageCurrent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("db_storage_current", "ssma_oracle");

            entity.Property(e => e.BValue).HasColumnName("b_value");
            entity.Property(e => e.CValue)
                .IsUnicode(false)
                .HasColumnName("c_value");
            entity.Property(e => e.Name)
                .HasMaxLength(323)
                .HasColumnName("name");
            entity.Property(e => e.NcValue).HasColumnName("nc_value");
            entity.Property(e => e.VValue)
                .HasColumnType("sql_variant")
                .HasColumnName("v_value");
        });

        modelBuilder.Entity<Descuento>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DESCUENTO");

            entity.Property(e => e.Descuentobs)
                .HasColumnType("numeric(38, 5)")
                .HasColumnName("DESCUENTOBS");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<Descuentosiva>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DESCUENTOSIVA");

            entity.Property(e => e.Descuento)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.Tope)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TOPE");
        });

        modelBuilder.Entity<Despacho>(entity =>
        {
            entity.HasKey(e => new { e.Fecha, e.TipoDoc, e.Numero }).HasName("DESPACHOS_PK");

            entity.ToTable("DESPACHOS");

            entity.HasIndex(e => e.Cliente, "DESPACHOS_IDX1");

            entity.HasIndex(e => e.TipoDoc, "DESPACHOS_IDX2");

            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Bultos)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("BULTOS");
            entity.Property(e => e.Camara)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("CAMARA");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Docasoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DOCASOC");
            entity.Property(e => e.Fechaasoc)
                .HasPrecision(0)
                .HasColumnName("FECHAASOC");
            entity.Property(e => e.NroArticulos)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("NRO_ARTICULOS");
            entity.Property(e => e.Nrounico).HasColumnName("NROUNICO");
            entity.Property(e => e.Numeroasoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMEROASOC");
            entity.Property(e => e.Peso)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("PESO");
            entity.Property(e => e.Usuario)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("USUARIO");

            entity.HasOne(d => d.TipoDocNavigation).WithMany(p => p.Despachos)
                .HasForeignKey(d => d.TipoDoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("DESPACHOS_FK2");
        });

        modelBuilder.Entity<Despachosmov>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DESPACHOSMOV");

            entity.HasIndex(e => new { e.Fecha, e.TipoDoc, e.Numero }, "DESPACHOSMOV_IDX1");

            entity.HasIndex(e => e.Articulo, "DESPACHOSMOV_IDX2");

            entity.HasIndex(e => new { e.TipoDoc, e.Serial, e.Articulo }, "DESPACHOSMOV_IDX3");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Bodega)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("BODEGA");
            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Garantia)
                .HasColumnType("numeric(7, 2)")
                .HasColumnName("GARANTIA");
            entity.Property(e => e.Idcaja)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("IDCAJA");
            entity.Property(e => e.Idnumero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("IDNUMERO");
            entity.Property(e => e.Nrounico).HasColumnName("NROUNICO");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Serial)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SERIAL");
            entity.Property(e => e.Serial1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SERIAL1");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<Dne>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DNE");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Cadena)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CADENA");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("FECHA_ASOC");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_ASOC");
        });

        modelBuilder.Entity<Documento>(entity =>
        {
            entity.HasKey(e => e.Documento1).HasName("DOCUMENTOS_PK");

            entity.ToTable("DOCUMENTOS");

            entity.Property(e => e.Documento1)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DOCUMENTO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Nrounico)
                .ValueGeneratedOnAdd()
                .HasColumnName("NROUNICO");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Sucursal).HasColumnName("SUCURSAL");
            entity.Property(e => e.Titulo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TITULO");
        });

        modelBuilder.Entity<Documentoslogistica>(entity =>
        {
            entity.HasKey(e => e.Documento).HasName("DOCUMENTOSLOGISTICA_PK");

            entity.ToTable("DOCUMENTOSLOGISTICA");

            entity.Property(e => e.Documento)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DOCUMENTO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("NUMERO");
        });

        modelBuilder.Entity<DtvHist>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DTV_HIST");

            entity.Property(e => e.Acum)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("ACUM");
            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Cliente)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Fecha).HasColumnName("FECHA");
            entity.Property(e => e.Rif)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RIF");
        });

        modelBuilder.Entity<EdoCtaSimple>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EDO_CTA_SIMPLE");

            entity.Property(e => e.Banco)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BANCO");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Creditos)
                .HasColumnType("numeric(38, 3)")
                .HasColumnName("CREDITOS");
            entity.Property(e => e.Debitos)
                .HasColumnType("numeric(28, 14)")
                .HasColumnName("DEBITOS");
            entity.Property(e => e.Doc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DOC");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(38, 3)")
                .HasColumnName("MONTO");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
        });

        modelBuilder.Entity<EdoCtaSimple2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EDO_CTA_SIMPLE2");

            entity.Property(e => e.Banco)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BANCO");
            entity.Property(e => e.Cliente)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Credito)
                .HasColumnType("numeric(38, 3)")
                .HasColumnName("CREDITO");
            entity.Property(e => e.Debitos).HasColumnName("DEBITOS");
            entity.Property(e => e.Doc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("DOC");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MONTO");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
        });

        modelBuilder.Entity<EdoCtaSimple3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EDO_CTA_SIMPLE3");

            entity.Property(e => e.Banco)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("BANCO");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Creditos)
                .HasColumnType("numeric(28, 14)")
                .HasColumnName("CREDITOS");
            entity.Property(e => e.Debitos)
                .HasColumnType("numeric(28, 14)")
                .HasColumnName("DEBITOS");
            entity.Property(e => e.Doc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DOC");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MONTO");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
        });

        modelBuilder.Entity<EdoCuenta2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EDO_CUENTA2");

            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.PorVencer)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("POR_VENCER");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("TOTAL");
            entity.Property(e => e.Vencido)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("VENCIDO");
        });

        modelBuilder.Entity<EdoCuentum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EDO_CUENTA");

            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Plazo)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("PLAZO");
            entity.Property(e => e.PorVencer)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("POR_VENCER");
            entity.Property(e => e.Saldo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SALDO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Vencido)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VENCIDO");
        });

        modelBuilder.Entity<Ensamble>(entity =>
        {
            entity.HasKey(e => new { e.Articulo, e.ArticuloAsoc }).HasName("ENSAMBLES_PK");

            entity.ToTable("ENSAMBLES");

            entity.HasIndex(e => e.Articulo, "ENSAMBLES_IDX1");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.ArticuloAsoc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO_ASOC");
            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("CANTIDAD");

            entity.HasOne(d => d.ArticuloNavigation).WithMany(p => p.Ensambles)
                .HasForeignKey(d => d.Articulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ENSAMBLES_FK1");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.Estado1).HasName("ESTADOS_PK");

            entity.ToTable("ESTADOS");

            entity.HasIndex(e => e.Descripcion, "ESTADOS_IDX1");

            entity.Property(e => e.Estado1).HasColumnName("ESTADO");
            entity.Property(e => e.Codzona).HasColumnName("CODZONA");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Porcentaje).HasColumnName("PORCENTAJE");
            entity.Property(e => e.Tplink).HasColumnName("TPLINK");
        });

        modelBuilder.Entity<Estadofiltro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ESTADOFILTRO");

            entity.Property(e => e.Estado).HasColumnName("ESTADO");
            entity.Property(e => e.Marca)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MARCA");
            entity.Property(e => e.Moa).HasColumnName("MOA");
        });

        modelBuilder.Entity<F>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("F");

            entity.Property(e => e.Bodega)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BODEGA");
            entity.Property(e => e.Bultos)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("BULTOS");
            entity.Property(e => e.Cambio)
                .HasColumnType("numeric(11, 3)")
                .HasColumnName("CAMBIO");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Comentario)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.Comentario2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO2");
            entity.Property(e => e.Descuento)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.Despachos)
                .HasPrecision(0)
                .HasColumnName("DESPACHOS");
            entity.Property(e => e.Ensamble)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ENSAMBLE");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("FECHA_ASOC");
            entity.Property(e => e.FechaLog)
                .HasPrecision(0)
                .HasColumnName("FECHA_LOG");
            entity.Property(e => e.Invoice)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("INVOICE");
            entity.Property(e => e.Iva)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("IVA");
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MONEDA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_ASOC");
            entity.Property(e => e.NumeroLog)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_LOG");
            entity.Property(e => e.Plazo)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("PLAZO");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASA");
            entity.Property(e => e.Tasaasoc)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASAASOC");
            entity.Property(e => e.Tasar)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASAR");
            entity.Property(e => e.TipoAsoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_ASOC");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.TipoLog)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_LOG");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("TOTAL");
            entity.Property(e => e.Transporte)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("TRANSPORTE");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VENDEDOR");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FACTURAS", tb =>
                {
                    tb.HasTrigger("DEV");
                    tb.HasTrigger("ESTATUS");
                    tb.HasTrigger("LIBERACION");
                    tb.HasTrigger("LINKF");
                });

            entity.HasIndex(e => e.Cliente, "FACTURAS_IDX1");

            entity.HasIndex(e => e.TipoDoc, "FACTURAS_IDX2");

            entity.HasIndex(e => new { e.TipoAsoc, e.FechaAsoc, e.NumeroAsoc }, "FACTURAS_IDX3");

            entity.Property(e => e.Baseigtf)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("BASEIGTF");
            entity.Property(e => e.Bodega)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BODEGA");
            entity.Property(e => e.Bultos)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("BULTOS");
            entity.Property(e => e.Cambio)
                .HasColumnType("numeric(11, 3)")
                .HasColumnName("CAMBIO");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Comentario)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.Comentario2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO2");
            entity.Property(e => e.Cuotai)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("CUOTAI");
            entity.Property(e => e.Despachado)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(2, 0)")
                .HasColumnName("DESPACHADO");
            entity.Property(e => e.Despacho)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESPACHO");
            entity.Property(e => e.Dias)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("DIAS");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOCUMENTO");
            entity.Property(e => e.Ejecutivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EJECUTIVO");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Estatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESTATUS");
            entity.Property(e => e.Exento)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("EXENTO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("FECHA_ASOC");
            entity.Property(e => e.FechaDes)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DES");
            entity.Property(e => e.FechaLog)
                .HasPrecision(0)
                .HasColumnName("FECHA_LOG");
            entity.Property(e => e.Fechai)
                .HasColumnType("datetime")
                .HasColumnName("FECHAI");
            entity.Property(e => e.Igtf)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("IGTF");
            entity.Property(e => e.Interes)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("INTERES");
            entity.Property(e => e.Invoice)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("INVOICE");
            entity.Property(e => e.Iva)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("IVA");
            entity.Property(e => e.Link)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LINK");
            entity.Property(e => e.Modificacion)
                .HasColumnType("datetime")
                .HasColumnName("MODIFICACION");
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MONEDA");
            entity.Property(e => e.Ncon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NCON");
            entity.Property(e => e.Ncuotas)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NCUOTAS");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_ASOC");
            entity.Property(e => e.NumeroLog)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_LOG");
            entity.Property(e => e.Plazo)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("PLAZO");
            entity.Property(e => e.Porcentaje)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("PORCENTAJE");
            entity.Property(e => e.Rcon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RCON");
            entity.Property(e => e.Sede)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SEDE");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASA");
            entity.Property(e => e.Tasaasoc)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASAASOC");
            entity.Property(e => e.Tasar)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASAR");
            entity.Property(e => e.TipoAsoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_ASOC");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.TipoLog)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_LOG");
            entity.Property(e => e.Tipof)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TIPOf");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("TOTAL");
            entity.Property(e => e.Transporte)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("TRANSPORTE");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VENDEDOR");
        });

        modelBuilder.Entity<Facturasmov>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FACTURASMOV", tb =>
                {
                    tb.HasTrigger("CTRL_ASOC");
                    tb.HasTrigger("ITEMD");
                });

            entity.HasIndex(e => new { e.Fecha, e.TipoDoc, e.Numero }, "FACTURASMOV_IDX1");

            entity.HasIndex(e => e.Articulo, "FACTURASMOV_IDX2");

            entity.HasIndex(e => new { e.TipoDoc, e.Articulo, e.Fecha }, "FACTURASMOV_IDX3");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Bodega)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BODEGA");
            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Costo)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("COSTO");
            entity.Property(e => e.Costobs)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("COSTOBS");
            entity.Property(e => e.Costod)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("COSTOD");
            entity.Property(e => e.Despacho)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("DESPACHO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("FECHA_ASOC");
            entity.Property(e => e.Nrounico)
                .ValueGeneratedOnAdd()
                .HasColumnName("NROUNICO");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_ASOC");
            entity.Property(e => e.Obs)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("OBS");
            entity.Property(e => e.Placa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLACA");
            entity.Property(e => e.Precio)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("PRECIO");
            entity.Property(e => e.Puntos)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("PUNTOS");
            entity.Property(e => e.Serialm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERIALM");
            entity.Property(e => e.TipoAsoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_ASOC");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Valor)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("VALOR");
            entity.Property(e => e.Valord)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("VALORD");
        });

        modelBuilder.Entity<Facturasped>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FACTURASPED");

            entity.HasIndex(e => new { e.Fecha, e.TipoDoc, e.Numero }, "FACTURASPED_IDX1");

            entity.HasIndex(e => e.Articulo, "FACTURASPED_IDX2");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Descuento)
                .HasColumnType("numeric(5, 2)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");

            entity.HasOne(d => d.ArticuloNavigation).WithMany()
                .HasForeignKey(d => d.Articulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FACTURASPED_FK2");
        });

        modelBuilder.Entity<Facturassaldo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FACTURASSALDOS");

            entity.HasIndex(e => new { e.Fecha, e.TipoDoc, e.Numero }, "FACTURASSALDOS_IDX1");

            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Fechaasoc)
                .HasPrecision(0)
                .HasColumnName("FECHAASOC");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Numeroasoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMEROASOC");
            entity.Property(e => e.Recibo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("RECIBO");
            entity.Property(e => e.Saldo)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("SALDO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Tipoasoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPOASOC");
        });

        modelBuilder.Entity<FacturassaldoCierre>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FACTURASSALDO_CIERRE");

            entity.Property(e => e.Cliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Periodo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PERIODO");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<FacturassaldosHist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FACTURASSALDOS_HIST");

            entity.Property(e => e.Descuento)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Periodo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PERIODO");
            entity.Property(e => e.Recibo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("RECIBO");
            entity.Property(e => e.Saldo)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("SALDO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<FacturassaldosMod>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FACTURASSALDOS_MOD");

            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Fechaasoc)
                .HasPrecision(0)
                .HasColumnName("FECHAASOC");
            entity.Property(e => e.Fecham)
                .HasColumnType("datetime")
                .HasColumnName("FECHAM");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Numeroasoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMEROASOC");
            entity.Property(e => e.Numerom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUMEROM");
            entity.Property(e => e.Recibo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("RECIBO");
            entity.Property(e => e.Saldo)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("SALDO");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Tipoasoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPOASOC");
            entity.Property(e => e.Tipom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOM");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<Financiador>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FINANCIADOR");

            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("FECHA_ASOC");
            entity.Property(e => e.Fechai)
                .HasColumnType("datetime")
                .HasColumnName("FECHAI");
            entity.Property(e => e.Interes)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("INTERES");
            entity.Property(e => e.Ncuotas)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NCUOTAS");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_ASOC");
            entity.Property(e => e.TipoAsoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_ASOC");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Valor)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("VALOR");
            entity.Property(e => e.Vcuota)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("VCUOTA");
            entity.Property(e => e.Vinteres)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("VINTERES");
        });

        modelBuilder.Entity<Garantia>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GARANTIAS");

            entity.HasIndex(e => e.Cliente, "GARANTIAS_IDX1");

            entity.HasIndex(e => e.TipoDoc, "GARANTIAS_IDX2");

            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Comentario)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Fechagar)
                .HasPrecision(0)
                .HasColumnName("FECHAGAR");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Numerogar)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMEROGAR");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Tipogar)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPOGAR");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<Garantiasactual>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GARANTIASACTUAL");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(14, 0)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Diagnostico)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DIAGNOSTICO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Serial)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("SERIAL");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<Garantiasmov>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GARANTIASMOV");

            entity.HasIndex(e => new { e.Fecha, e.TipoDoc, e.Numero }, "GARANTIASMOV_IDX1");

            entity.HasIndex(e => e.Articulo, "GARANTIASMOV_IDX2");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(14, 0)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Diagnostico)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DIAGNOSTICO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("FECHA_ASOC");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_ASOC");
            entity.Property(e => e.Serial)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("SERIAL");
            entity.Property(e => e.TipoAsoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_ASOC");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<HistSma>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HIST_SMA");

            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Menoscinco)
                .HasColumnType("numeric(38, 14)")
                .HasColumnName("MENOSCINCO");
            entity.Property(e => e.Menoscuatro)
                .HasColumnType("numeric(38, 14)")
                .HasColumnName("MENOSCUATRO");
            entity.Property(e => e.Menosdiez)
                .HasColumnType("numeric(38, 14)")
                .HasColumnName("MENOSDIEZ");
            entity.Property(e => e.Menosdoce)
                .HasColumnType("numeric(38, 14)")
                .HasColumnName("MENOSDOCE");
            entity.Property(e => e.Menosdos)
                .HasColumnType("numeric(38, 14)")
                .HasColumnName("MENOSDOS");
            entity.Property(e => e.Menosnueve)
                .HasColumnType("numeric(38, 14)")
                .HasColumnName("MENOSNUEVE");
            entity.Property(e => e.Menosocho)
                .HasColumnType("numeric(38, 14)")
                .HasColumnName("MENOSOCHO");
            entity.Property(e => e.Menosonce)
                .HasColumnType("numeric(38, 14)")
                .HasColumnName("MENOSONCE");
            entity.Property(e => e.Menosseis)
                .HasColumnType("numeric(38, 14)")
                .HasColumnName("MENOSSEIS");
            entity.Property(e => e.Menossiete)
                .HasColumnType("numeric(38, 14)")
                .HasColumnName("MENOSSIETE");
            entity.Property(e => e.Menostres)
                .HasColumnType("numeric(38, 14)")
                .HasColumnName("MENOSTRES");
            entity.Property(e => e.Menosuno)
                .HasColumnType("numeric(38, 14)")
                .HasColumnName("MENOSUNO");
            entity.Property(e => e.Montod)
                .HasColumnType("numeric(38, 14)")
                .HasColumnName("MONTOD");
            entity.Property(e => e.Satelital)
                .HasColumnType("numeric(38, 14)")
                .HasColumnName("SATELITAL");
            entity.Property(e => e.Test1).HasColumnName("TEST1");
            entity.Property(e => e.Test10).HasColumnName("TEST10");
            entity.Property(e => e.Test11).HasColumnName("TEST11");
            entity.Property(e => e.Test12).HasColumnName("TEST12");
            entity.Property(e => e.Test2).HasColumnName("TEST2");
            entity.Property(e => e.Test3).HasColumnName("TEST3");
            entity.Property(e => e.Test4).HasColumnName("TEST4");
            entity.Property(e => e.Test5).HasColumnName("TEST5");
            entity.Property(e => e.Test6).HasColumnName("TEST6");
            entity.Property(e => e.Test7).HasColumnName("TEST7");
            entity.Property(e => e.Test8).HasColumnName("TEST8");
            entity.Property(e => e.Test9).HasColumnName("TEST9");
            entity.Property(e => e.Vtamesactual)
                .HasColumnType("numeric(38, 14)")
                .HasColumnName("VTAMESACTUAL");
        });

        modelBuilder.Entity<Importacione>(entity =>
        {
            entity.HasKey(e => new { e.TipoDoc, e.Fecha, e.Numero });

            entity.ToTable("IMPORTACIONES");

            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Tipo_Doc");
            entity.Property(e => e.Fecha).HasPrecision(0);
            entity.Property(e => e.Numero).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.Cambio).HasColumnType("numeric(11, 3)");
            entity.Property(e => e.Cliente)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("Fecha_Asoc");
            entity.Property(e => e.Invoice)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("INVOICE");
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("Numero_Asoc");
            entity.Property(e => e.TipoAsoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Tipo_Asoc");
            entity.Property(e => e.Total).HasColumnType("numeric(15, 3)");
            entity.Property(e => e.TotalCif)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("Total_CIF");
            entity.Property(e => e.TotalFob)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("Total_FOB");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Importacionesmov>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMPORTACIONESMOV");

            entity.Property(e => e.Codigo)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("CODIGO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Valor)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("VALOR");
        });

        modelBuilder.Entity<Impresione>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMPRESIONES");

            entity.HasIndex(e => e.Impresora, "IMPRESIONES_IDX1");

            entity.Property(e => e.Bodega)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BODEGA");
            entity.Property(e => e.Bodegaf)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BODEGAF");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.Impresora)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IMPRESORA");
            entity.Property(e => e.Progasoc)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PROGASOC");
            entity.Property(e => e.Programa)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("PROGRAMA");

            entity.HasOne(d => d.ImpresoraNavigation).WithMany()
                .HasForeignKey(d => d.Impresora)
                .HasConstraintName("IMPRESIONES_FK1");
        });

        modelBuilder.Entity<Impresora>(entity =>
        {
            entity.HasKey(e => e.Impresora1).HasName("IMPRESORAS_PK");

            entity.ToTable("IMPRESORAS");

            entity.Property(e => e.Impresora1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IMPRESORA");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
        });

        modelBuilder.Entity<Kardex>(entity =>
        {
            entity.HasKey(e => new { e.Fecha, e.Articulo }).HasName("KARDEX_PK");

            entity.ToTable("KARDEX");

            entity.HasIndex(e => e.Articulo, "KARDEX_IDX1");

            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.CantEns)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("CANT_ENS");
            entity.Property(e => e.CantEnt)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("CANT_ENT");
            entity.Property(e => e.CantFact)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("CANT_FACT");
            entity.Property(e => e.CantIn)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("CANT_IN");
            entity.Property(e => e.CantOut)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("CANT_OUT");
            entity.Property(e => e.Saldo)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("SALDO");
        });

        modelBuilder.Entity<Kardexold>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KARDEXOLD");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("articulo");
            entity.Property(e => e.Fecha)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("fecha");
            entity.Property(e => e.Saldo)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("saldo");
        });

        modelBuilder.Entity<Kardold>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KARDOLD");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("articulo");
            entity.Property(e => e.CantEns)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("CANT_ENS");
            entity.Property(e => e.CantEnt)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("CANT_ENT");
            entity.Property(e => e.CantFact)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("CANT_FACT");
            entity.Property(e => e.CantOut)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("CANT_OUT");
            entity.Property(e => e.Saldo)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("SALDO");
        });

        modelBuilder.Entity<LatestFob>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LATEST_FOB");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Fob)
                .HasColumnType("numeric(34, 19)")
                .HasColumnName("FOB");
        });

        modelBuilder.Entity<Leap>(entity =>
        {
            entity.HasKey(e => e.Cliente);

            entity.ToTable("LEAPS");

            entity.Property(e => e.Cliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Cargo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARGO");
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Representante)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REPRESENTANTE");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
        });

        modelBuilder.Entity<Listap>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LISTAP");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Cif)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("CIF");
            entity.Property(e => e.Existencia)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("EXISTENCIA");
            entity.Property(e => e.Factor)
                .HasColumnType("numeric(11, 2)")
                .HasColumnName("FACTOR");
            entity.Property(e => e.Fob)
                .HasColumnType("numeric(34, 19)")
                .HasColumnName("FOB");
            entity.Property(e => e.Precio)
                .HasColumnType("numeric(24, 5)")
                .HasColumnName("PRECIO");
            entity.Property(e => e.Precio1)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("PRECIO_$");
            entity.Property(e => e.Profit)
                .HasColumnType("numeric(29, 16)")
                .HasColumnName("PROFIT");
        });

        modelBuilder.Entity<Logcliente>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGCLIENTE", tb => tb.HasTrigger("TASA"));

            entity.Property(e => e.Cambio)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("CAMBIO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Fechalog)
                .HasColumnType("datetime")
                .HasColumnName("FECHALOG");
            entity.Property(e => e.Nrounico)
                .ValueGeneratedOnAdd()
                .HasColumnName("NROUNICO");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Saldo)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("SALDO");
            entity.Property(e => e.Saldod)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("SALDOD");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<Logcobranza>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LOGCOBRANZA");

            entity.Property(e => e.Cobrado)
                .HasColumnType("numeric(38, 3)")
                .HasColumnName("COBRADO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<Logistica>(entity =>
        {
            entity.HasKey(e => new { e.Fecha, e.TipoDoc, e.Numero }).HasName("LOGISTICA_PK");

            entity.ToTable("LOGISTICA");

            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Camara).HasColumnName("CAMARA");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Comentario)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.Flete)
                .HasColumnType("numeric(13, 3)")
                .HasColumnName("FLETE");
            entity.Property(e => e.Otros)
                .HasColumnType("numeric(13, 3)")
                .HasColumnName("OTROS");
            entity.Property(e => e.TipoEnvio).HasColumnName("TIPO_ENVIO");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(13, 3)")
                .HasColumnName("TOTAL");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.Vehiculo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VEHICULO");
            entity.Property(e => e.Zona).HasColumnName("ZONA");

            entity.HasOne(d => d.TipoDocNavigation).WithMany(p => p.Logisticas)
                .HasForeignKey(d => d.TipoDoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("LOGISTICA_FK1");
        });

        modelBuilder.Entity<Logisticamov>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGISTICAMOV");

            entity.Property(e => e.Bultos).HasColumnName("BULTOS");
            entity.Property(e => e.Cambio)
                .HasColumnType("numeric(11, 3)")
                .HasColumnName("CAMBIO");
            entity.Property(e => e.Entrega).HasColumnName("ENTREGA");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("FECHA_ASOC");
            entity.Property(e => e.FechaLog)
                .HasPrecision(0)
                .HasColumnName("FECHA_LOG");
            entity.Property(e => e.NroArticulos)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("NRO_ARTICULOS");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_ASOC");
            entity.Property(e => e.NumeroLog).HasColumnName("NUMERO_LOG");
            entity.Property(e => e.NumeroPic).HasColumnName("NUMERO_PIC");
            entity.Property(e => e.TipoAsoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_ASOC");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.TipoLog)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_LOG");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(13, 3)")
                .HasColumnName("TOTAL");
            entity.Property(e => e.Zona).HasColumnName("ZONA");
        });

        modelBuilder.Entity<Logisticamovart>(entity =>
        {
            entity.HasKey(e => new { e.Fecha, e.TipoDoc, e.Numero, e.Articulo, e.Bodega }).HasName("LOGISTICAMOVART_PK");

            entity.ToTable("LOGISTICAMOVART");

            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Bodega).HasColumnName("BODEGA");
            entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");
            entity.Property(e => e.Garantia)
                .HasColumnType("numeric(7, 2)")
                .HasColumnName("GARANTIA");
            entity.Property(e => e.Valor)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("VALOR");

            entity.HasOne(d => d.ArticuloNavigation).WithMany(p => p.Logisticamovarts)
                .HasForeignKey(d => d.Articulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("LOGISTICAMOVART_FK2");

            entity.HasOne(d => d.Logistica).WithMany(p => p.Logisticamovarts)
                .HasForeignKey(d => new { d.Fecha, d.TipoDoc, d.Numero })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("LOGISTICAMOVART_FK1");
        });

        modelBuilder.Entity<Logisticaseg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOGISTICASEG");

            entity.Property(e => e.Ciudad)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.Estado)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("ESTADO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaSeg)
                .HasPrecision(0)
                .HasColumnName("FECHA_SEG");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<Logisticaseriale>(entity =>
        {
            entity.HasKey(e => new { e.TipoDoc, e.Fecha, e.Numero, e.Articulo, e.Bodega, e.Serial });

            entity.ToTable("LOGISTICASERIALES");

            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Bodega).HasColumnName("BODEGA");
            entity.Property(e => e.Serial)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SERIAL");
            entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");
            entity.Property(e => e.Serial1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SERIAL1");

            entity.HasOne(d => d.ArticuloNavigation).WithMany(p => p.Logisticaseriales)
                .HasForeignKey(d => d.Articulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("LOGISTICASERIALES_FK2");
        });

        modelBuilder.Entity<Masteraccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MASTERACCOUNT");

            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Master)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MASTER");
            entity.Property(e => e.Nmaster)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("NMASTER");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MENU");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Esreporte)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESREPORTE");
            entity.Property(e => e.Nombre)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Progasoc)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PROGASOC");
            entity.Property(e => e.Programa)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("PROGRAMA");
        });

        modelBuilder.Entity<Menuydocumento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MENUYDOCUMENTOS");

            entity.Property(e => e.Nombre)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Nombredocs)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NOMBREDOCS");
            entity.Property(e => e.Programa)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PROGRAMA");
            entity.Property(e => e.Tipodocs)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("TIPODOCS");
        });

        modelBuilder.Entity<Modif>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MODIF");

            entity.Property(e => e.Cuotatotal)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("CUOTATOTAL");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("FECHA_ASOC");
            entity.Property(e => e.Fechai)
                .HasColumnType("datetime")
                .HasColumnName("FECHAI");
            entity.Property(e => e.Interes)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("INTERES");
            entity.Property(e => e.InteresAntes)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("INTERES_ANTES");
            entity.Property(e => e.Interesa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("INTERESA");
            entity.Property(e => e.Interestotal)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("INTERESTOTAL");
            entity.Property(e => e.Ncuotas)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NCUOTAS");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_ASOC");
            entity.Property(e => e.SaldoAntes)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SALDO_ANTES");
            entity.Property(e => e.Saldoa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("SALDOA");
            entity.Property(e => e.TipoAsoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_ASOC");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Valor)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("VALOR");
            entity.Property(e => e.Vcuota)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("VCUOTA");
            entity.Property(e => e.Vinteres)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("VINTERES");
        });

        modelBuilder.Entity<Modusuario>(entity =>
        {
            entity.HasKey(e => e.Usuario).HasName("MODUSUSARIOS_PK");

            entity.ToTable("MODUSUARIOS");

            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.Bodega)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BODEGA");
            entity.Property(e => e.Bodegas)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("BODEGAS");
            entity.Property(e => e.Clave)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CLAVE");
            entity.Property(e => e.Descuento)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.Grafico)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("GRAFICO");
            entity.Property(e => e.Modulo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("MODULO");
            entity.Property(e => e.Plazo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("PLAZO");
            entity.Property(e => e.Presupuesto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PRESUPUESTO");
            entity.Property(e => e.Prioridad)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("PRIORIDAD");
            entity.Property(e => e.Remoto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("REMOTO");
        });

        modelBuilder.Entity<Moneda>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MONEDAS");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Moneda1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("MONEDA");
        });

        modelBuilder.Entity<Monedashistorico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MONEDASHISTORICO");

            entity.Property(e => e.Cambio)
                .HasColumnType("numeric(11, 2)")
                .HasColumnName("CAMBIO");
            entity.Property(e => e.Comentario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.Costo)
                .HasColumnType("numeric(11, 2)")
                .HasColumnName("COSTO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Moneda)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("MONEDA");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<Orctransito>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ORCTRANSITO");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Cargado)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("CARGADO");
            entity.Property(e => e.Comentario)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.FechaOdc)
                .HasPrecision(0)
                .HasColumnName("FECHA ODC");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MARCA");
            entity.Property(e => e.Odc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("ODC#");
            entity.Property(e => e.Pedido)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("PEDIDO");
            entity.Property(e => e.Transito)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("TRANSITO");
        });

        modelBuilder.Entity<Pcompra>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PCOMPRA");

            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Pcompra1)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("PCOMPRA");
            entity.Property(e => e.Pcvend)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PCVEND");
        });

        modelBuilder.Entity<PedidosZoho>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PEDIDOS_ZOHO");

            entity.Property(e => e.Articulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Descuento)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.DescuentoG)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("DESCUENTO_G");
            entity.Property(e => e.Fecha).HasColumnName("FECHA");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CLIENTE");
            entity.Property(e => e.NumeroPed)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NUMERO_PED");
            entity.Property(e => e.Precio)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("PRECIO");
        });

        modelBuilder.Entity<Pedynota2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PEDYNOTA2");

            entity.Property(e => e.Cambio)
                .HasColumnType("numeric(11, 3)")
                .HasColumnName("CAMBIO");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Comentario)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Direccion)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Iva)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("IVA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Porcentaje)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("PORCENTAJE");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(11, 2)")
                .HasColumnName("TASA");
            entity.Property(e => e.Tipo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("TOTAL");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VENDEDOR");
        });

        modelBuilder.Entity<Pedynotah>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PEDYNOTAH");

            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.NDoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("N_DOC");
            entity.Property(e => e.PDolar)
                .HasColumnType("numeric(28, 14)")
                .HasColumnName("P_DOLAR");
            entity.Property(e => e.Precio)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("PRECIO");
            entity.Property(e => e.Producto)
                .IsUnicode(false)
                .HasColumnName("PRODUCTO");
            entity.Property(e => e.SubtDolar)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("SUBT_DOLAR");
            entity.Property(e => e.Subtotal)
                .HasColumnType("numeric(28, 5)")
                .HasColumnName("SUBTOTAL");
            entity.Property(e => e.Tipo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<Pedynotah2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PEDYNOTAH2");

            entity.Property(e => e.Ciudad)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Comentario)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Direccion)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Iva)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("IVA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(11, 2)")
                .HasColumnName("TASA");
            entity.Property(e => e.Tipo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("TOTAL");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VENDEDOR");
        });

        modelBuilder.Entity<Pedynotum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PEDYNOTA");

            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.NDoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("N_DOC");
            entity.Property(e => e.PDolar)
                .HasColumnType("numeric(28, 14)")
                .HasColumnName("P_DOLAR");
            entity.Property(e => e.Precio)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("PRECIO");
            entity.Property(e => e.Producto)
                .IsUnicode(false)
                .HasColumnName("PRODUCTO");
            entity.Property(e => e.SubtDolar)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("SUBT_DOLAR");
            entity.Property(e => e.Subtotal)
                .HasColumnType("numeric(28, 5)")
                .HasColumnName("SUBTOTAL");
            entity.Property(e => e.Tipo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<PlantillaStandard>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PLANTILLA_STANDARD");

            entity.Property(e => e.AnoF)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANO_F");
            entity.Property(e => e.AnoModelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANO_MODELO");
            entity.Property(e => e.Chequeo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CHEQUEO");
            entity.Property(e => e.Clase)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLASE");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COLOR");
            entity.Property(e => e.Comentario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.DiametroRin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIAMETRO_RIN");
            entity.Property(e => e.FComericial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("F_COMERICIAL");
            entity.Property(e => e.FFechaComercial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("F_FECHA_COMERCIAL");
            entity.Property(e => e.FPlanillaImpuesto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("F_PLANILLA_IMPUESTO");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARCA");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODELO");
            entity.Property(e => e.NMotor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("N_MOTOR");
            entity.Property(e => e.NNiv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("N_NIV");
            entity.Property(e => e.NroAsientos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NRO_ASIENTOS");
            entity.Property(e => e.NroEjes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NRO_EJES");
            entity.Property(e => e.PImpuesto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P_IMPUESTO");
            entity.Property(e => e.PLlegada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P_LLEGADA");
            entity.Property(e => e.Pesobruto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PESOBRUTO");
            entity.Property(e => e.Pesotara)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PESOTARA");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.Uso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USO");
        });

        modelBuilder.Entity<Profit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PROFIT");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Cant)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("CANT");
            entity.Property(e => e.Costo)
                .HasColumnType("numeric(38, 12)")
                .HasColumnName("COSTO $");
            entity.Property(e => e.Costou)
                .HasColumnType("numeric(30, 15)")
                .HasColumnName("COSTOU$");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Desct)
                .HasColumnType("numeric(35, 19)")
                .HasColumnName("DESCT");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Precio)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("PRECIO");
            entity.Property(e => e.Precio1)
                .HasColumnType("numeric(29, 14)")
                .HasColumnName("PRECIO$");
            entity.Property(e => e.Profit1)
                .HasColumnType("numeric(38, 9)")
                .HasColumnName("PROFIT");
            entity.Property(e => e.Subtotal)
                .HasColumnType("numeric(38, 12)")
                .HasColumnName("SUBTOTAL $");
            entity.Property(e => e.Tipo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.Utilidad)
                .HasColumnType("numeric(38, 12)")
                .HasColumnName("UTILIDAD $");
        });

        modelBuilder.Entity<Profit2019>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PROFIT2019");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Cant)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("CANT");
            entity.Property(e => e.Costo)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("COSTO $");
            entity.Property(e => e.Costou)
                .HasColumnType("numeric(28, 14)")
                .HasColumnName("COSTOU$");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Desct)
                .HasColumnType("numeric(35, 19)")
                .HasColumnName("DESCT");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Precio)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("PRECIO");
            entity.Property(e => e.Precio1)
                .HasColumnType("numeric(28, 14)")
                .HasColumnName("PRECIO$");
            entity.Property(e => e.Profit)
                .HasColumnType("numeric(38, 9)")
                .HasColumnName("PROFIT");
            entity.Property(e => e.Subtotal)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("SUBTOTAL $");
            entity.Property(e => e.Tipo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.Utilidad)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("UTILIDAD $");
        });

        modelBuilder.Entity<PuntajeTiempo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PUNTAJE_TIEMPOS");

            entity.Property(e => e.Antcierre)
                .HasColumnType("numeric(28, 14)")
                .HasColumnName("ANTCIERRE");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Despacho)
                .HasPrecision(0)
                .HasColumnName("DESPACHO");
            entity.Property(e => e.Diasacierre).HasColumnName("DIASACIERRE");
            entity.Property(e => e.Diascredito)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("DIASCREDITO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Fechacierre)
                .HasColumnType("datetime")
                .HasColumnName("FECHACIERRE");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(30, 15)")
                .HasColumnName("MONTO");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<Recibo>(entity =>
        {
            entity.HasKey(e => new { e.Fecha, e.TipoDoc, e.Numero }).HasName("RECIBOS_PK");

            entity.ToTable("RECIBOS");

            entity.HasIndex(e => e.Cliente, "RECIBOS_IDX1");

            entity.HasIndex(e => e.TipoDoc, "RECIBOS_IDX2");

            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Bigtf)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BIGTF");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Comentario)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("FECHA_ASOC");
            entity.Property(e => e.Igtf)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("IGTF");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_ASOC");
            entity.Property(e => e.TipoAsoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_ASOC");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("TOTAL");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<Recibosmov>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RECIBOSMOV");

            entity.HasIndex(e => new { e.Fecha, e.TipoDoc, e.Numero }, "RECIBOSMOV_IDX1");

            entity.HasIndex(e => new { e.TipoAsoc, e.FechaAsoc, e.NumeroAsoc }, "RECIBOSMOV_IDX2");

            entity.Property(e => e.Cliente)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("FECHA_ASOC");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_ASOC");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.TipoAsoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_ASOC");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Valor)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("VALOR");
        });

        modelBuilder.Entity<Recibosmovfp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RECIBOSMOVFP");

            entity.HasIndex(e => new { e.Fecha, e.TipoDoc, e.Numero }, "RECIBOSMOVFP_IDX1");

            entity.HasIndex(e => new { e.TipoDoc, e.Fecha, e.Numero, e.Banco }, "RECIBOSMOVFP_IDX2");

            entity.HasIndex(e => new { e.FechaAsoc, e.TipoAsoc, e.NumeroAsoc }, "RECIBOSMOVFP_IDX3");

            entity.Property(e => e.Banco)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("BANCO");
            entity.Property(e => e.Cheque)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CHEQUE");
            entity.Property(e => e.Cliente)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("FECHA_ASOC");
            entity.Property(e => e.Fecharef)
                .HasPrecision(0)
                .HasColumnName("fecharef");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("numero_asoc");
            entity.Property(e => e.Precio)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("PRECIO");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.TipoAsoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("tipo_asoc");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Valor)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("VALOR");
        });

        modelBuilder.Entity<Recibosmovfpold>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("recibosmovfpold");

            entity.Property(e => e.Banco)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("BANCO");
            entity.Property(e => e.Cheque)
                .HasColumnType("numeric(14, 0)")
                .HasColumnName("CHEQUE");
            entity.Property(e => e.Cliente)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("FECHA_ASOC");
            entity.Property(e => e.Fecharef)
                .HasPrecision(0)
                .HasColumnName("fecharef");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("numero_asoc");
            entity.Property(e => e.Precio)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("PRECIO");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.TipoAsoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("tipo_asoc");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Valor)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("VALOR");
        });

        modelBuilder.Entity<Recibosmovfpold1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("recibosmovfpold1");

            entity.Property(e => e.Banco)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("BANCO");
            entity.Property(e => e.Cheque)
                .HasColumnType("numeric(14, 0)")
                .HasColumnName("CHEQUE");
            entity.Property(e => e.Cliente)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("FECHA_ASOC");
            entity.Property(e => e.Fecharef)
                .HasPrecision(0)
                .HasColumnName("fecharef");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("numero_asoc");
            entity.Property(e => e.Precio)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("PRECIO");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.TipoAsoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("tipo_asoc");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Valor)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("VALOR");
        });

        modelBuilder.Entity<Recibosprov>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RECIBOSPROV");

            entity.Property(e => e.Banco)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("BANCO");
            entity.Property(e => e.Causal)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("CAUSAL");
            entity.Property(e => e.Cheque)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("CHEQUE");
            entity.Property(e => e.Cliente)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Cuenta)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("CUENTA");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("FECHA_ASOC");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Valor)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("VALOR");
        });

        modelBuilder.Entity<Recordanula>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RECORDANULA");

            entity.Property(e => e.Bodega).HasColumnName("BODEGA");
            entity.Property(e => e.ExisA).HasColumnName("EXIS_A");
            entity.Property(e => e.ExisN).HasColumnName("EXIS_N");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Prod)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PROD");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<RentaCobro>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RENTA_COBRO");

            entity.Property(e => e.Banco)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("BANCO");
            entity.Property(e => e.Costof)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("COSTOF");
            entity.Property(e => e.Dif)
                .HasColumnType("decimal(17, 2)")
                .HasColumnName("DIF$");
            entity.Property(e => e.Equiv)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("EQUIV$");
            entity.Property(e => e.Fechab)
                .HasPrecision(0)
                .HasColumnName("FECHAB");
            entity.Property(e => e.Fechaf)
                .HasPrecision(0)
                .HasColumnName("FECHAF");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("MONTO$");
            entity.Property(e => e.Montobs)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("MONTOBS");
            entity.Property(e => e.NroRecibo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NRO_RECIBO");
            entity.Property(e => e.Numerof)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMEROF");
            entity.Property(e => e.Periodo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("PERIODO");
            entity.Property(e => e.TasaAct)
                .HasColumnType("numeric(11, 2)")
                .HasColumnName("TASA_ACT");
            entity.Property(e => e.Tasaf)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASAF");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<Reportevt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("REPORTEVT");

            entity.Property(e => e.Clase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CLASE");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Compañia)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("COMPAÑIA");
            entity.Property(e => e.Costo)
                .HasColumnType("numeric(38, 5)")
                .HasColumnName("COSTO");
            entity.Property(e => e.Costod)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("COSTOD");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Dia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DIA");
            entity.Property(e => e.Fecha).HasColumnName("FECHA");
            entity.Property(e => e.Flarga)
                .HasPrecision(0)
                .HasColumnName("FLARGA");
            entity.Property(e => e.Fncr)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("FNCR");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(16, 3)")
                .HasColumnName("MONTO");
            entity.Property(e => e.Montod)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("MONTOD");
            entity.Property(e => e.Montof)
                .HasColumnType("numeric(38, 5)")
                .HasColumnName("MONTOF");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Periodo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("PERIODO");
            entity.Property(e => e.Renta)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("RENTA");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASA");
            entity.Property(e => e.Tasar)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASAR");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.Utilidad)
                .HasColumnType("numeric(38, 5)")
                .HasColumnName("UTILIDAD");
            entity.Property(e => e.Vend)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VEND");
        });

        modelBuilder.Entity<Reportevt2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("REPORTEVT2");

            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Compañia)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("COMPAÑIA");
            entity.Property(e => e.Costo)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("COSTO");
            entity.Property(e => e.Costob)
                .HasColumnType("numeric(38, 5)")
                .HasColumnName("COSTOB");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Dia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DIA");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Flarga)
                .HasPrecision(0)
                .HasColumnName("FLARGA");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MARCA");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(38, 5)")
                .HasColumnName("MONTO");
            entity.Property(e => e.Montod)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("MONTOD");
            entity.Property(e => e.Montof)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("MONTOF");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Periodo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("PERIODO");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASA");
            entity.Property(e => e.Tasar)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASAR");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<Reportevtr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("REPORTEVTR");

            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Compañia)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("COMPAÑIA");
            entity.Property(e => e.Costo)
                .HasColumnType("numeric(38, 5)")
                .HasColumnName("COSTO");
            entity.Property(e => e.Costod)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("COSTOD");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Dia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DIA");
            entity.Property(e => e.Fecha).HasColumnName("FECHA");
            entity.Property(e => e.Fncr)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("FNCR");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(16, 3)")
                .HasColumnName("MONTO");
            entity.Property(e => e.Montod)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("MONTOD");
            entity.Property(e => e.Montof)
                .HasColumnType("numeric(38, 5)")
                .HasColumnName("MONTOF");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Periodo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("PERIODO");
            entity.Property(e => e.Renta)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("RENTA");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASA");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.Utilidadbs)
                .HasColumnType("numeric(38, 5)")
                .HasColumnName("UTILIDADBS");
            entity.Property(e => e.Vend)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VEND");
        });

        modelBuilder.Entity<Rev>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("rev");

            entity.Property(e => e.Serial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERIAL");
        });

        modelBuilder.Entity<Revcicpc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("REVCICPC");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Docasoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DOCASOC");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Numeroasoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMEROASOC");
            entity.Property(e => e.Serial)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SERIAL");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<Revision>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("REVISION");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Despacho)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("DESPACHO");
            entity.Property(e => e.Dev)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("DEV");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<Revision2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("REVISION2");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("FECHA_ASOC");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_ASOC");
            entity.Property(e => e.TipoAsoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_ASOC");
        });

        modelBuilder.Entity<Revision3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("REVISION3");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Despacho)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("DESPACHO");
            entity.Property(e => e.Dev)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("DEV");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Marca)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("MARCA");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODELO");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Ser)
                .HasColumnType("numeric(38, 0)")
                .HasColumnName("SER");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<Revseriale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("REVSERIALES");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Cliente)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Docasoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DOCASOC");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Fechaasoc)
                .HasPrecision(0)
                .HasColumnName("FECHAASOC");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Numeroasoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMEROASOC");
            entity.Property(e => e.Serial)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SERIAL");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<Sdirectv>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SDIRECTV");

            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.Cliente)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.FechaF)
                .HasPrecision(0)
                .HasColumnName("FECHA_F");
            entity.Property(e => e.NumeroDoc)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("NUMERO_DOC");
            entity.Property(e => e.Rif)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RIF");
            entity.Property(e => e.Serial)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SERIAL");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<Sellin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SELLIN");

            entity.Property(e => e.Año)
                .HasMaxLength(30)
                .HasColumnName("AÑO");
            entity.Property(e => e.Cost)
                .HasColumnType("numeric(38, 5)")
                .HasColumnName("COST");
            entity.Property(e => e.Grupo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MARCA");
            entity.Property(e => e.Mes)
                .HasMaxLength(30)
                .HasColumnName("MES");
            entity.Property(e => e.Mesn).HasColumnName("MESN");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODELO");
            entity.Property(e => e.Period)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("PERIOD");
            entity.Property(e => e.Qty)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("QTY");
        });

        modelBuilder.Entity<Ser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SER");

            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Serial)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SERIAL");
            entity.Property(e => e.Tipo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<Serial>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("serial");

            entity.Property(e => e.Ano)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANO");
            entity.Property(e => e.Anof)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANOF");
            entity.Property(e => e.Capcarga)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CAPCARGA");
            entity.Property(e => e.Clasei)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLASEI");
            entity.Property(e => e.Color1t)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COLOR1T");
            entity.Property(e => e.Combustible)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMBUSTIBLE");
            entity.Property(e => e.Ejesi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EJESI");
            entity.Property(e => e.Fcompra).HasColumnName("FCOMPRA");
            entity.Property(e => e.Fechacertificado).HasColumnName("FECHACERTIFICADO");
            entity.Property(e => e.Fechafin).HasColumnName("FECHAFIN");
            entity.Property(e => e.Ffactura).HasColumnName("FFACTURA");
            entity.Property(e => e.Fimpuestos).HasColumnName("FIMPUESTOS");
            entity.Property(e => e.Modeloi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODELOI");
            entity.Property(e => e.Nimpuestos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIMPUESTOS");
            entity.Property(e => e.NumCompra)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUM_COMPRA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Peso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PESO");
            entity.Property(e => e.Placa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLACA");
            entity.Property(e => e.Puertoentradac)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PUERTOENTRADAC");
            entity.Property(e => e.Puestos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PUESTOS");
            entity.Property(e => e.Refeciv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REFECIV");
            entity.Property(e => e.Rin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIN");
            entity.Property(e => e.Scarroceria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCARROCERIA");
            entity.Property(e => e.Schasis)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCHASIS");
            entity.Property(e => e.Serie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERIE");
            entity.Property(e => e.Servicio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERVICIO");
            entity.Property(e => e.Smotor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMOTOR");
            entity.Property(e => e.Sniv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SNIV");
            entity.Property(e => e.Tipoi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOI");
            entity.Property(e => e.Usoi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USOI");
        });

        modelBuilder.Entity<Seriale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SERIALES");

            entity.Property(e => e.Cliente)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("cliente");
            entity.Property(e => e.FechaFac)
                .HasPrecision(0)
                .HasColumnName("FECHA_FAC");
            entity.Property(e => e.NotaSerial)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NOTA_SERIAL");
            entity.Property(e => e.NumeroFac)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_FAC");
            entity.Property(e => e.Serial)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SERIAL");
            entity.Property(e => e.Tipo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<SerialesAuto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SERIALES_AUTO");

            entity.Property(e => e.Ano)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANO");
            entity.Property(e => e.Anof)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANOF");
            entity.Property(e => e.Capcarga)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CAPCARGA");
            entity.Property(e => e.Clasei)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLASEI");
            entity.Property(e => e.Color1t)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COLOR1T");
            entity.Property(e => e.Combustible)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMBUSTIBLE");
            entity.Property(e => e.Ejesi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EJESI");
            entity.Property(e => e.Expr1).HasColumnType("numeric(10, 0)");
            entity.Property(e => e.Fcompra).HasColumnName("FCOMPRA");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Fechacertificado).HasColumnName("FECHACERTIFICADO");
            entity.Property(e => e.Fechafin).HasColumnName("FECHAFIN");
            entity.Property(e => e.Ffactura).HasColumnName("FFACTURA");
            entity.Property(e => e.Fimpuestos).HasColumnName("FIMPUESTOS");
            entity.Property(e => e.Modeloi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODELOI");
            entity.Property(e => e.Nimpuestos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIMPUESTOS");
            entity.Property(e => e.NumCompra)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUM_COMPRA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Peso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PESO");
            entity.Property(e => e.Placa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLACA");
            entity.Property(e => e.Puertoentradac)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PUERTOENTRADAC");
            entity.Property(e => e.Puestos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PUESTOS");
            entity.Property(e => e.Refeciv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REFECIV");
            entity.Property(e => e.Rin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIN");
            entity.Property(e => e.Scarroceria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCARROCERIA");
            entity.Property(e => e.Schasis)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCHASIS");
            entity.Property(e => e.Serie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERIE");
            entity.Property(e => e.Servicio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERVICIO");
            entity.Property(e => e.Smotor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMOTOR");
            entity.Property(e => e.Sniv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SNIV");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Tipoi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOI");
            entity.Property(e => e.Usoi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USOI");
        });

        modelBuilder.Entity<Serialesvehiculo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SERIALESVEHICULOS");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.FCompra)
                .HasColumnType("datetime")
                .HasColumnName("F_COMPRA");
            entity.Property(e => e.Fimpuestos)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("FIMPUESTOS");
            entity.Property(e => e.Nimpuestos)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NIMPUESTOS");
            entity.Property(e => e.NumCompra).HasColumnName("NUM_COMPRA");
            entity.Property(e => e.Puertoentrada)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PUERTOENTRADA");
            entity.Property(e => e.Scarroceria)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("SCARROCERIA");
            entity.Property(e => e.Scarrozado)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("SCARROZADO");
            entity.Property(e => e.Schasis)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("SCHASIS");
            entity.Property(e => e.Smotor)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("SMOTOR");
            entity.Property(e => e.Sniv)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("SNIV");
        });

        modelBuilder.Entity<SmaBrakepad>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SMA_BRAKEPADS");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Menos1)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("MENOS1");
            entity.Property(e => e.Menos2)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("MENOS2");
            entity.Property(e => e.Menos3)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("MENOS3");
            entity.Property(e => e.Menos4)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("MENOS4");
            entity.Property(e => e.Menos5)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("MENOS5");
            entity.Property(e => e.Menos6)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("MENOS6");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODELO");
            entity.Property(e => e.Prom)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("PROM");
        });

        modelBuilder.Entity<StockGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("STOCK_GROUP");

            entity.Property(e => e.Brand)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BRAND");
            entity.Property(e => e.Grupo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Stock)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("STOCK");
            entity.Property(e => e.Tcif)
                .HasColumnType("numeric(38, 5)")
                .HasColumnName("TCIF");
            entity.Property(e => e.Tsale)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("TSALE");
        });

        modelBuilder.Entity<Stockvalue>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("STOCKVALUE");

            entity.Property(e => e.Brand)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BRAND");
            entity.Property(e => e.Stock)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("STOCK");
            entity.Property(e => e.Tcif)
                .HasColumnType("numeric(38, 5)")
                .HasColumnName("TCIF");
            entity.Property(e => e.Tsale)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("TSALE");
        });

        modelBuilder.Entity<Sucursal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SUCURSAL");

            entity.Property(e => e.Ciudad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Estado)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("ESTADO");
            entity.Property(e => e.Sucursal1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SUCURSAL");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
        });

        modelBuilder.Entity<Suli>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SULI");

            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Compañia)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("COMPAÑIA");
            entity.Property(e => e.Costo)
                .HasColumnType("numeric(38, 5)")
                .HasColumnName("COSTO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Dia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DIA");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Fncr)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("FNCR");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(16, 3)")
                .HasColumnName("MONTO");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Periodo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("PERIODO");
            entity.Property(e => e.Renta)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("RENTA");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASA");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.Utilidad)
                .HasColumnType("numeric(38, 5)")
                .HasColumnName("UTILIDAD");
            entity.Property(e => e.Vend)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VEND");
        });

        modelBuilder.Entity<Svehiculo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SVEHICULOS");

            entity.Property(e => e.Anof)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANOF");
            entity.Property(e => e.Anom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANOM");
            entity.Property(e => e.Articulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Asiento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ASIENTO");
            entity.Property(e => e.Bodega).HasColumnName("BODEGA");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COLOR");
            entity.Property(e => e.Eje)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EJE");
            entity.Property(e => e.FCompra)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("F_COMPRA");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("FECHA_ASOC");
            entity.Property(e => e.Fechafin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHAFIN");
            entity.Property(e => e.Fimpuestos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIMPUESTOS");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODELO");
            entity.Property(e => e.Nimpuestos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIMPUESTOS");
            entity.Property(e => e.NumCompra)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUM_COMPRA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_ASOC");
            entity.Property(e => e.Peso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PESO");
            entity.Property(e => e.Pesob)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PESOB");
            entity.Property(e => e.Puertoentrada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PUERTOENTRADA");
            entity.Property(e => e.Puertoentradac)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PUERTOENTRADAC");
            entity.Property(e => e.Refeciv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REFECIV");
            entity.Property(e => e.Rin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIN");
            entity.Property(e => e.Scarroceria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCARROCERIA");
            entity.Property(e => e.Scarrozado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCARROZADO");
            entity.Property(e => e.Schasis)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCHASIS");
            entity.Property(e => e.Smotor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMOTOR");
            entity.Property(e => e.Sniv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SNIV");
            entity.Property(e => e.TipoAsoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_ASOC");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<Ti>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TI");

            entity.Property(e => e.Cant).HasColumnName("CANT");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<Tpcliente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TPCLIENTES");

            entity.Property(e => e.Clase)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CodAlte)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CodClie)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.CodConv)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CodSucu)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CodVend)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodZona)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DescOrder)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Descrip)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Descto).HasColumnType("numeric(4, 4)");
            entity.Property(e => e.Direc1)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Direc2)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.FechaE)
                .HasMaxLength(23)
                .IsUnicode(false);
            entity.Property(e => e.FechaUp).HasColumnName("FechaUP");
            entity.Property(e => e.FechaUv).HasColumnName("FechaUV");
            entity.Property(e => e.Id3)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID3");
            entity.Property(e => e.LimiteCred).HasColumnType("numeric(14, 4)");
            entity.Property(e => e.MontoMax).HasColumnType("numeric(4, 4)");
            entity.Property(e => e.MontoUp)
                .HasColumnType("numeric(4, 4)")
                .HasColumnName("MontoUP");
            entity.Property(e => e.MontoUv)
                .HasColumnType("numeric(4, 4)")
                .HasColumnName("MontoUV");
            entity.Property(e => e.MtoMaxCred).HasColumnType("numeric(4, 4)");
            entity.Property(e => e.Nit).HasColumnName("NIT");
            entity.Property(e => e.NumeroUp).HasColumnName("NumeroUP");
            entity.Property(e => e.NumeroUv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("NumeroUV");
            entity.Property(e => e.Observa)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PagosA).HasColumnType("numeric(4, 4)");
            entity.Property(e => e.PromPago).HasColumnType("numeric(4, 4)");
            entity.Property(e => e.Represent)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.RetenIva)
                .HasColumnType("numeric(4, 4)")
                .HasColumnName("RetenIVA");
            entity.Property(e => e.Saldo).HasColumnType("numeric(4, 4)");
            entity.Property(e => e.SaldoPtos).HasColumnType("numeric(4, 4)");
            entity.Property(e => e.TipoId).HasColumnName("TipoID");
            entity.Property(e => e.TipoId3).HasColumnName("TipoID3");
            entity.Property(e => e.TipoPvp).HasColumnName("TipoPVP");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tpcopium>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TPCOPIA");

            entity.Property(e => e.Numero)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("NUMERO");
        });

        modelBuilder.Entity<Tpdepo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TPDEPO");

            entity.Property(e => e.CodProd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodUbic)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Existen).HasColumnType("numeric(30, 2)");
        });

        modelBuilder.Entity<Tpdepor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TPDEPOR");

            entity.Property(e => e.CodProd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodUbic)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Existen).HasColumnType("numeric(38, 2)");
        });

        modelBuilder.Entity<TplinkCChannel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TPLINK_C_CHANNEL");

            entity.Property(e => e.Channel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CHANNEL");
            entity.Property(e => e.Customer)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.Month)
                .HasMaxLength(30)
                .HasColumnName("MONTH");
            entity.Property(e => e.Qty)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("QTY");
            entity.Property(e => e.Year).HasColumnName("YEAR");
        });

        modelBuilder.Entity<TplinkCGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TPLINK_C_GROUP");

            entity.Property(e => e.Category)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.Customer)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.Month)
                .HasMaxLength(30)
                .HasColumnName("MONTH");
            entity.Property(e => e.Qty)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("QTY");
            entity.Property(e => e.Year).HasColumnName("YEAR");
        });

        modelBuilder.Entity<TplinkSaleGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TPLINK_SALE_GROUP");

            entity.Property(e => e.Grupo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Month)
                .HasMaxLength(30)
                .HasColumnName("MONTH");
            entity.Property(e => e.Qty)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("QTY");
            entity.Property(e => e.Year).HasColumnName("YEAR");
        });

        modelBuilder.Entity<Tplinkchannel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TPLINKCHANNEL");

            entity.Property(e => e.Channel)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CHANNEL");
            entity.Property(e => e.Month)
                .HasMaxLength(30)
                .HasColumnName("MONTH");
            entity.Property(e => e.Qty)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("QTY");
            entity.Property(e => e.Year).HasColumnName("YEAR");
        });

        modelBuilder.Entity<Tplinkg>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TPLINKG");

            entity.Property(e => e.Account)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.Category)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.Channel)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CHANNEL");
            entity.Property(e => e.City)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.Customer)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER");
            entity.Property(e => e.CustomerCountry)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_COUNTRY");
            entity.Property(e => e.Date).HasColumnName("DATE");
            entity.Property(e => e.Estate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESTATE");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODEL");
            entity.Property(e => e.Month)
                .HasMaxLength(30)
                .HasColumnName("MONTH");
            entity.Property(e => e.Month1).HasColumnName("#MONTH");
            entity.Property(e => e.Mqcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MQCODE");
            entity.Property(e => e.Nmaster)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("NMASTER");
            entity.Property(e => e.Price)
                .HasColumnType("numeric(28, 14)")
                .HasColumnName("PRICE");
            entity.Property(e => e.Q)
                .HasMaxLength(31)
                .IsUnicode(false);
            entity.Property(e => e.Qty)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("QTY");
            entity.Property(e => e.Region)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Rif)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RIF");
            entity.Property(e => e.SalesPerson)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SALES_PERSON");
            entity.Property(e => e.TotalValue)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("TOTAL_VALUE");
            entity.Property(e => e.Year).HasColumnName("YEAR");
        });

        modelBuilder.Entity<Tplinkgroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TPLINKGROUP");

            entity.Property(e => e.Grupo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Month)
                .HasMaxLength(30)
                .HasColumnName("MONTH");
            entity.Property(e => e.Qty)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("QTY");
            entity.Property(e => e.Year).HasColumnName("YEAR");
        });

        modelBuilder.Entity<Tplinkproduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TPLINKPRODUCT");

            entity.Property(e => e.Grupo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODELO");
            entity.Property(e => e.Month)
                .HasMaxLength(30)
                .HasColumnName("MONTH");
            entity.Property(e => e.Qty)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("QTY");
            entity.Property(e => e.Year).HasColumnName("YEAR");
        });

        modelBuilder.Entity<Tpprod>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TPPROD");

            entity.Property(e => e.Codprod)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CostAct).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.CostAnt).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.Costprod).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.DesComi).HasColumnName("DEsComi");
            entity.Property(e => e.DesComp).HasColumnName("DEsComp");
            entity.Property(e => e.DesVence).HasColumnName("DEsVence");
            entity.Property(e => e.Descrip)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Precio1).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.Precio2).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.Precio3).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.PrecioU).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.PrecioU2).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.PrecioU3).HasColumnType("numeric(12, 3)");
        });

        modelBuilder.Entity<Tpproducto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TPPRODUCTOS");

            entity.Property(e => e.CantEmpaq).HasColumnType("numeric(2, 2)");
            entity.Property(e => e.CodProd)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.CostAct).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.CostAnt).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.CostPro).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.Costant2).HasColumnName("COSTANT2");
            entity.Property(e => e.DesComi).HasColumnName("DEsComi");
            entity.Property(e => e.DesComp).HasColumnName("DEsComp");
            entity.Property(e => e.DesLote).HasColumnName("DEsLote");
            entity.Property(e => e.DesSeri).HasColumnName("DEsSeri");
            entity.Property(e => e.DesVence).HasColumnName("DEsVence");
            entity.Property(e => e.Descrip)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Descrip2)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Descrip3)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Descuento)
                .HasColumnType("numeric(5, 2)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.FechaUc).HasColumnName("FechaUC");
            entity.Property(e => e.FechaUv).HasColumnName("FechaUV");
            entity.Property(e => e.Marca)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Precio1).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.Precio2).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.Precio3).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.PrecioU).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.PrecioU2).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.PrecioU3).HasColumnType("numeric(12, 3)");
            entity.Property(e => e.Refere)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UndEmpaq)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Unidad)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tpreserva>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TPRESERVA");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Bodega)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BODEGA");
            entity.Property(e => e.Cant)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("CANT");
        });

        modelBuilder.Entity<Tptasa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TPTASA");

            entity.Property(e => e.Cambio)
                .HasColumnType("numeric(11, 2)")
                .HasColumnName("CAMBIO");
        });

        modelBuilder.Entity<Tptotal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TPTOTAL");

            entity.Property(e => e.CodProd)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Total)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<Txt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("txt");

            entity.Property(e => e.Ano)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANO");
            entity.Property(e => e.Capcarga)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CAPCARGA");
            entity.Property(e => e.Claset)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLASET");
            entity.Property(e => e.Color1t)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COLOR1T");
            entity.Property(e => e.Combustible)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMBUSTIBLE");
            entity.Property(e => e.Ejesi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EJESI");
            entity.Property(e => e.Expr1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fcompra)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FCOMPRA");
            entity.Property(e => e.Fechacertificado)
                .HasPrecision(0)
                .HasColumnName("FECHACERTIFICADO");
            entity.Property(e => e.Fechafin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FECHAFIN");
            entity.Property(e => e.Ffactura)
                .HasPrecision(0)
                .HasColumnName("FFACTURA");
            entity.Property(e => e.Fimpuestos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIMPUESTOS");
            entity.Property(e => e.Modeloi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODELOI");
            entity.Property(e => e.Nimpuestos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NIMPUESTOS");
            entity.Property(e => e.NumCompra)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUM_COMPRA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.NºCertificado)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Nº_CERTIFICADO");
            entity.Property(e => e.Peso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PESO");
            entity.Property(e => e.Placa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLACA");
            entity.Property(e => e.Puertoentradac)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PUERTOENTRADAC");
            entity.Property(e => e.Puestos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PUESTOS");
            entity.Property(e => e.Refeciv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REFECIV");
            entity.Property(e => e.Rin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIN");
            entity.Property(e => e.Scarroceria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCARROCERIA");
            entity.Property(e => e.Schasis)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SCHASIS");
            entity.Property(e => e.Serie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERIE");
            entity.Property(e => e.Servicio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERVICIO");
            entity.Property(e => e.Smotor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMOTOR");
            entity.Property(e => e.Sniv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SNIV");
            entity.Property(e => e.Tipot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPOT");
            entity.Property(e => e.Usot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USOT");
        });

        modelBuilder.Entity<Ubi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("UBI");

            entity.Property(e => e.Articulo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Ubi1).HasColumnName("UBI");
        });

        modelBuilder.Entity<Uiproperty>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UIProperties");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<UltDespacho>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ULT_DESPACHOS");

            entity.Property(e => e.Nrounico)
                .ValueGeneratedOnAdd()
                .HasColumnName("NROUNICO");
        });

        modelBuilder.Entity<UltDespachosmov>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ULT_DESPACHOSMOV");

            entity.Property(e => e.Nrounico)
                .ValueGeneratedOnAdd()
                .HasColumnName("NROUNICO");
        });

        modelBuilder.Entity<UltLogistica>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ULT_LOGISTICA");

            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
        });

        modelBuilder.Entity<UltLogisticamov>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ULT_LOGISTICAMOV");

            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
        });

        modelBuilder.Entity<UltLogisticaseriale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ULT_LOGISTICASERIALES");

            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
        });

        modelBuilder.Entity<UltZfacturasmovdep>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ULT_ZFACTURASMOVDEP");

            entity.Property(e => e.Nrounico).HasColumnName("NROUNICO");
        });

        modelBuilder.Entity<UltZohodespacho>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ULT_ZOHODESPACHO");

            entity.Property(e => e.Nrounico).HasColumnName("NROUNICO");
        });

        modelBuilder.Entity<Usuariosfi>(entity =>
        {
            entity.HasKey(e => e.Cliente);

            entity.ToTable("USUARIOSFI");

            entity.Property(e => e.Cliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Pass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASS");
            entity.Property(e => e.Rol)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ROL");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<Usuariospermiso>(entity =>
        {
            entity.HasKey(e => new { e.Usuario, e.Programa }).HasName("USUARIOSPERMISOS_PK");

            entity.ToTable("USUARIOSPERMISOS", tb => tb.HasTrigger("USUARIOSPERMISOSP"));

            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
            entity.Property(e => e.Programa)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("PROGRAMA");

            entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.Usuariospermisos)
                .HasForeignKey(d => d.Usuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("USUARIOSPERMISOS_FK1");
        });

        modelBuilder.Entity<VBuiltinfunction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_builtinfunctions", "ssma_oracle");

            entity.Property(e => e.Gmttime)
                .HasColumnType("datetime")
                .HasColumnName("GMTTime");
            entity.Property(e => e.LocalTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<VDbmsSqlBindVariable>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_dbms_sql_bind_variable", "ssma_oracle");

            entity.Property(e => e.BValue).HasColumnName("b_value");
            entity.Property(e => e.CValue)
                .IsUnicode(false)
                .HasColumnName("c_value");
            entity.Property(e => e.CursorId).HasColumnName("cursor_id");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("_name");
            entity.Property(e => e.NcValue).HasColumnName("nc_value");
            entity.Property(e => e.Type).HasColumnName("_type");
            entity.Property(e => e.VValue)
                .HasColumnType("sql_variant")
                .HasColumnName("v_value");
        });

        modelBuilder.Entity<VDbmsSqlCursor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_dbms_sql_cursor", "ssma_oracle");

            entity.Property(e => e.CurrentRow).HasColumnName("current_row");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.LastRow).HasColumnName("last_row");
            entity.Property(e => e.LoginTime)
                .HasColumnType("datetime")
                .HasColumnName("login_time");
            entity.Property(e => e.Spid).HasColumnName("spid");
            entity.Property(e => e.Statement).HasColumnName("statement");
        });

        modelBuilder.Entity<VDbmsSqlDefineColumn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_dbms_sql_define_column", "ssma_oracle");

            entity.Property(e => e.CursorId).HasColumnName("cursor_id");
            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.Type).HasColumnName("_type");
        });

        modelBuilder.Entity<VDbmsSqlRecordset>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_dbms_sql_recordset", "ssma_oracle");

            entity.Property(e => e.BValue).HasColumnName("b_value");
            entity.Property(e => e.CValue)
                .IsUnicode(false)
                .HasColumnName("c_value");
            entity.Property(e => e.CursorId).HasColumnName("cursor_id");
            entity.Property(e => e.Key).HasColumnName("_key");
            entity.Property(e => e.NcValue).HasColumnName("nc_value");
            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.VValue)
                .HasColumnType("sql_variant")
                .HasColumnName("v_value");
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VEHICULOS");

            entity.Property(e => e.Ano)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("ANO");
            entity.Property(e => e.Capacidad)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("CAPACIDAD");
            entity.Property(e => e.Carroceria)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CARROCERIA");
            entity.Property(e => e.Clase)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CLASE");
            entity.Property(e => e.Color)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("COLOR");
            entity.Property(e => e.Conductor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CONDUCTOR");
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasColumnName("FECHA_REGISTRO");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MARCA");
            entity.Property(e => e.Modelo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MODELO");
            entity.Property(e => e.Motor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MOTOR");
            entity.Property(e => e.NumeroRegistro)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("NUMERO_REGISTRO");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PLACA");
            entity.Property(e => e.Propietario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PROPIETARIO");
            entity.Property(e => e.Tipo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.Uso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USO");
        });

        modelBuilder.Entity<Vencida>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VENCIDAS");

            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CELULAR");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Estado)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Link)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("LINK");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Tipon)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TIPON");
        });

        modelBuilder.Entity<Vencimiento>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VENCIMIENTO");

            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CELULAR");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Estado)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Link)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("LINK");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Plazo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("PLAZO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Tipon)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("TIPON");
        });

        modelBuilder.Entity<VentaDirectv>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VENTA_DIRECTV");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Compañia)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("COMPAÑIA");
            entity.Property(e => e.Costo)
                .HasColumnType("numeric(28, 5)")
                .HasColumnName("COSTO");
            entity.Property(e => e.Costod)
                .HasColumnType("numeric(28, 5)")
                .HasColumnName("COSTOD");
            entity.Property(e => e.Dia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DIA");
            entity.Property(e => e.Fecha).HasColumnName("FECHA");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MARCA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Periodo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("PERIODO");
            entity.Property(e => e.Producto)
                .IsUnicode(false)
                .HasColumnName("PRODUCTO");
            entity.Property(e => e.Qty)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("QTY");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASA");
            entity.Property(e => e.Tasaf)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASAF");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VENDEDOR");
            entity.Property(e => e.Venta)
                .HasColumnType("numeric(28, 5)")
                .HasColumnName("VENTA");
            entity.Property(e => e.Ventad)
                .HasColumnType("numeric(28, 5)")
                .HasColumnName("VENTAD");
        });

        modelBuilder.Entity<Ventamarca>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VENTAMARCA");

            entity.Property(e => e.Bodega)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BODEGA");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Comentario)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.Compañia)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("COMPAÑIA");
            entity.Property(e => e.Costo)
                .HasColumnType("numeric(28, 5)")
                .HasColumnName("COSTO");
            entity.Property(e => e.Costod)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("COSTOD");
            entity.Property(e => e.Dia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DIA");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Fecha).HasColumnName("FECHA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MARCA");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODELO");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Periodo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("PERIODO");
            entity.Property(e => e.Preciol)
                .HasColumnType("numeric(28, 14)")
                .HasColumnName("PRECIOL");
            entity.Property(e => e.Preciolt)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("PRECIOLT");
            entity.Property(e => e.Producto)
                .IsUnicode(false)
                .HasColumnName("PRODUCTO");
            entity.Property(e => e.Qty)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("QTY");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASA");
            entity.Property(e => e.Tasaf)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASAF");
            entity.Property(e => e.Tasar)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASAR");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VENDEDOR");
            entity.Property(e => e.Venta)
                .HasColumnType("numeric(28, 5)")
                .HasColumnName("VENTA");
            entity.Property(e => e.Ventad)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("VENTAD");
        });

        modelBuilder.Entity<Ventamarcas2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VENTAMARCAS2");

            entity.Property(e => e.Bodega)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BODEGA");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Compañia)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("COMPAÑIA");
            entity.Property(e => e.Costo)
                .HasColumnType("numeric(28, 5)")
                .HasColumnName("COSTO");
            entity.Property(e => e.Costod)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("COSTOD");
            entity.Property(e => e.Dia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DIA");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Fecha).HasColumnName("FECHA");
            entity.Property(e => e.Flarga)
                .HasPrecision(0)
                .HasColumnName("FLARGA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MARCA");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODELO");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Periodo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("PERIODO");
            entity.Property(e => e.Placa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLACA");
            entity.Property(e => e.Preciol)
                .HasColumnType("numeric(28, 14)")
                .HasColumnName("PRECIOL");
            entity.Property(e => e.Preciolt)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("PRECIOLT");
            entity.Property(e => e.Producto)
                .IsUnicode(false)
                .HasColumnName("PRODUCTO");
            entity.Property(e => e.Qty)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("QTY");
            entity.Property(e => e.Sede)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SEDE");
            entity.Property(e => e.SerialVin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERIAL VIN");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASA");
            entity.Property(e => e.Tasaf)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASAF");
            entity.Property(e => e.Tasar)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASAR");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Transporte)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("TRANSPORTE");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VENDEDOR");
            entity.Property(e => e.Venta)
                .HasColumnType("numeric(28, 5)")
                .HasColumnName("VENTA");
            entity.Property(e => e.Ventad)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("VENTAD");
        });

        modelBuilder.Entity<Ventasmasrcas2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VENTASMASRCAS2");

            entity.Property(e => e.Bodega)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BODEGA");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Compañia)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("COMPAÑIA");
            entity.Property(e => e.Costo)
                .HasColumnType("numeric(28, 5)")
                .HasColumnName("COSTO");
            entity.Property(e => e.Costod)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("COSTOD");
            entity.Property(e => e.Dia)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DIA");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Fecha).HasColumnName("FECHA");
            entity.Property(e => e.Grupo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MARCA");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODELO");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Periodo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("PERIODO");
            entity.Property(e => e.Preciol)
                .HasColumnType("numeric(28, 14)")
                .HasColumnName("PRECIOL");
            entity.Property(e => e.Preciolt)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("PRECIOLT");
            entity.Property(e => e.Producto)
                .IsUnicode(false)
                .HasColumnName("PRODUCTO");
            entity.Property(e => e.Qty)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("QTY");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASA");
            entity.Property(e => e.Tasaf)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASAF");
            entity.Property(e => e.Tasar)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("TASAR");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VENDEDOR");
            entity.Property(e => e.Venta)
                .HasColumnType("numeric(28, 5)")
                .HasColumnName("VENTA");
            entity.Property(e => e.Ventad)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("VENTAD");
        });

        modelBuilder.Entity<View1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_1");

            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Saldo)
                .HasMaxLength(99)
                .IsUnicode(false)
                .HasColumnName("SALDO");
        });

        modelBuilder.Entity<Wcartera>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wcartera");

            entity.Property(e => e.A2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("a2");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("ciudad");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cliente");
            entity.Property(e => e.Comentario)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.Contacto)
                .HasMaxLength(85)
                .IsUnicode(false)
                .HasColumnName("contacto");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("fecha");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("fecha_asoc");
            entity.Property(e => e.FechaLog)
                .HasPrecision(0)
                .HasColumnName("fecha_log");
            entity.Property(e => e.Interes)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("interes");
            entity.Property(e => e.Iva)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("iva");
            entity.Property(e => e.N2)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("n2");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("numero");
            entity.Property(e => e.NumeroAsoc1)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("numero_Asoc");
            entity.Property(e => e.NumeroLog)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("numero_log");
            entity.Property(e => e.Numeroasoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("numeroasoc");
            entity.Property(e => e.Plazo)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("plazo");
            entity.Property(e => e.R2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("r2");
            entity.Property(e => e.Recibo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("recibo");
            entity.Property(e => e.Retencion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("retencion");
            entity.Property(e => e.Saldo)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("saldo");
            entity.Property(e => e.Sede)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sede");
            entity.Property(e => e.Tasa)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("tasa");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.TipoAsoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("tipo_asoc");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("tipo_doc");
            entity.Property(e => e.TipoLog)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("tipo_log");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("total");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("vendedor");
        });

        modelBuilder.Entity<Wholesaler>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WHOLESALERS");

            entity.Property(e => e.Año).HasColumnName("AÑO");
            entity.Property(e => e.Cliente)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Costos)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("COSTOS");
            entity.Property(e => e.Doc)
                .HasMaxLength(61)
                .IsUnicode(false)
                .HasColumnName("DOC");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MARCA");
            entity.Property(e => e.Mes)
                .HasMaxLength(30)
                .HasColumnName("MES");
            entity.Property(e => e.Montos)
                .HasColumnType("numeric(38, 13)")
                .HasColumnName("MONTOS");
            entity.Property(e => e.Rif)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RIF");
        });

        modelBuilder.Entity<Zactdespacho>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ZACTDESPACHO");

            entity.Property(e => e.Articulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ARTICULO");
            entity.Property(e => e.Despacho).HasColumnName("DESPACHO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Numero).HasColumnName("NUMERO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<Zliberada>(entity =>
        {
            entity.HasKey(e => new { e.Numero, e.Fecha, e.TipoDoc });

            entity.ToTable("ZLIBERADAS");

            entity.Property(e => e.Numero).HasColumnName("NUMERO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.Ejecutado)
                .HasDefaultValue(0)
                .HasColumnName("EJECUTADO");
            entity.Property(e => e.FechaLog)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_LOG");
            entity.Property(e => e.NumeroLog).HasColumnName("NUMERO_LOG");
            entity.Property(e => e.TipoLog)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_LOG");
        });

        modelBuilder.Entity<ZohoArticulo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ZOHO_ARTICULOS");

            entity.Property(e => e.Cif)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("CIF");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Descuento)
                .HasColumnType("numeric(5, 2)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.Existencia)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("EXISTENCIA");
            entity.Property(e => e.Fechaactual)
                .HasPrecision(0)
                .HasColumnName("FECHAACTUAL");
            entity.Property(e => e.Fechacif)
                .HasPrecision(0)
                .HasColumnName("FECHACIF");
            entity.Property(e => e.Garantia)
                .HasColumnType("numeric(7, 2)")
                .HasColumnName("GARANTIA");
            entity.Property(e => e.Iva)
                .HasColumnType("numeric(4, 2)")
                .HasColumnName("IVA");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MARCA");
            entity.Property(e => e.Unidad)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
            entity.Property(e => e.Venta)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("VENTA");
        });

        modelBuilder.Entity<ZohoCartera>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ZOHO_CARTERA");

            entity.Property(e => e.Nota1)
                .HasMaxLength(83)
                .IsUnicode(false)
                .HasColumnName("NOTA_1");
            entity.Property(e => e.Nota10)
                .HasMaxLength(83)
                .IsUnicode(false)
                .HasColumnName("NOTA_10");
            entity.Property(e => e.Nota11)
                .HasMaxLength(83)
                .IsUnicode(false)
                .HasColumnName("NOTA_11");
            entity.Property(e => e.Nota12)
                .HasMaxLength(83)
                .IsUnicode(false)
                .HasColumnName("NOTA_12");
            entity.Property(e => e.Nota13)
                .HasMaxLength(83)
                .IsUnicode(false)
                .HasColumnName("NOTA_13");
            entity.Property(e => e.Nota14)
                .HasMaxLength(83)
                .IsUnicode(false)
                .HasColumnName("NOTA_14");
            entity.Property(e => e.Nota15)
                .HasMaxLength(83)
                .IsUnicode(false)
                .HasColumnName("NOTA_15");
            entity.Property(e => e.Nota2)
                .HasMaxLength(83)
                .IsUnicode(false)
                .HasColumnName("NOTA_2");
            entity.Property(e => e.Nota3)
                .HasMaxLength(83)
                .IsUnicode(false)
                .HasColumnName("NOTA_3");
            entity.Property(e => e.Nota4)
                .HasMaxLength(83)
                .IsUnicode(false)
                .HasColumnName("NOTA_4");
            entity.Property(e => e.Nota5)
                .HasMaxLength(83)
                .IsUnicode(false)
                .HasColumnName("NOTA_5");
            entity.Property(e => e.Nota6)
                .HasMaxLength(83)
                .IsUnicode(false)
                .HasColumnName("NOTA_6");
            entity.Property(e => e.Nota7)
                .HasMaxLength(83)
                .IsUnicode(false)
                .HasColumnName("NOTA_7");
            entity.Property(e => e.Nota8)
                .HasMaxLength(83)
                .IsUnicode(false)
                .HasColumnName("NOTA_8");
            entity.Property(e => e.Nota9)
                .HasMaxLength(83)
                .IsUnicode(false)
                .HasColumnName("NOTA_9");
            entity.Property(e => e.Rif)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIF");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<ZohoCliente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ZOHO_CLIENTE");

            entity.Property(e => e.Celular)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("CELULAR");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.ContactoPrincipal)
                .HasMaxLength(85)
                .IsUnicode(false)
                .HasColumnName("CONTACTO_PRINCIPAL");
            entity.Property(e => e.Correo)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            entity.Property(e => e.DirEnvio)
                .IsUnicode(false)
                .HasColumnName("DIR_ENVIO");
            entity.Property(e => e.DireccionFact)
                .IsUnicode(false)
                .HasColumnName("DIRECCION_FACT");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Fecha1)
                .HasColumnType("datetime")
                .HasColumnName("FECHA1");
            entity.Property(e => e.Fecha2)
                .HasColumnType("datetime")
                .HasColumnName("FECHA2");
            entity.Property(e => e.Fecha3)
                .HasColumnType("datetime")
                .HasColumnName("FECHA3");
            entity.Property(e => e.NombreDeCuenta)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_DE_CUENTA");
            entity.Property(e => e.Nota1)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOTA_1");
            entity.Property(e => e.Nota10)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOTA_10");
            entity.Property(e => e.Nota11)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOTA_11");
            entity.Property(e => e.Nota12)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOTA_12");
            entity.Property(e => e.Nota13)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOTA_13");
            entity.Property(e => e.Nota14)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOTA_14");
            entity.Property(e => e.Nota15)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOTA_15");
            entity.Property(e => e.Nota2)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOTA_2");
            entity.Property(e => e.Nota3)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOTA_3");
            entity.Property(e => e.Nota4)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOTA_4");
            entity.Property(e => e.Nota5)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOTA_5");
            entity.Property(e => e.Nota6)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOTA_6");
            entity.Property(e => e.Nota7)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOTA_7");
            entity.Property(e => e.Nota8)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOTA_8");
            entity.Property(e => e.Nota9)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NOTA_9");
            entity.Property(e => e.NumeroDeCuenta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUMERO_DE_CUENTA");
            entity.Property(e => e.PropietarioDeCuenta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PROPIETARIO_DE_CUENTA");
            entity.Property(e => e.RifCodigo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RIF_CODIGO");
            entity.Property(e => e.Sector)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SECTOR");
            entity.Property(e => e.Sitio)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("SITIO");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<ZohoContacto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ZOHO_CONTACTOS");

            entity.Property(e => e.Ciudad)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.Correo)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            entity.Property(e => e.CorreoSecundario)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CORREO_SECUNDARIO");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(85)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.NombreCuenta)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_CUENTA");
            entity.Property(e => e.PropietarioDeContacto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PROPIETARIO_DE_CONTACTO");
            entity.Property(e => e.RifCodigo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RIF_CODIGO");
            entity.Property(e => e.TelefonoCelular)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO_CELULAR");
        });

        modelBuilder.Entity<ZohoDespacho>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ZOHO_DESPACHO", tb => tb.HasTrigger("NOTIFICA_DESPACHO"));

            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaAsoc)
                .HasPrecision(0)
                .HasColumnName("FECHA_ASOC");
            entity.Property(e => e.Nrounico).HasColumnName("NROUNICO");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.NumeroAsoc)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO_ASOC");
            entity.Property(e => e.TipoAsoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_ASOC");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<ZohoDeudum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ZOHO_DEUDA");

            entity.Property(e => e.Actualizado)
                .HasColumnType("datetime")
                .HasColumnName("ACTUALIZADO");
            entity.Property(e => e.Completo)
                .IsUnicode(false)
                .HasColumnName("COMPLETO");
            entity.Property(e => e.N1)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.N10)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.N11)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.N12)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.N13)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.N14)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.N15)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.N2)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.N3)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.N4)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.N5)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.N6)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.N7)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.N8)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.N9)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Rif)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RIF");
        });

        modelBuilder.Entity<ZohoEdodet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ZOHO_EDODET");

            entity.Property(e => e.Cadena)
                .HasMaxLength(356)
                .IsUnicode(false)
                .HasColumnName("CADENA");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<ZohoEstadoCuentum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ZOHO_ESTADO_CUENTA");

            entity.Property(e => e.Ciudad)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Comentario)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaLog)
                .HasPrecision(0)
                .HasColumnName("FECHA_LOG");
            entity.Property(e => e.FechaVenc)
                .HasPrecision(0)
                .HasColumnName("FECHA_VENC");
            entity.Property(e => e.Iva)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("IVA");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("MONTO");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Plazo)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("PLAZO");
            entity.Property(e => e.ReciboNro)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("Recibo_NRO");
            entity.Property(e => e.ReciboRet)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("Recibo_Ret");
            entity.Property(e => e.Recolecta)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("RECOLECTA");
            entity.Property(e => e.Retencion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("RETENCION");
            entity.Property(e => e.Saldo)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("saldo$");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.TipoLog)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_LOG");
            entity.Property(e => e.Token)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TOKEN");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<ZohoEstadocuenta>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ZOHO_ESTADOCUENTAS");

            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.DetalleSaldo).HasColumnName("DETALLE_SALDO");
        });

        modelBuilder.Entity<ZohoEvento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ZOHO_EVENTOS");

            entity.Property(e => e.Contenido)
                .IsUnicode(false)
                .HasColumnName("CONTENIDO");
            entity.Property(e => e.Correo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            entity.Property(e => e.Estatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESTATUS");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Nro)
                .ValueGeneratedOnAdd()
                .HasColumnName("NRO");
            entity.Property(e => e.Propietario)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PROPIETARIO");
        });

        modelBuilder.Entity<ZohoFact>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ZOHO_FACT");

            entity.Property(e => e.Cliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Despacho)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DESPACHO");
            entity.Property(e => e.DetalleFac).HasColumnName("DETALLE_FAC");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Estatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESTATUS");
            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaDesp)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DESP");
            entity.Property(e => e.FechaVenc)
                .HasPrecision(0)
                .HasColumnName("FECHA_VENC");
            entity.Property(e => e.Link)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LINK");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.Plazo)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("PLAZO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
            entity.Property(e => e.TotaIva)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TOTA_IVA");
            entity.Property(e => e.Usuario)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<ZohoItemfac>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ZOHO_ITEMFAC");

            entity.Property(e => e.Fecha)
                .HasPrecision(0)
                .HasColumnName("FECHA");
            entity.Property(e => e.Items)
                .HasMaxLength(122)
                .IsUnicode(false)
                .HasColumnName("ITEMS");
            entity.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOC");
        });

        modelBuilder.Entity<ZohoNotificacion>(entity =>
        {
            entity.HasKey(e => e.Nrounico).HasName("PK_NOTIFICACION");

            entity.ToTable("ZOHO_NOTIFICACION", tb => tb.HasTrigger("LINK"));

            entity.Property(e => e.Nrounico).HasColumnName("NROUNICO");
            entity.Property(e => e.Celular)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CELULAR");
            entity.Property(e => e.Cliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("PENDIENTE")
                .HasColumnName("ESTADO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Link)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LINK");
            entity.Property(e => e.Numero)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("NUMERO");
            entity.Property(e => e.PorVencer)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("POR_VENCER");
            entity.Property(e => e.SaldoFavor)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("SALDO_FAVOR");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPO");
            entity.Property(e => e.Tipon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIPON");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TOTAL");
            entity.Property(e => e.Vencido)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VENCIDO");
        });

        modelBuilder.Entity<ZohoNotificacione>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ZOHO_NOTIFICACIONES");

            entity.Property(e => e.Celular)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("CELULAR");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.ContactoPrincipal)
                .HasMaxLength(85)
                .IsUnicode(false)
                .HasColumnName("CONTACTO_PRINCIPAL");
            entity.Property(e => e.Correo)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            entity.Property(e => e.DirEnvio)
                .IsUnicode(false)
                .HasColumnName("DIR_ENVIO");
            entity.Property(e => e.DireccionFact)
                .IsUnicode(false)
                .HasColumnName("DIRECCION_FACT");
            entity.Property(e => e.EnlaceLink)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ENLACE_LINK");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Fecha1)
                .HasColumnType("datetime")
                .HasColumnName("FECHA1");
            entity.Property(e => e.Fecha2)
                .HasColumnType("datetime")
                .HasColumnName("FECHA2");
            entity.Property(e => e.Fecha3)
                .HasColumnType("datetime")
                .HasColumnName("FECHA3");
            entity.Property(e => e.NombreDeCuenta)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_DE_CUENTA");
            entity.Property(e => e.Nota1)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTA_1");
            entity.Property(e => e.Nota10)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTA_10");
            entity.Property(e => e.Nota11)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTA_11");
            entity.Property(e => e.Nota12)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTA_12");
            entity.Property(e => e.Nota13)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTA_13");
            entity.Property(e => e.Nota14)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTA_14");
            entity.Property(e => e.Nota15)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTA_15");
            entity.Property(e => e.Nota2)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTA_2");
            entity.Property(e => e.Nota3)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTA_3");
            entity.Property(e => e.Nota4)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTA_4");
            entity.Property(e => e.Nota5)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTA_5");
            entity.Property(e => e.Nota6)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTA_6");
            entity.Property(e => e.Nota7)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTA_7");
            entity.Property(e => e.Nota8)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTA_8");
            entity.Property(e => e.Nota9)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NOTA_9");
            entity.Property(e => e.NumeroDeCuenta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUMERO_DE_CUENTA");
            entity.Property(e => e.PropietarioDeCuenta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PROPIETARIO_DE_CUENTA");
            entity.Property(e => e.RifCodigo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RIF_CODIGO");
            entity.Property(e => e.Sector)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SECTOR");
            entity.Property(e => e.Sitio)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("SITIO");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<ZohoVendedor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ZOHO_VENDEDOR");

            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            entity.Property(e => e.Marcasoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MARCASOC");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VENDEDOR");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
