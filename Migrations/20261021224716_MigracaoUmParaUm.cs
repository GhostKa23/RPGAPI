using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 122, 237, 65, 88, 139, 253, 38, 253, 2, 227, 207, 241, 168, 131, 209, 32, 222, 150, 58, 183, 72, 33, 169, 35, 166, 168, 29, 41, 171, 196, 38, 62, 211, 174, 235, 179, 114, 153, 184, 2, 246, 247, 38, 194, 7, 47, 118, 194, 177, 125, 127, 181, 143, 41, 114, 160, 102, 120, 136, 187, 218, 86, 236, 39 }, new byte[] { 94, 90, 117, 235, 202, 240, 215, 41, 153, 101, 17, 142, 44, 13, 190, 182, 168, 184, 56, 38, 184, 191, 36, 245, 51, 232, 136, 12, 192, 85, 18, 238, 142, 234, 208, 180, 188, 24, 241, 126, 190, 88, 5, 147, 98, 135, 137, 176, 51, 137, 200, 231, 80, 236, 96, 6, 56, 92, 158, 237, 176, 101, 86, 209, 29, 9, 67, 237, 12, 210, 58, 26, 77, 160, 186, 62, 244, 150, 107, 138, 10, 201, 211, 110, 127, 220, 250, 234, 192, 8, 252, 165, 21, 116, 180, 85, 125, 227, 25, 62, 137, 137, 229, 67, 27, 159, 22, 128, 208, 229, 43, 176, 87, 39, 50, 184, 66, 51, 8, 27, 184, 173, 163, 192, 54, 161, 172, 79 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 113, 74, 172, 135, 114, 182, 87, 162, 23, 184, 165, 0, 137, 116, 97, 62, 15, 129, 81, 229, 238, 69, 23, 166, 227, 50, 201, 207, 140, 107, 202, 230, 102, 27, 60, 42, 173, 194, 156, 211, 69, 222, 115, 10, 100, 160, 137, 169, 129, 244, 97, 144, 224, 16, 83, 60, 253, 173, 59, 108, 197, 238, 1, 79 }, new byte[] { 150, 166, 64, 69, 237, 92, 80, 32, 185, 147, 178, 69, 91, 18, 106, 244, 51, 114, 151, 10, 245, 110, 44, 217, 214, 23, 196, 67, 36, 138, 66, 184, 175, 182, 123, 98, 79, 248, 198, 227, 174, 92, 31, 205, 244, 52, 180, 220, 31, 3, 219, 3, 60, 248, 226, 90, 192, 16, 78, 133, 32, 20, 242, 56, 196, 215, 244, 65, 179, 114, 174, 33, 5, 144, 123, 177, 27, 254, 249, 199, 216, 121, 101, 108, 135, 51, 7, 145, 112, 59, 247, 205, 172, 64, 70, 253, 179, 13, 171, 70, 65, 26, 222, 224, 13, 89, 50, 200, 228, 102, 203, 24, 24, 162, 108, 77, 113, 170, 99, 222, 184, 200, 101, 167, 91, 119, 41, 25 } });
        }
    }
}
