using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RC.MS_Divorcio.AccessData.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetalleHijos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleHijos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DomicilioConvivencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    provinciaId = table.Column<int>(nullable: false),
                    localidadId = table.Column<int>(nullable: false),
                    calle = table.Column<string>(nullable: true),
                    numero = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomicilioConvivencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Propuestas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propuestas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudTipos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(nullable: true),
                    valor = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudTipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hijos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personaId = table.Column<int>(nullable: false),
                    detallehijosId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hijos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hijos_DetalleHijos_detallehijosId",
                        column: x => x.detallehijosId,
                        principalTable: "DetalleHijos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TramiteDivorcios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personaId1 = table.Column<int>(nullable: false),
                    personaId2 = table.Column<int>(nullable: false),
                    actaMatrimonioId = table.Column<int>(nullable: false),
                    domicilioConyugalId = table.Column<int>(nullable: false),
                    propuestaId = table.Column<int>(nullable: false),
                    detalleHijosId = table.Column<int>(nullable: false),
                    fecha = table.Column<DateTime>(nullable: false),
                    solicitudTipoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramiteDivorcios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TramiteDivorcios_DetalleHijos_detalleHijosId",
                        column: x => x.detalleHijosId,
                        principalTable: "DetalleHijos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TramiteDivorcios_DomicilioConvivencia_domicilioConyugalId",
                        column: x => x.domicilioConyugalId,
                        principalTable: "DomicilioConvivencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TramiteDivorcios_Propuestas_propuestaId",
                        column: x => x.propuestaId,
                        principalTable: "Propuestas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TramiteDivorcios_SolicitudTipos_solicitudTipoId",
                        column: x => x.solicitudTipoId,
                        principalTable: "SolicitudTipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hijos_detallehijosId",
                table: "Hijos",
                column: "detallehijosId");

            migrationBuilder.CreateIndex(
                name: "IX_TramiteDivorcios_detalleHijosId",
                table: "TramiteDivorcios",
                column: "detalleHijosId");

            migrationBuilder.CreateIndex(
                name: "IX_TramiteDivorcios_domicilioConyugalId",
                table: "TramiteDivorcios",
                column: "domicilioConyugalId");

            migrationBuilder.CreateIndex(
                name: "IX_TramiteDivorcios_propuestaId",
                table: "TramiteDivorcios",
                column: "propuestaId");

            migrationBuilder.CreateIndex(
                name: "IX_TramiteDivorcios_solicitudTipoId",
                table: "TramiteDivorcios",
                column: "solicitudTipoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hijos");

            migrationBuilder.DropTable(
                name: "TramiteDivorcios");

            migrationBuilder.DropTable(
                name: "DetalleHijos");

            migrationBuilder.DropTable(
                name: "DomicilioConvivencia");

            migrationBuilder.DropTable(
                name: "Propuestas");

            migrationBuilder.DropTable(
                name: "SolicitudTipos");
        }
    }
}
