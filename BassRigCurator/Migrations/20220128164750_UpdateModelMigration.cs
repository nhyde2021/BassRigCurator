using Microsoft.EntityFrameworkCore.Migrations;

namespace BassRigCurator.Migrations
{
    public partial class UpdateModelMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Portable",
                table: "Amps");

            migrationBuilder.AlterColumn<int>(
                name: "Volume",
                table: "Amps",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Volume",
                table: "Amps",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Portable",
                table: "Amps",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
