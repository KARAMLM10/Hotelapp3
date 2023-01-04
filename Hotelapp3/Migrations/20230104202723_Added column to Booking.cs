using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotelapp3.Migrations
{
    public partial class AddedcolumntoBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Booking",
                newName: "BookingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookingId",
                table: "Booking",
                newName: "Id");
        }
    }
}
