using Microsoft.EntityFrameworkCore.Migrations;

namespace RC.MS_Divorcio.AccessData.Migrations
{
    public partial class _12Julio2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TramiteDivorcios_SolicitudTipos_solicitudTipoId",
                table: "TramiteDivorcios");

            migrationBuilder.DropIndex(
                name: "IX_TramiteDivorcios_detalleHijosId",
                table: "TramiteDivorcios");

            migrationBuilder.DropColumn(
                name: "detalleHijosId",
                table: "TramiteDivorcios");

            migrationBuilder.AlterColumn<int>(
                name: "solicitudTipoId",
                table: "TramiteDivorcios",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TramiteDivorcios_SolicitudTipos_solicitudTipoId",
                table: "TramiteDivorcios",
                column: "solicitudTipoId",
                principalTable: "SolicitudTipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TramiteDivorcios_SolicitudTipos_solicitudTipoId",
                table: "TramiteDivorcios");

            migrationBuilder.AlterColumn<int>(
                name: "solicitudTipoId",
                table: "TramiteDivorcios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "detalleHijosId",
                table: "TramiteDivorcios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TramiteDivorcios_detalleHijosId",
                table: "TramiteDivorcios",
                column: "detalleHijosId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TramiteDivorcios_SolicitudTipos_solicitudTipoId",
                table: "TramiteDivorcios",
                column: "solicitudTipoId",
                principalTable: "SolicitudTipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
