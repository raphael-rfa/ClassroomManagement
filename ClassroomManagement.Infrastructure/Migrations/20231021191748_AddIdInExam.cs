using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassroomManagement.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class AddIdInExam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExamId",
                table: "Exam",
                newName: "Id");

            migrationBuilder.RenameTable(
                name: "ProfessoSubject",
                newName: "ProfessorSubject");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Exam",
                newName: "ExamId");

            migrationBuilder.RenameTable(
                name: "ProfessoSubject",
                newName: "ProfessorSubject");
        }
    }
}
