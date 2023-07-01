using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConventionPractice.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.DropColumn(
                name: "Test",
                table: "Students");
        }
    }
}
