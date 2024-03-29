using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SSO.Migrations
{
    /// <inheritdoc />
    public partial class Add_Desc_Role : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "Security",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "Security",
                table: "Roles");
        }
    }
}
