using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Guarda.Data.Migrations
{
    public partial class UpdateProductConfigurationIsClassicIsSportIsSmart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsClassic",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsSmart",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsSport",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsClassic",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSmart",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSport",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
