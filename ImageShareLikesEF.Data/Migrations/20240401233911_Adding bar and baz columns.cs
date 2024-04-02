using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImageShareLikesEF.Data.Migrations
{
    /// <inheritdoc />
    public partial class Addingbarandbazcolumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bar",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Baz",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bar",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "Baz",
                table: "Images");
        }
    }
}
