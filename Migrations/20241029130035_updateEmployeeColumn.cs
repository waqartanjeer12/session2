using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace session2.Migrations
{
    /// <inheritdoc />
    public partial class updateEmployeeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "employees",
                newName: "EmployeeName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "employees",
                newName: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "employees",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "employees",
                newName: "Id");
        }
    }
}
