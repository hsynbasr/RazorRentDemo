using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorRentDemo.Migrations
{
    public partial class PropadiDegisti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Reservations",
                newName: "TotalPrice");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "Reservations",
                newName: "Price");
        }
    }
}
