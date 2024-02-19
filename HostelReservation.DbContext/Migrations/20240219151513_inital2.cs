using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HostelReservation.Context.Migrations
{
    /// <inheritdoc />
    public partial class inital2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReservationCheckIn",
                table: "Reservations",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "integer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReservationCheckIn",
                table: "Reservations",
                type: "integer",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");
        }
    }
}
