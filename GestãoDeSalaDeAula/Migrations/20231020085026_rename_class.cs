using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassroomManagement.Migrations
{
    /// <inheritdoc />
    public partial class renameclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Professores_Materias_MateriasId",
                table: "Professores");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessorMateria_Materias_MateriasId",
                table: "ProfessorMateria");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessorMateria_Professores_ProfessoresId",
                table: "ProfessorMateria");

            migrationBuilder.DropForeignKey(
                name: "FK_Provas_Alunos_AlunosId",
                table: "Provas");

            migrationBuilder.DropForeignKey(
                name: "FK_Provas_Materias_MateriasId",
                table: "Provas");

            migrationBuilder.RenameColumn(
                name: "Nota",
                table: "Provas",
                newName: "Score");

            migrationBuilder.RenameColumn(
                name: "MateriasId",
                table: "Provas",
                newName: "SubjectId");

            migrationBuilder.RenameColumn(
                name: "AlunosId",
                table: "Provas",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "ProvasId",
                table: "Provas",
                newName: "ExamId");

            migrationBuilder.RenameIndex(
                name: "IX_Provas_MateriasId",
                table: "Provas",
                newName: "IX_Provas_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Provas_AlunosId",
                table: "Provas",
                newName: "IX_Provas_StudentId");

            migrationBuilder.RenameColumn(
                name: "ProfessoresId",
                table: "ProfessorMateria",
                newName: "ProfessorId");

            migrationBuilder.RenameColumn(
                name: "MateriasId",
                table: "ProfessorMateria",
                newName: "SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_ProfessorMateria_ProfessoresId",
                table: "ProfessorMateria",
                newName: "IX_ProfessorMateria_ProfessorId");

            migrationBuilder.RenameColumn(
                name: "MateriasId",
                table: "Professores",
                newName: "SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Professores_MateriasId",
                table: "Professores",
                newName: "IX_Professores_SubjectId");

            migrationBuilder.RenameColumn(
                name: "MateriasName",
                table: "Materias",
                newName: "SubjectName");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "Provas",
                newName: "MateriasId");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Provas",
                newName: "AlunosId");

            migrationBuilder.RenameColumn(
                name: "Score",
                table: "Provas",
                newName: "Nota");

            migrationBuilder.RenameColumn(
                name: "ExamId",
                table: "Provas",
                newName: "ProvasId");

            migrationBuilder.RenameIndex(
                name: "IX_Provas_SubjectId",
                table: "Provas",
                newName: "IX_Provas_MateriasId");

            migrationBuilder.RenameIndex(
                name: "IX_Provas_StudentId",
                table: "Provas",
                newName: "IX_Provas_AlunosId");

            migrationBuilder.RenameColumn(
                name: "ProfessorId",
                table: "ProfessorMateria",
                newName: "ProfessoresId");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "ProfessorMateria",
                newName: "MateriasId");

            migrationBuilder.RenameIndex(
                name: "IX_ProfessorMateria_ProfessorId",
                table: "ProfessorMateria",
                newName: "IX_ProfessorMateria_ProfessoresId");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "Professores",
                newName: "MateriasId");

            migrationBuilder.RenameIndex(
                name: "IX_Professores_SubjectId",
                table: "Professores",
                newName: "IX_Professores_MateriasId");

            migrationBuilder.RenameColumn(
                name: "SubjectName",
                table: "Materias",
                newName: "MateriasName");

            migrationBuilder.AddForeignKey(
                name: "FK_Professores_Materias_MateriasId",
                table: "Professores",
                column: "MateriasId",
                principalTable: "Materias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessorMateria_Materias_MateriasId",
                table: "ProfessorMateria",
                column: "MateriasId",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessorMateria_Professores_ProfessoresId",
                table: "ProfessorMateria",
                column: "ProfessoresId",
                principalTable: "Professores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Provas_Alunos_AlunosId",
                table: "Provas",
                column: "AlunosId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Provas_Materias_MateriasId",
                table: "Provas",
                column: "MateriasId",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
