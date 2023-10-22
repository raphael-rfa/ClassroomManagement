using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassroomManagement.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class FixTableName : Migration
    { 
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Students_StudentId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Subjects_SubjectId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Professors_Subjects_SubjectId",
                table: "Professors");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessorSubjects_Professors_ProfessorId",
                table: "ProfessorSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessorSubjects_Subjects_SubjectId",
                table: "ProfessorSubjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfessorSubjects",
                table: "ProfessorSubjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Professors",
                table: "Professors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exams",
                table: "Exams");

            migrationBuilder.RenameTable(
                name: "Subjects",
                newName: "Subject");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "ProfessorSubjects",
                newName: "ProfessoSubject");

            migrationBuilder.RenameTable(
                name: "Professors",
                newName: "Professor");

            migrationBuilder.RenameTable(
                name: "Exams",
                newName: "Exam");

            migrationBuilder.RenameIndex(
                name: "IX_ProfessorSubjects_ProfessorId",
                table: "ProfessoSubject",
                newName: "IX_ProfessoSubject_ProfessorId");

            migrationBuilder.RenameIndex(
                name: "IX_Professors_SubjectId",
                table: "Professor",
                newName: "IX_Professor_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Exams_SubjectId",
                table: "Exam",
                newName: "IX_Exam_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Exams_StudentId",
                table: "Exam",
                newName: "IX_Exam_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subject",
                table: "Subject",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfessoSubject",
                table: "ProfessoSubject",
                columns: new[] { "SubjectId", "ProfessorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Professor",
                table: "Professor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exam",
                table: "Exam",
                column: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exam_Student_StudentId",
                table: "Exam",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exam_Subject_SubjectId",
                table: "Exam",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Professor_Subject_SubjectId",
                table: "Professor",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessoSubject_Professor_ProfessorId",
                table: "ProfessoSubject",
                column: "ProfessorId",
                principalTable: "Professor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessoSubject_Subject_SubjectId",
                table: "ProfessoSubject",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exam_Student_StudentId",
                table: "Exam");

            migrationBuilder.DropForeignKey(
                name: "FK_Exam_Subject_SubjectId",
                table: "Exam");

            migrationBuilder.DropForeignKey(
                name: "FK_Professor_Subject_SubjectId",
                table: "Professor");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessoSubject_Professor_ProfessorId",
                table: "ProfessoSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessoSubject_Subject_SubjectId",
                table: "ProfessoSubject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subject",
                table: "Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfessoSubject",
                table: "ProfessoSubject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Professor",
                table: "Professor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exam",
                table: "Exam");

            migrationBuilder.RenameTable(
                name: "Subject",
                newName: "Subjects");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "ProfessoSubject",
                newName: "ProfessorSubjects");

            migrationBuilder.RenameTable(
                name: "Professor",
                newName: "Professors");

            migrationBuilder.RenameTable(
                name: "Exam",
                newName: "Exams");

            migrationBuilder.RenameIndex(
                name: "IX_ProfessoSubject_ProfessorId",
                table: "ProfessorSubjects",
                newName: "IX_ProfessorSubjects_ProfessorId");

            migrationBuilder.RenameIndex(
                name: "IX_Professor_SubjectId",
                table: "Professors",
                newName: "IX_Professors_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Exam_SubjectId",
                table: "Exams",
                newName: "IX_Exams_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Exam_StudentId",
                table: "Exams",
                newName: "IX_Exams_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfessorSubjects",
                table: "ProfessorSubjects",
                columns: new[] { "SubjectId", "ProfessorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Professors",
                table: "Professors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exams",
                table: "Exams",
                column: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Students_StudentId",
                table: "Exams",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Subjects_SubjectId",
                table: "Exams",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Professors_Subjects_SubjectId",
                table: "Professors",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessorSubjects_Professors_ProfessorId",
                table: "ProfessorSubjects",
                column: "ProfessorId",
                principalTable: "Professors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessorSubjects_Subjects_SubjectId",
                table: "ProfessorSubjects",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
