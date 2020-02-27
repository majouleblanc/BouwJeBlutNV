using Microsoft.EntityFrameworkCore.Migrations;

namespace BouwJeBlutNV.Migrations
{
    public partial class adding_Some_Extra_Employees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "Name", "Photo" },
                values: new object[,]
                {
                    { 5, 1, "marie@BouwJeBlutNV.be", "marie", null },
                    { 6, 1, "tim@BouwJeBlutNV.be", "tim", null },
                    { 7, 3, "tolan@BouwJeBlutNV.be", "tolan", null },
                    { 8, 3, "victor@BouwJeBlutNV.be", "victor", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
