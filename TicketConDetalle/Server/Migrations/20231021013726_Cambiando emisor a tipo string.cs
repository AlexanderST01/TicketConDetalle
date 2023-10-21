using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketConDetalle.Server.Migrations
{
    /// <inheritdoc />
    public partial class Cambiandoemisoratipostring : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketsDetalle_Clientes_EmisorClienteId",
                table: "TicketsDetalle");

            migrationBuilder.DropIndex(
                name: "IX_TicketsDetalle_EmisorClienteId",
                table: "TicketsDetalle");

            migrationBuilder.DropColumn(
                name: "EmisorClienteId",
                table: "TicketsDetalle");

            migrationBuilder.AlterColumn<string>(
                name: "Mensaje",
                table: "TicketsDetalle",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Emisor",
                table: "TicketsDetalle",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Emisor",
                table: "TicketsDetalle");

            migrationBuilder.AlterColumn<string>(
                name: "Mensaje",
                table: "TicketsDetalle",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmisorClienteId",
                table: "TicketsDetalle",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TicketsDetalle_EmisorClienteId",
                table: "TicketsDetalle",
                column: "EmisorClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketsDetalle_Clientes_EmisorClienteId",
                table: "TicketsDetalle",
                column: "EmisorClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
