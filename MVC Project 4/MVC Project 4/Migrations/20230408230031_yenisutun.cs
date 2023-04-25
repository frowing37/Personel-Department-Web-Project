using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Project_4.Migrations
{
    /// <inheritdoc />
    public partial class yenisutun : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Detay",
                table: "departmanlar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detay",
                table: "departmanlar");
        }
    }
}
