using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITHS_DB_Lab4.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnvändareT",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Namn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnvändareT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UtrustT",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Utrustning = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtrustT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ÖvningarT",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Övningensnamn = table.Column<string>(nullable: true),
                    Repetitioner = table.Column<int>(nullable: false),
                    Sets = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ÖvningarT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TräningspassT",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Passnamn = table.Column<string>(nullable: true),
                    Beskrivning = table.Column<string>(nullable: true),
                    Tid = table.Column<string>(nullable: true),
                    Typ = table.Column<string>(nullable: true),
                    AnvändareID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TräningspassT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TräningspassT_AnvändareT_AnvändareID",
                        column: x => x.AnvändareID,
                        principalTable: "AnvändareT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TräningsUtrustningT",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TräningsPassID = table.Column<int>(nullable: true),
                    UtrustningID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TräningsUtrustningT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TräningsUtrustningT_TräningspassT_TräningsPassID",
                        column: x => x.TräningsPassID,
                        principalTable: "TräningspassT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TräningsUtrustningT_UtrustT_UtrustningID",
                        column: x => x.UtrustningID,
                        principalTable: "UtrustT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ÖvningDetalj",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JobbighetsNivå = table.Column<int>(nullable: false),
                    TräningsPassID = table.Column<int>(nullable: true),
                    ÖvningarID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ÖvningDetalj", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ÖvningDetalj_TräningspassT_TräningsPassID",
                        column: x => x.TräningsPassID,
                        principalTable: "TräningspassT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ÖvningDetalj_ÖvningarT_ÖvningarID",
                        column: x => x.ÖvningarID,
                        principalTable: "ÖvningarT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TräningspassT_AnvändareID",
                table: "TräningspassT",
                column: "AnvändareID");

            migrationBuilder.CreateIndex(
                name: "IX_TräningsUtrustningT_TräningsPassID",
                table: "TräningsUtrustningT",
                column: "TräningsPassID");

            migrationBuilder.CreateIndex(
                name: "IX_TräningsUtrustningT_UtrustningID",
                table: "TräningsUtrustningT",
                column: "UtrustningID");

            migrationBuilder.CreateIndex(
                name: "IX_ÖvningDetalj_TräningsPassID",
                table: "ÖvningDetalj",
                column: "TräningsPassID");

            migrationBuilder.CreateIndex(
                name: "IX_ÖvningDetalj_ÖvningarID",
                table: "ÖvningDetalj",
                column: "ÖvningarID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TräningsUtrustningT");

            migrationBuilder.DropTable(
                name: "ÖvningDetalj");

            migrationBuilder.DropTable(
                name: "UtrustT");

            migrationBuilder.DropTable(
                name: "TräningspassT");

            migrationBuilder.DropTable(
                name: "ÖvningarT");

            migrationBuilder.DropTable(
                name: "AnvändareT");
        }
    }
}
