using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListaLeitura.Migrations
{
    public partial class updatelistaleitura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnoLeitura",
                table: "ListaLeituras",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnoLeitura",
                table: "ListaLeituras");
        }
    }
}
