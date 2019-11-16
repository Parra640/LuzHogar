using Microsoft.EntityFrameworkCore.Migrations;

namespace LuzHogar.Migrations
{
    public partial class cambioEnPedidoEspecial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "PedidosEspeciales",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "PedidosEspeciales");
        }
    }
}
