using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoDesenvAPI.Data.Migrations
{
    public partial class CriarTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Pessoa",
                columns: table => new
                {
                    IdPessoa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePessoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailPessoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Pessoa", x => x.IdPessoa);
                });

            migrationBuilder.CreateTable(
                name: "tb_Endereco",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Pessoa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Endereco", x => x.IdEndereco);
                    table.ForeignKey(
                        name: "FK_tb_Endereco_tb_Pessoa_Id_Pessoa",
                        column: x => x.Id_Pessoa,
                        principalTable: "tb_Pessoa",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Processo",
                columns: table => new
                {
                    IdProcesso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProcesso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroProcesso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Pessoa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Processo", x => x.IdProcesso);
                    table.ForeignKey(
                        name: "FK_tb_Processo_tb_Pessoa_Id_Pessoa",
                        column: x => x.Id_Pessoa,
                        principalTable: "tb_Pessoa",
                        principalColumn: "IdPessoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Ocorrencia",
                columns: table => new
                {
                    IdOcorrencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeOcorrencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroOcorrencia = table.Column<int>(type: "int", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Processo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Ocorrencia", x => x.IdOcorrencia);
                    table.ForeignKey(
                        name: "FK_tb_Ocorrencia_tb_Processo_Id_Processo",
                        column: x => x.Id_Processo,
                        principalTable: "tb_Processo",
                        principalColumn: "IdProcesso",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Pagamento",
                columns: table => new
                {
                    IdPagamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorHora = table.Column<double>(type: "float", nullable: false),
                    QtdeProcesso = table.Column<int>(type: "int", nullable: false),
                    Id_Ocorrencia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Pagamento", x => x.IdPagamento);
                    table.ForeignKey(
                        name: "FK_tb_Pagamento_tb_Ocorrencia_Id_Ocorrencia",
                        column: x => x.Id_Ocorrencia,
                        principalTable: "tb_Ocorrencia",
                        principalColumn: "IdOcorrencia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Endereco_Id_Pessoa",
                table: "tb_Endereco",
                column: "Id_Pessoa");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Ocorrencia_Id_Processo",
                table: "tb_Ocorrencia",
                column: "Id_Processo");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Pagamento_Id_Ocorrencia",
                table: "tb_Pagamento",
                column: "Id_Ocorrencia");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Processo_Id_Pessoa",
                table: "tb_Processo",
                column: "Id_Pessoa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Endereco");

            migrationBuilder.DropTable(
                name: "tb_Pagamento");

            migrationBuilder.DropTable(
                name: "tb_Ocorrencia");

            migrationBuilder.DropTable(
                name: "tb_Processo");

            migrationBuilder.DropTable(
                name: "tb_Pessoa");
        }
    }
}
