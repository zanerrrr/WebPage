using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeBlog.BLL.Migrations
{
    public partial class MigrationUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ingredients",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Ingredients",
                table: "Recipes");
        }
    }
}
