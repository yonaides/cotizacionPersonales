using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cotizacionesPersonales.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    ClienteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreCliente = table.Column<string>(nullable: true),
                    TelefonoCliente = table.Column<string>(nullable: true),
                    DireccionCliente = table.Column<string>(nullable: true),
                    EmailCliente = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.ClienteID);
                });

            migrationBuilder.CreateTable(
                name: "servicio",
                columns: table => new
                {
                    ServicioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreServicio = table.Column<string>(nullable: true),
                    DescripcionServicio = table.Column<string>(nullable: true),
                    PrecioServicio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servicio", x => x.ServicioID);
                });

            migrationBuilder.CreateTable(
                name: "cotizacion",
                columns: table => new
                {
                    CotizacionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClienteID = table.Column<int>(nullable: true),
                    FechaCotizacion = table.Column<DateTime>(nullable: false),
                    MontoTotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cotizacion", x => x.CotizacionID);
                    table.ForeignKey(
                        name: "FK_cotizacion_clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "clientes",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "servicioDetalle",
                columns: table => new
                {
                    ServicioDetalleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ServicioID = table.Column<int>(nullable: true),
                    DescripcionDetalleServicio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servicioDetalle", x => x.ServicioDetalleID);
                    table.ForeignKey(
                        name: "FK_servicioDetalle_servicio_ServicioID",
                        column: x => x.ServicioID,
                        principalTable: "servicio",
                        principalColumn: "ServicioID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cotizacionDetalle",
                columns: table => new
                {
                    CotizacionDetalleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdClienteClienteID = table.Column<int>(nullable: true),
                    IdServicioServicioID = table.Column<int>(nullable: true),
                    FechaCotizacion = table.Column<DateTime>(nullable: false),
                    precioServicio = table.Column<decimal>(nullable: false),
                    CotizacionID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cotizacionDetalle", x => x.CotizacionDetalleID);
                    table.ForeignKey(
                        name: "FK_cotizacionDetalle_cotizacion_CotizacionID",
                        column: x => x.CotizacionID,
                        principalTable: "cotizacion",
                        principalColumn: "CotizacionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cotizacionDetalle_clientes_IdClienteClienteID",
                        column: x => x.IdClienteClienteID,
                        principalTable: "clientes",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cotizacionDetalle_servicio_IdServicioServicioID",
                        column: x => x.IdServicioServicioID,
                        principalTable: "servicio",
                        principalColumn: "ServicioID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "ClienteID", "DireccionCliente", "EmailCliente", "NombreCliente", "TelefonoCliente" },
                values: new object[] { 1, "Santiago de los Caballeros", "yonaides@gmail.com", "Yonaides Tavares", null });

            migrationBuilder.CreateIndex(
                name: "IX_cotizacion_ClienteID",
                table: "cotizacion",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_cotizacionDetalle_CotizacionID",
                table: "cotizacionDetalle",
                column: "CotizacionID");

            migrationBuilder.CreateIndex(
                name: "IX_cotizacionDetalle_IdClienteClienteID",
                table: "cotizacionDetalle",
                column: "IdClienteClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_cotizacionDetalle_IdServicioServicioID",
                table: "cotizacionDetalle",
                column: "IdServicioServicioID");

            migrationBuilder.CreateIndex(
                name: "IX_servicioDetalle_ServicioID",
                table: "servicioDetalle",
                column: "ServicioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cotizacionDetalle");

            migrationBuilder.DropTable(
                name: "servicioDetalle");

            migrationBuilder.DropTable(
                name: "cotizacion");

            migrationBuilder.DropTable(
                name: "servicio");

            migrationBuilder.DropTable(
                name: "clientes");
        }
    }
}
