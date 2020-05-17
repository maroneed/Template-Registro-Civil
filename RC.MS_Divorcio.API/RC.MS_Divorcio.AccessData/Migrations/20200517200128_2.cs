using Microsoft.EntityFrameworkCore.Migrations;

namespace RC.MS_Divorcio.AccessData.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TramiteDivorcios_detalleHijosId",
                table: "TramiteDivorcios");

            migrationBuilder.DropIndex(
                name: "IX_TramiteDivorcios_propuestaId",
                table: "TramiteDivorcios");

            migrationBuilder.AlterColumn<decimal>(
                name: "valor",
                table: "SolicitudTipos",
                type: "decimal(15,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "SolicitudTipos",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "Propuestas",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "numero",
                table: "DomicilioConvivencia",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "calle",
                table: "DomicilioConvivencia",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TramiteDivorcios_actaMatrimonioId",
                table: "TramiteDivorcios",
                column: "actaMatrimonioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TramiteDivorcios_detalleHijosId",
                table: "TramiteDivorcios",
                column: "detalleHijosId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TramiteDivorcios_propuestaId",
                table: "TramiteDivorcios",
                column: "propuestaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hijos_personaId",
                table: "Hijos",
                column: "personaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TramiteDivorcios_actaMatrimonioId",
                table: "TramiteDivorcios");

            migrationBuilder.DropIndex(
                name: "IX_TramiteDivorcios_detalleHijosId",
                table: "TramiteDivorcios");

            migrationBuilder.DropIndex(
                name: "IX_TramiteDivorcios_propuestaId",
                table: "TramiteDivorcios");

            migrationBuilder.DropIndex(
                name: "IX_Hijos_personaId",
                table: "Hijos");

            migrationBuilder.AlterColumn<decimal>(
                name: "valor",
                table: "SolicitudTipos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(15,2)");

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "SolicitudTipos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "Propuestas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "numero",
                table: "DomicilioConvivencia",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 45);

            migrationBuilder.AlterColumn<string>(
                name: "calle",
                table: "DomicilioConvivencia",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 45);

            migrationBuilder.CreateIndex(
                name: "IX_TramiteDivorcios_detalleHijosId",
                table: "TramiteDivorcios",
                column: "detalleHijosId");

            migrationBuilder.CreateIndex(
                name: "IX_TramiteDivorcios_propuestaId",
                table: "TramiteDivorcios",
                column: "propuestaId");
        }
    }
}
