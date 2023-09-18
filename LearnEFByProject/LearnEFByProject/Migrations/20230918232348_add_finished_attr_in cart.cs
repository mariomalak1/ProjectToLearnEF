using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnEFByProject.Migrations
{
    /// <inheritdoc />
    public partial class add_finished_attr_incart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Finished",
                table: "Cart",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Finished",
                table: "Cart");
        }
    }
}
