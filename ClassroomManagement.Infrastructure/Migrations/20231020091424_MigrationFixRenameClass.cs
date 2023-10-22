using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassroomManagement.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class MigrationFixRenameClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Professores_Materias_SubjectId",
                table: "Professores");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessorMateria_Materias_SubjectId",
                table: "ProfessorMateria");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessorMateria_Professores_ProfessorId",
                table: "ProfessorMateria");

            migrationBuilder.DropForeignKey(
                name: "FK_Provas_Alunos_StudentId",
                table: "Provas");

            migrationBuilder.DropForeignKey(
                name: "FK_Provas_Materias_SubjectId",
                table: "Provas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provas",
                table: "Provas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfessorMateria",
                table: "ProfessorMateria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Professores",
                table: "Professores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materias",
                table: "Materias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos");

            migrationBuilder.RenameTable(
                name: "Provas",
                newName: "Exams");

            migrationBuilder.RenameTable(
                name: "ProfessorMateria",
                newName: "ProfessorSubjects");

            migrationBuilder.RenameTable(
                name: "Professores",
                newName: "Professors");

            migrationBuilder.RenameTable(
                name: "Materias",
                newName: "Subjects");

            migrationBuilder.RenameTable(
                name: "Alunos",
                newName: "Students");

            migrationBuilder.RenameIndex(
                name: "IX_Provas_SubjectId",
                table: "Exams",
                newName: "IX_Exams_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Provas_StudentId",
                table: "Exams",
                newName: "IX_Exams_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_ProfessorMateria_ProfessorId",
                table: "ProfessorSubjects",
                newName: "IX_ProfessorSubjects_ProfessorId");

            migrationBuilder.RenameIndex(
                name: "IX_Professores_SubjectId",
                table: "Professors",
                newName: "IX_Professors_SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exams",
                table: "Exams",
                column: "ExamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfessorSubjects",
                table: "ProfessorSubjects",
                columns: new[] { "SubjectId", "ProfessorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Professors",
                table: "Professors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "Materias");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Alunos");

            migrationBuilder.RenameTable(
                name: "ProfessorSubjects",
                newName: "ProfessorMateria");

            migrationBuilder.RenameTable(
                name: "Professors",
                newName: "Professores");

            migrationBuilder.RenameTable(
                name: "Exams",
                newName: "Provas");

            migrationBuilder.RenameIndex(
                name: "IX_ProfessorSubjects_ProfessorId",
                table: "ProfessorMateria",
                newName: "IX_ProfessorMateria_ProfessorId");

            migrationBuilder.RenameIndex(
                name: "IX_Professors_SubjectId",
                table: "Professores",
                newName: "IX_Professores_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Exams_SubjectId",
                table: "Provas",
                newName: "IX_Provas_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Exams_StudentId",
                table: "Provas",
                newName: "IX_Provas_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materias",
                table: "Materias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfessorMateria",
                table: "ProfessorMateria",
                columns: new[] { "SubjectId", "ProfessorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Professores",
                table: "Professores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provas",
                table: "Provas",
                column: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Professores_Materias_SubjectId",
                table: "Professores",
                column: "SubjectId",
                principalTable: "Materias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessorMateria_Materias_SubjectId",
                table: "ProfessorMateria",
                column: "SubjectId",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessorMateria_Professores_ProfessorId",
                table: "ProfessorMateria",
                column: "ProfessorId",
                principalTable: "Professores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Provas_Alunos_StudentId",
                table: "Provas",
                column: "StudentId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Provas_Materias_SubjectId",
                table: "Provas",
                column: "SubjectId",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
