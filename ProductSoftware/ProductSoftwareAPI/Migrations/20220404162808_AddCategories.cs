using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductSoftwareAPI.Migrations
{
    public partial class AddCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IconCSS",
                table: "ProductCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "IconCSS",
                value: "fa-light fa-desktop");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "IconCSS",
                value: "fa-thin fa-computer");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "IconCSS",
                value: "fa-light fa-laptop");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconCSS",
                table: "ProductCategories");
        }
    }
}
