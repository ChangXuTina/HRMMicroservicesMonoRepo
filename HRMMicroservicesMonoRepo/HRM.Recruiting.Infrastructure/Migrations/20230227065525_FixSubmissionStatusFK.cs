using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRM.Recruiting.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixSubmissionStatusFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubmissionStatusCode",
                table: "Submission");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubmissionStatusCode",
                table: "Submission",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
