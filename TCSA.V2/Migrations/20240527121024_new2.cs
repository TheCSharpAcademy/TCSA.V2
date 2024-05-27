using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCSA.V2.Migrations
{
    /// <inheritdoc />
    public partial class new2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "Issues",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reference",
                table: "Issues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "DashboardProjects",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Issues_AppUserId",
                table: "Issues",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Issues_AspNetUsers_AppUserId",
                table: "Issues",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Issues_AspNetUsers_AppUserId",
                table: "Issues");

            migrationBuilder.DropIndex(
                name: "IX_Issues_AppUserId",
                table: "Issues");

            migrationBuilder.DropColumn(
                name: "Reference",
                table: "Issues");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "DashboardProjects");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "Issues",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
