using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestãoDeSalaDeAula.Migrations
{
    /// <inheritdoc />
    public partial class ProfessoresMaterias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfessorMateria_Materias_MateriaId",
                table: "ProfessorMateria");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessorMateria_Professores_ProfessorId",
                table: "ProfessorMateria");

            migrationBuilder.RenameColumn(
                name: "ProfessorId",
                table: "ProfessorMateria",
                newName: "ProfessoresId");

            migrationBuilder.RenameColumn(
                name: "MateriaId",
                table: "ProfessorMateria",
                newName: "MateriasId");

            migrationBuilder.RenameIndex(
                name: "IX_ProfessorMateria_ProfessorId",
                table: "ProfessorMateria",
                newName: "IX_ProfessorMateria_ProfessoresId");

            migrationBuilder.AddColumn<int>(
                name: "ProfessoresId",
                table: "Materias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materias_ProfessoresId",
                table: "Materias",
                column: "ProfessoresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materias_Professores_ProfessoresId",
                table: "Materias",
                column: "ProfessoresId",
                principalTable: "Professores",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materias_Professores_ProfessoresId",
                table: "Materias");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessorMateria_Materias_MateriasId",
                table: "ProfessorMateria");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfessorMateria_Professores_ProfessoresId",
                table: "ProfessorMateria");

            migrationBuilder.DropIndex(
                name: "IX_Materias_ProfessoresId",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "ProfessoresId",
                table: "Materias");

            migrationBuilder.RenameColumn(
                name: "ProfessoresId",
                table: "ProfessorMateria",
                newName: "ProfessorId");

            migrationBuilder.RenameColumn(
                name: "MateriasId",
                table: "ProfessorMateria",
                newName: "MateriaId");

            migrationBuilder.RenameIndex(
                name: "IX_ProfessorMateria_ProfessoresId",
                table: "ProfessorMateria",
                newName: "IX_ProfessorMateria_ProfessorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfessorMateria_Materias_MateriaId",
                table: "ProfessorMateria",
                column: "MateriaId",
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
        }
    }
}
