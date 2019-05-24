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
                name: "Clientes",
                columns: table => new
                {
                    ClienteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreCliente = table.Column<string>(nullable: false),
                    TelefonoCliente = table.Column<string>(nullable: true),
                    DireccionCliente = table.Column<string>(nullable: true),
                    EmailCliente = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteID);
                });

            migrationBuilder.CreateTable(
                name: "Servicio",
                columns: table => new
                {
                    ServicioID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreServicio = table.Column<string>(nullable: false),
                    DescripcionServicio = table.Column<string>(nullable: true),
                    PrecioServicio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicio", x => x.ServicioID);
                });

            migrationBuilder.CreateTable(
                name: "Cotizacion",
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
                    table.PrimaryKey("PK_Cotizacion", x => x.CotizacionID);
                    table.ForeignKey(
                        name: "FK_Cotizacion_Clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Clientes",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServicioDetalle",
                columns: table => new
                {
                    ServicioDetalleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ServicioID = table.Column<int>(nullable: false),
                    DescripcionDetalleServicio = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicioDetalle", x => x.ServicioDetalleID);
                    table.ForeignKey(
                        name: "FK_ServicioDetalle_Servicio_ServicioID",
                        column: x => x.ServicioID,
                        principalTable: "Servicio",
                        principalColumn: "ServicioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CotizacionDetalle",
                columns: table => new
                {
                    CotizacionDetalleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CotizacionID = table.Column<int>(nullable: false),
                    ServicioID = table.Column<int>(nullable: false),
                    FechaCotizacion = table.Column<DateTime>(nullable: false),
                    precioServicio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CotizacionDetalle", x => x.CotizacionDetalleID);
                    table.ForeignKey(
                        name: "FK_CotizacionDetalle_Cotizacion_CotizacionID",
                        column: x => x.CotizacionID,
                        principalTable: "Cotizacion",
                        principalColumn: "CotizacionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CotizacionDetalle_Servicio_ServicioID",
                        column: x => x.ServicioID,
                        principalTable: "Servicio",
                        principalColumn: "ServicioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteID", "DireccionCliente", "EmailCliente", "NombreCliente", "TelefonoCliente" },
                values: new object[] { 1, "Santiago de los Caballeros", "yonaides@gmail.com", "Yonaides Tavares", "829-883-6835" });

            migrationBuilder.CreateIndex(
                name: "IX_Cotizacion_ClienteID",
                table: "Cotizacion",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_CotizacionDetalle_CotizacionID",
                table: "CotizacionDetalle",
                column: "CotizacionID");

            migrationBuilder.CreateIndex(
                name: "IX_CotizacionDetalle_ServicioID",
                table: "CotizacionDetalle",
                column: "ServicioID");

            migrationBuilder.CreateIndex(
                name: "IX_ServicioDetalle_ServicioID",
                table: "ServicioDetalle",
                column: "ServicioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CotizacionDetalle");

            migrationBuilder.DropTable(
                name: "ServicioDetalle");

            migrationBuilder.DropTable(
                name: "Cotizacion");

            migrationBuilder.DropTable(
                name: "Servicio");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
