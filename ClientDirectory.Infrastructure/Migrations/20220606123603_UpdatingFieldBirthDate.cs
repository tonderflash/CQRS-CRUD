using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientDirectory.Infrastructure.Migrations
{
    public partial class UpdatingFieldBirthDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BithDate",
                table: "Clients",
                newName: "BirthDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Clients",
                newName: "BithDate");
        }
    }
}
