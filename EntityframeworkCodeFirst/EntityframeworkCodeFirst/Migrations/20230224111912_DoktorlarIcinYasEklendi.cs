using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityframeworkCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class DoktorlarIcinYasEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Yas",
                table: "Doktorlar",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Yas",
                table: "Doktorlar");
        }
    }
}
