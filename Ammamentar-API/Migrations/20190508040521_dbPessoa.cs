using Microsoft.EntityFrameworkCore.Migrations;

namespace Ammamentar.API.Migrations
{
    public partial class dbPessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    PessoaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    senha = table.Column<string>(nullable: true),
                    cpf = table.Column<string>(nullable: true),
                    rg = table.Column<string>(nullable: true),
                    endereco = table.Column<string>(nullable: true),
                    rua = table.Column<string>(nullable: true),
                    numero = table.Column<string>(nullable: true),
                    telefone = table.Column<string>(nullable: true),
                    celular = table.Column<string>(nullable: true),
                    registroAtivo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.PessoaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
