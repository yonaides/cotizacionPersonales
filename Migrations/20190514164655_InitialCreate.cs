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
                        name: "FK_Cotizacion_clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "clientes",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CotizacionDetalle",
                columns: table => new
                {
                    CotizacionDetalleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdClienteClienteID = table.Column<int>(nullable: true),
                    FechaCotizacion = table.Column<DateTime>(nullable: false),
                    MontoTotal = table.Column<decimal>(nullable: false),
                    CotizacionID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CotizacionDetalle", x => x.CotizacionDetalleID);
                    table.ForeignKey(
                        name: "FK_CotizacionDetalle_Cotizacion_CotizacionID",
                        column: x => x.CotizacionID,
                        principalTable: "Cotizacion",
                        principalColumn: "CotizacionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CotizacionDetalle_clientes_IdClienteClienteID",
                        column: x => x.IdClienteClienteID,
                        principalTable: "clientes",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cotizacion_ClienteID",
                table: "Cotizacion",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_CotizacionDetalle_CotizacionID",
                table: "CotizacionDetalle",
                column: "CotizacionID");

            migrationBuilder.CreateIndex(
                name: "IX_CotizacionDetalle_IdClienteClienteID",
                table: "CotizacionDetalle",
                column: "IdClienteClienteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CotizacionDetalle");

            migrationBuilder.DropTable(
                name: "Cotizacion");

            migrationBuilder.DropTable(
                name: "clientes");
        }
    }
}
