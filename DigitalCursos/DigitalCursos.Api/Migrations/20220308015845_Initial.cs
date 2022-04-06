using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DigitalCursos.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    CursoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CursoNome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CargaHoraria = table.Column<int>(type: "int", nullable: false),
                    Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Logo = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.CursoId);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    AlunoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SobreNome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    CursoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.AlunoId);
                    table.ForeignKey(
                        name: "FK_Alunos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "CargaHoraria", "CursoNome", "Descricao", "Inicio", "Logo", "Preco" },
                values: new object[,]
                {
                    { 1, 1, "Curso 1", "Descrição do curso 1", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 2, 2, "Curso 2", "Descrição do curso 2", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 3, 3, "Curso 3", "Descrição do curso 3", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 4, 4, "Curso 4", "Descrição do curso 4", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 5, 5, "Curso 5", "Descrição do curso 5", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 6, 6, "Curso 6", "Descrição do curso 6", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 7, 7, "Curso 7", "Descrição do curso 7", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 8, 8, "Curso 8", "Descrição do curso 8", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 9, 9, "Curso 9", "Descrição do curso 9", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 10, 10, "Curso 10", "Descrição do curso 10", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 11, 11, "Curso 11", "Descrição do curso 11", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 12, 12, "Curso 12", "Descrição do curso 12", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 13, 13, "Curso 13", "Descrição do curso 13", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 14, 14, "Curso 14", "Descrição do curso 14", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 15, 15, "Curso 15", "Descrição do curso 15", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 16, 16, "Curso 16", "Descrição do curso 16", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 17, 17, "Curso 17", "Descrição do curso 17", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 18, 18, "Curso 18", "Descrição do curso 18", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 19, 19, "Curso 19", "Descrição do curso 19", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 20, 20, "Curso 20", "Descrição do curso 20", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 21, 21, "Curso 21", "Descrição do curso 21", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 22, 22, "Curso 22", "Descrição do curso 22", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 23, 23, "Curso 23", "Descrição do curso 23", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 24, 24, "Curso 24", "Descrição do curso 24", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 25, 25, "Curso 25", "Descrição do curso 25", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 26, 26, "Curso 26", "Descrição do curso 26", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 27, 27, "Curso 27", "Descrição do curso 27", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 28, 28, "Curso 28", "Descrição do curso 28", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 29, 29, "Curso 29", "Descrição do curso 29", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 30, 30, "Curso 30", "Descrição do curso 30", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 31, 31, "Curso 31", "Descrição do curso 31", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 32, 32, "Curso 32", "Descrição do curso 32", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 33, 33, "Curso 33", "Descrição do curso 33", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 34, 34, "Curso 34", "Descrição do curso 34", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 35, 35, "Curso 35", "Descrição do curso 35", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 36, 36, "Curso 36", "Descrição do curso 36", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 37, 37, "Curso 37", "Descrição do curso 37", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 38, 38, "Curso 38", "Descrição do curso 38", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 39, 39, "Curso 39", "Descrição do curso 39", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 40, 40, "Curso 40", "Descrição do curso 40", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 41, 41, "Curso 41", "Descrição do curso 41", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 42, 42, "Curso 42", "Descrição do curso 42", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m }
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "CargaHoraria", "CursoNome", "Descricao", "Inicio", "Logo", "Preco" },
                values: new object[,]
                {
                    { 43, 43, "Curso 43", "Descrição do curso 43", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 44, 44, "Curso 44", "Descrição do curso 44", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 45, 45, "Curso 45", "Descrição do curso 45", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 46, 46, "Curso 46", "Descrição do curso 46", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 47, 47, "Curso 47", "Descrição do curso 47", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 48, 48, "Curso 48", "Descrição do curso 48", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 49, 49, "Curso 49", "Descrição do curso 49", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 50, 50, "Curso 50", "Descrição do curso 50", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 51, 51, "Curso 51", "Descrição do curso 51", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 52, 52, "Curso 52", "Descrição do curso 52", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 53, 53, "Curso 53", "Descrição do curso 53", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 54, 54, "Curso 54", "Descrição do curso 54", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 55, 55, "Curso 55", "Descrição do curso 55", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 56, 56, "Curso 56", "Descrição do curso 56", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 57, 57, "Curso 57", "Descrição do curso 57", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 58, 58, "Curso 58", "Descrição do curso 58", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 59, 59, "Curso 59", "Descrição do curso 59", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 60, 60, "Curso 60", "Descrição do curso 60", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 61, 61, "Curso 61", "Descrição do curso 61", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 62, 62, "Curso 62", "Descrição do curso 62", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 63, 63, "Curso 63", "Descrição do curso 63", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 64, 64, "Curso 64", "Descrição do curso 64", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 65, 65, "Curso 65", "Descrição do curso 65", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 66, 66, "Curso 66", "Descrição do curso 66", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 67, 67, "Curso 67", "Descrição do curso 67", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 68, 68, "Curso 68", "Descrição do curso 68", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 69, 69, "Curso 69", "Descrição do curso 69", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 70, 70, "Curso 70", "Descrição do curso 70", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 71, 71, "Curso 71", "Descrição do curso 71", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 72, 72, "Curso 72", "Descrição do curso 72", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 73, 73, "Curso 73", "Descrição do curso 73", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 74, 74, "Curso 74", "Descrição do curso 74", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 75, 75, "Curso 75", "Descrição do curso 75", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 76, 76, "Curso 76", "Descrição do curso 76", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 77, 77, "Curso 77", "Descrição do curso 77", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 78, 78, "Curso 78", "Descrição do curso 78", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 79, 79, "Curso 79", "Descrição do curso 79", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 80, 80, "Curso 80", "Descrição do curso 80", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 81, 81, "Curso 81", "Descrição do curso 81", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 82, 82, "Curso 82", "Descrição do curso 82", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 83, 83, "Curso 83", "Descrição do curso 83", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 84, 84, "Curso 84", "Descrição do curso 84", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m }
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "CargaHoraria", "CursoNome", "Descricao", "Inicio", "Logo", "Preco" },
                values: new object[,]
                {
                    { 85, 85, "Curso 85", "Descrição do curso 85", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 86, 86, "Curso 86", "Descrição do curso 86", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 87, 87, "Curso 87", "Descrição do curso 87", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 88, 88, "Curso 88", "Descrição do curso 88", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 89, 89, "Curso 89", "Descrição do curso 89", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 90, 90, "Curso 90", "Descrição do curso 90", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 91, 91, "Curso 91", "Descrição do curso 91", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 92, 92, "Curso 92", "Descrição do curso 92", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 93, 93, "Curso 93", "Descrição do curso 93", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 94, 94, "Curso 94", "Descrição do curso 94", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 95, 95, "Curso 95", "Descrição do curso 95", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 96, 96, "Curso 96", "Descrição do curso 96", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 97, 97, "Curso 97", "Descrição do curso 97", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 98, 98, "Curso 98", "Descrição do curso 98", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 99, 99, "Curso 99", "Descrição do curso 99", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m },
                    { 100, 100, "Curso 100", "Descrição do curso 100", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_CursoId",
                table: "Alunos",
                column: "CursoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
