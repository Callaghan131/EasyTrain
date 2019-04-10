using Microsoft.EntityFrameworkCore.Migrations;

namespace gabrielli.gianmarco._5i.EasyTrain.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "films",
                columns: table => new
                {
                    Filmid = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titolo = table.Column<string>(nullable: true),
                    Durata = table.Column<int>(nullable: false),
                    AnnoProduzione = table.Column<int>(nullable: false),
                    Genere = table.Column<int>(nullable: false),
                    BreveTrama = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_films", x => x.Filmid);
                });

            migrationBuilder.CreateTable(
                name: "utenti",
                columns: table => new
                {
                    Utenteid = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Cognome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_utenti", x => x.Utenteid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "films");

            migrationBuilder.DropTable(
                name: "utenti");
        }
    }
}
