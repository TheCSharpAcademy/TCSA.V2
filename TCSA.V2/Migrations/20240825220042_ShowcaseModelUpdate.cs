using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCSA.V2.Migrations
{
    /// <inheritdoc />
    public partial class ShowcaseModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserLastName",
                table: "ShowcaseItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "ShowcaseItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f9b5ce3b-42a7-4306-841a-e7ed5ed3d2d3");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserLastName",
                table: "ShowcaseItems");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "ShowcaseItems");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1098a776-e1d9-4ea0-9b8a-0260cab3b6be");
        }
    }
}
