using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRM.Recruiting.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixDataAnnotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "varchar(250)",
                table: "SubmissionStatus",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "varchar(25)",
                table: "JobRequirement",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "varchar(150)",
                table: "JobRequirement",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "varchar(26)",
                table: "Candidate",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "varchar(25)",
                table: "Candidate",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "varchar(150)",
                table: "Candidate",
                newName: "Email");

            migrationBuilder.RenameIndex(
                name: "IX_Candidate_varchar(150)",
                table: "Candidate",
                newName: "IX_Candidate_Email");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SubmissionStatus",
                type: "varchar(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "JobRequirement",
                type: "varchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "JobRequirement",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Candidate",
                type: "varchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Candidate",
                type: "varchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Candidate",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "SubmissionStatus",
                newName: "varchar(250)");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "JobRequirement",
                newName: "varchar(25)");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "JobRequirement",
                newName: "varchar(150)");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Candidate",
                newName: "varchar(26)");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Candidate",
                newName: "varchar(25)");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Candidate",
                newName: "varchar(150)");

            migrationBuilder.RenameIndex(
                name: "IX_Candidate_Email",
                table: "Candidate",
                newName: "IX_Candidate_varchar(150)");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(250)",
                table: "SubmissionStatus",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(25)",
                table: "JobRequirement",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(25)");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(150)",
                table: "JobRequirement",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(26)",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(25)");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(25)",
                table: "Candidate",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(25)");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(150)",
                table: "Candidate",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)");
        }
    }
}
