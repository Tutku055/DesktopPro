using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesktopPro.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemoveIconPathAndAddWorkspaceIconName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconPath",
                table: "Workspaces");

            migrationBuilder.DropColumn(
                name: "IconPath",
                table: "VirtualFiles");

            migrationBuilder.AddColumn<string>(
                name: "IconName",
                table: "Workspaces",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconName",
                table: "Workspaces");

            migrationBuilder.AddColumn<string>(
                name: "IconPath",
                table: "Workspaces",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IconPath",
                table: "VirtualFiles",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);
        }
    }
}
