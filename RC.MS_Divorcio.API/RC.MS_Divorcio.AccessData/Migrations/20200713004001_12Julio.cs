using Microsoft.EntityFrameworkCore.Migrations;

namespace RC.MS_Divorcio.AccessData.Migrations
{
    public partial class _12Julio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TramiteDivorcios_DetalleHijos_detalleHijosId",
                table: "TramiteDivorcios");

            migrationBuilder.DropTable(
                name: "Hijos");

            migrationBuilder.DropTable(
                name: "DetalleHijos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetalleHijos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleHijos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hijos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    detallehijosId = table.Column<int>(type: "int", nullable: false),
                    personaId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Hijos_detallehijosId",
                table: "Hijos",
                column: "detallehijosId");

            migrationBuilder.CreateIndex(
                name: "IX_Hijos_personaId",
                table: "Hijos",
                column: "personaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TramiteDivorcios_DetalleHijos_detalleHijosId",
                table: "TramiteDivorcios",
                column: "detalleHijosId",
                principalTable: "DetalleHijos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
