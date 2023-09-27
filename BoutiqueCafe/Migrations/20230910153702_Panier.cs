using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoutiqueCafe.Migrations
{
    public partial class Panier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PanierArticles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduitId = table.Column<int>(type: "int", nullable: true),
                    Quantite = table.Column<int>(type: "int", nullable: false),
                    PanierAchatId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PanierArticles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PanierArticles_Produits_ProduitId",
                        column: x => x.ProduitId,
                        principalTable: "Produits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PanierArticles_ProduitId",
                table: "PanierArticles",
                column: "ProduitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PanierArticles");
        }
    }
}
