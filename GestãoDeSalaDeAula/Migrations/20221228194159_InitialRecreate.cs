using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassroomManagement.Migrations
{
    /// <inheritdoc />
    public partial class InitialRecreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MateriasName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MateriasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professores_Materias_MateriasId",
                        column: x => x.MateriasId,
                        principalTable: "Materias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Provas",
                columns: table => new
                {
                    ProvasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlunosId = table.Column<int>(type: "int", nullable: false),
                    MateriasId = table.Column<int>(type: "int", nullable: false),
                    Nota = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provas", x => x.ProvasId);
                    table.ForeignKey(
                        name: "FK_Provas_Alunos_AlunosId",
                        column: x => x.AlunosId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Provas_Materias_MateriasId",
                        column: x => x.MateriasId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessorMateria",
                columns: table => new
                {
                    ProfessoresId = table.Column<int>(type: "int", nullable: false),
                    MateriasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessorMateria", x => new { x.MateriasId, x.ProfessoresId });
                    table.ForeignKey(
                        name: "FK_ProfessorMateria_Materias_MateriasId",
                        column: x => x.MateriasId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessorMateria_Professores_ProfessoresId",
                        column: x => x.ProfessoresId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Professores_MateriasId",
                table: "Professores",
                column: "MateriasId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessorMateria_ProfessoresId",
                table: "ProfessorMateria",
                column: "ProfessoresId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Provas_AlunosId",
                table: "Provas",
                column: "AlunosId");

            migrationBuilder.CreateIndex(
                name: "IX_Provas_MateriasId",
                table: "Provas",
                column: "MateriasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfessorMateria");

            migrationBuilder.DropTable(
                name: "Provas");

            migrationBuilder.DropTable(
                name: "Professores");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Materias");
        }
    }
}
