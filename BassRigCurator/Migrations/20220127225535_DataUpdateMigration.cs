using Microsoft.EntityFrameworkCore.Migrations;

namespace BassRigCurator.Migrations
{
    public partial class DataUpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Basses");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Amps");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Basses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Basses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Amps",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Amps",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Basses");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Basses");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Amps");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Amps");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Basses",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Amps",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
