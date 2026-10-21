using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false),
                    PersonagemHabilidadeHabilidadeId = table.Column<int>(type: "int", nullable: true),
                    PersonagemHabilidadePersonagemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_HABILIDADES_PersonagemHabilidadePersonagemId_PersonagemHabilidadeHabilidadeId",
                        columns: x => new { x.PersonagemHabilidadePersonagemId, x.PersonagemHabilidadeHabilidadeId },
                        principalTable: "TB_PERSONAGENS_HABILIDADES",
                        principalColumns: new[] { "PersonagemId", "HabilidadeId" });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 68, 148, 112, 250, 167, 233, 216, 23, 132, 89, 203, 227, 220, 240, 254, 114, 45, 13, 130, 200, 114, 128, 12, 165, 49, 109, 22, 76, 58, 193, 188, 196, 125, 49, 92, 117, 70, 58, 77, 172, 188, 46, 67, 14, 249, 188, 120, 206, 90, 161, 99, 208, 155, 149, 17, 80, 195, 207, 212, 212, 238, 86, 133, 186 }, new byte[] { 248, 154, 184, 44, 123, 184, 233, 174, 219, 82, 237, 37, 58, 161, 28, 24, 10, 57, 144, 201, 60, 82, 66, 228, 155, 85, 223, 17, 154, 111, 7, 27, 103, 88, 218, 222, 96, 21, 59, 121, 0, 43, 172, 90, 228, 225, 198, 245, 26, 97, 12, 250, 115, 249, 230, 247, 192, 171, 215, 174, 67, 9, 172, 87, 162, 254, 1, 208, 177, 4, 78, 68, 251, 115, 193, 202, 106, 48, 164, 198, 81, 81, 240, 139, 0, 189, 130, 18, 230, 216, 159, 95, 223, 18, 249, 18, 240, 109, 234, 189, 67, 87, 231, 210, 60, 141, 244, 22, 39, 220, 5, 168, 117, 158, 5, 166, 38, 152, 151, 45, 19, 66, 2, 3, 27, 79, 240, 185 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId", "PersonagemHabilidadeHabilidadeId", "PersonagemHabilidadePersonagemId" },
                values: new object[,]
                {
                    { 1, 1, null, null },
                    { 2, 1, null, null },
                    { 2, 2, null, null },
                    { 2, 3, null, null },
                    { 3, 3, null, null },
                    { 3, 4, null, null },
                    { 1, 5, null, null },
                    { 2, 6, null, null },
                    { 3, 7, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_PersonagemHabilidadePersonagemId_PersonagemHabilidadeHabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "PersonagemHabilidadePersonagemId", "PersonagemHabilidadeHabilidadeId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 122, 237, 65, 88, 139, 253, 38, 253, 2, 227, 207, 241, 168, 131, 209, 32, 222, 150, 58, 183, 72, 33, 169, 35, 166, 168, 29, 41, 171, 196, 38, 62, 211, 174, 235, 179, 114, 153, 184, 2, 246, 247, 38, 194, 7, 47, 118, 194, 177, 125, 127, 181, 143, 41, 114, 160, 102, 120, 136, 187, 218, 86, 236, 39 }, new byte[] { 94, 90, 117, 235, 202, 240, 215, 41, 153, 101, 17, 142, 44, 13, 190, 182, 168, 184, 56, 38, 184, 191, 36, 245, 51, 232, 136, 12, 192, 85, 18, 238, 142, 234, 208, 180, 188, 24, 241, 126, 190, 88, 5, 147, 98, 135, 137, 176, 51, 137, 200, 231, 80, 236, 96, 6, 56, 92, 158, 237, 176, 101, 86, 209, 29, 9, 67, 237, 12, 210, 58, 26, 77, 160, 186, 62, 244, 150, 107, 138, 10, 201, 211, 110, 127, 220, 250, 234, 192, 8, 252, 165, 21, 116, 180, 85, 125, 227, 25, 62, 137, 137, 229, 67, 27, 159, 22, 128, 208, 229, 43, 176, 87, 39, 50, 184, 66, 51, 8, 27, 184, 173, 163, 192, 54, 161, 172, 79 } });
        }
    }
}
