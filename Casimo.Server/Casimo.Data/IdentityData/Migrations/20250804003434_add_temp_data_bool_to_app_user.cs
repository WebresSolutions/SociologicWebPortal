using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Casimo.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class add_temp_data_bool_to_app_user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsTemporaryUser",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTemporaryUser",
                table: "AspNetUsers");
        }
    }
}
