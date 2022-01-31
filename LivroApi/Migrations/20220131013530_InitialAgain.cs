using Microsoft.EntityFrameworkCore.Migrations;

namespace LivroApi.Migrations
{
    public partial class InitialAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Preco = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Categoria = table.Column<string>(type: "varchar(30)", nullable: false),
                    Img = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livro");
        }
    }
}
