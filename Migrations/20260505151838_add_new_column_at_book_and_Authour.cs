using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramworkExample.Migrations
{
    /// <inheritdoc />
    public partial class add_new_column_at_book_and_Authour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Publiisher",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Author_Address",
                table: "Author",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Publiisher",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Author_Address",
                table: "Author");
        }
    }
}
