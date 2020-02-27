using Microsoft.EntityFrameworkCore.Migrations;

namespace BouwJeBlutNV.Migrations
{
    public partial class adding_Some_Initial_Employees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "Name", "Photo" },
                values: new object[] { 2, 1, "youssef@BouwJeBlutNV.be", "youssef", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "Name", "Photo" },
                values: new object[] { 3, 2, "john@BouwJeBlutNV.be", "john", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "Name", "Photo" },
                values: new object[] { 4, 2, "kaya@BouwJeBlutNV.be", "kaya", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
