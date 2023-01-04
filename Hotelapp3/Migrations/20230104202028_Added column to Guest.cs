using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotelapp3.Migrations
{
    public partial class AddedcolumntoGuest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Guest",
                newName: "GuestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GuestId",
                table: "Guest",
                newName: "Id");
        }
    }
}
