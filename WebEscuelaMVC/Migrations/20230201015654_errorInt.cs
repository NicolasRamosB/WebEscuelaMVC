using Microsoft.EntityFrameworkCore.Migrations;

namespace WebEscuelaMVC.Migrations
{
    public partial class errorInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Numero",
                table: "Aulas",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Aulas",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
