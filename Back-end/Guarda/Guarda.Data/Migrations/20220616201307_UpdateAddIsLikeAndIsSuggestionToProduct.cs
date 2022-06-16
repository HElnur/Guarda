using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Guarda.Data.Migrations
{
    public partial class UpdateAddIsLikeAndIsSuggestionToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsLike",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSuggestion",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLike",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsSuggestion",
                table: "Products");
        }
    }
}
