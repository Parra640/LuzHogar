using Microsoft.EntityFrameworkCore.Migrations;

namespace LuzHogar.Migrations
{
    public partial class CambioIdUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contratos_AspNetUsers_UsuarioId1",
                table: "Contratos");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidosEspeciales_AspNetUsers_UsuarioId1",
                table: "PedidosEspeciales");

            migrationBuilder.DropIndex(
                name: "IX_PedidosEspeciales_UsuarioId1",
                table: "PedidosEspeciales");

            migrationBuilder.DropIndex(
                name: "IX_Contratos_UsuarioId1",
                table: "Contratos");

            migrationBuilder.DropColumn(
                name: "UsuarioId1",
                table: "PedidosEspeciales");

            migrationBuilder.DropColumn(
                name: "UsuarioId1",
                table: "Contratos");

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioId",
                table: "PedidosEspeciales",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioId",
                table: "Contratos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_PedidosEspeciales_UsuarioId",
                table: "PedidosEspeciales",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_UsuarioId",
                table: "Contratos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contratos_AspNetUsers_UsuarioId",
                table: "Contratos",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidosEspeciales_AspNetUsers_UsuarioId",
                table: "PedidosEspeciales",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contratos_AspNetUsers_UsuarioId",
                table: "Contratos");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidosEspeciales_AspNetUsers_UsuarioId",
                table: "PedidosEspeciales");

            migrationBuilder.DropIndex(
                name: "IX_PedidosEspeciales_UsuarioId",
                table: "PedidosEspeciales");

            migrationBuilder.DropIndex(
                name: "IX_Contratos_UsuarioId",
                table: "Contratos");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "PedidosEspeciales",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId1",
                table: "PedidosEspeciales",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Contratos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId1",
                table: "Contratos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PedidosEspeciales_UsuarioId1",
                table: "PedidosEspeciales",
                column: "UsuarioId1");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_UsuarioId1",
                table: "Contratos",
                column: "UsuarioId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Contratos_AspNetUsers_UsuarioId1",
                table: "Contratos",
                column: "UsuarioId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidosEspeciales_AspNetUsers_UsuarioId1",
                table: "PedidosEspeciales",
                column: "UsuarioId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
