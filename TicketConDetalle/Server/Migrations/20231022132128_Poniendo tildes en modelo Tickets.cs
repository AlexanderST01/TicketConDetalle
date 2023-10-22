using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketConDetalle.Server.Migrations
{
    /// <inheritdoc />
    public partial class PoniendotildesenmodeloTickets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Tickets",
                newName: "Descripción");

            migrationBuilder.AlterColumn<string>(
                name: "Mensaje",
                table: "TicketsDetalle",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Emisor",
                table: "TicketsDetalle",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripción",
                table: "Tickets",
                newName: "Descripcion");

            migrationBuilder.AlterColumn<string>(
                name: "Mensaje",
                table: "TicketsDetalle",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Emisor",
                table: "TicketsDetalle",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
