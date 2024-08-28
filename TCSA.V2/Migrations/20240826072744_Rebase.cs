using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCSA.V2.Migrations
{
    /// <inheritdoc />
    public partial class Rebase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "688ca468-c1f3-40e0-a5c1-bbf9221bdcbf");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f9b5ce3b-42a7-4306-841a-e7ed5ed3d2d3");
        }
    }
}
