using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientDirectory.Infrastructure.Migrations
{
    public partial class RelationshipsModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientAddresses_Clients_PersonId",
                table: "ClientAddresses");

            migrationBuilder.DropColumn(
                name: "CientId",
                table: "ClientAddresses");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "ClientAddresses",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientAddresses_PersonId",
                table: "ClientAddresses",
                newName: "IX_ClientAddresses_ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientAddresses_Clients_ClientId",
                table: "ClientAddresses",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientAddresses_Clients_ClientId",
                table: "ClientAddresses");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "ClientAddresses",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientAddresses_ClientId",
                table: "ClientAddresses",
                newName: "IX_ClientAddresses_PersonId");

            migrationBuilder.AddColumn<int>(
                name: "CientId",
                table: "ClientAddresses",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientAddresses_Clients_PersonId",
                table: "ClientAddresses",
                column: "PersonId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
