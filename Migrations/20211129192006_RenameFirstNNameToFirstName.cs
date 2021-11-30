using Microsoft.EntityFrameworkCore.Migrations;

namespace Pims.Migrations
{
    public partial class RenameFirstNNameToFirstName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstNName",
                table: "Employees",
                newName: "FirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Employees",
                newName: "FirstNName");
        }
    }
}
