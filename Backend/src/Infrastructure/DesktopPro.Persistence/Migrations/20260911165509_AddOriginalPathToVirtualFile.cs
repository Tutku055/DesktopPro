using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesktopPro.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddOriginalPathToVirtualFile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OriginalPath",
                table: "VirtualFiles",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OriginalPath",
                table: "VirtualFiles");
        }
    }
}
