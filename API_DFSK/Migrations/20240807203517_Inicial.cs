using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_DFSK.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    IdEstado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Estatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.IdEstado);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    IdVehiculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Marca = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Modelo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Anho = table.Column<int>(type: "int", nullable: true),
                    VIN = table.Column<string>(type: "varchar(17)", unicode: false, maxLength: 17, nullable: true),
                    Estatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Vehiculo__AA088620633F3CD2", x => x.IdVehiculo);
                });

            migrationBuilder.CreateTable(
                name: "Vendedores",
                columns: table => new
                {
                    IdVendedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Estatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Vendedor__2033EECC06D7C763", x => x.IdVendedor);
                });

            migrationBuilder.CreateTable(
                name: "Repuestos",
                columns: table => new
                {
                    IdRepuesto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: true),
                    IdVehiculo = table.Column<int>(type: "int", nullable: false),
                    Estatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Repuesto__75B30774EDDF74CD", x => x.IdRepuesto);
                    table.ForeignKey(
                        name: "FK_Repuestos_Vehiculos",
                        column: x => x.IdVehiculo,
                        principalTable: "Vehiculos",
                        principalColumn: "IdVehiculo");
                });

            migrationBuilder.CreateTable(
                name: "Solicitudes",
                columns: table => new
                {
                    IdSolicitud = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVendedor = table.Column<int>(type: "int", nullable: false),
                    IdRepuesto = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<double>(type: "float", nullable: true),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime", nullable: true),
                    IdEstado = table.Column<int>(type: "int", nullable: false),
                    FechaCompra = table.Column<DateTime>(type: "datetime", nullable: true),
                    Observacion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    FechaLlegada = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Solicitu__85E95DA75C3B08DD", x => x.IdSolicitud);
                    table.ForeignKey(
                        name: "FK_Solicitudes_Estados",
                        column: x => x.IdEstado,
                        principalTable: "Estados",
                        principalColumn: "IdEstado");
                    table.ForeignKey(
                        name: "FK__Solicitud__Repue__2D27B809",
                        column: x => x.IdRepuesto,
                        principalTable: "Repuestos",
                        principalColumn: "IdRepuesto");
                    table.ForeignKey(
                        name: "FK__Solicitud__Vende__2C3393D0",
                        column: x => x.IdVendedor,
                        principalTable: "Vendedores",
                        principalColumn: "IdVendedor");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Repuestos_IdVehiculo",
                table: "Repuestos",
                column: "IdVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_IdEstado",
                table: "Solicitudes",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_IdRepuesto",
                table: "Solicitudes",
                column: "IdRepuesto");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitudes_IdVendedor",
                table: "Solicitudes",
                column: "IdVendedor");

            migrationBuilder.CreateIndex(
                name: "UQ__Vehiculo__C5DF234C699ED050",
                table: "Vehiculos",
                column: "VIN",
                unique: true,
                filter: "[VIN] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Solicitudes");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Repuestos");

            migrationBuilder.DropTable(
                name: "Vendedores");

            migrationBuilder.DropTable(
                name: "Vehiculos");
        }
    }
}
