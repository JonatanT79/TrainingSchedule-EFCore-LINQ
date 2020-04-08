using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITHS_DB_Lab4.Migrations
{
    public partial class CreateEntityModel : Migration
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
                name: "JobbinivåT",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JobbighetsNivå = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobbinivåT", x => x.ID);
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
                    Typ = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TräningspassT", x => x.ID);
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
                name: "FullständigtPassT",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnvändareID = table.Column<int>(nullable: true),
                    TräningsPassID = table.Column<int>(nullable: true),
                    ÖvningarID = table.Column<int>(nullable: true),
                    UtrustningID = table.Column<int>(nullable: true),
                    JobbighetsnivåID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FullständigtPassT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FullständigtPassT_AnvändareT_AnvändareID",
                        column: x => x.AnvändareID,
                        principalTable: "AnvändareT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FullständigtPassT_JobbinivåT_JobbighetsnivåID",
                        column: x => x.JobbighetsnivåID,
                        principalTable: "JobbinivåT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FullständigtPassT_TräningspassT_TräningsPassID",
                        column: x => x.TräningsPassID,
                        principalTable: "TräningspassT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FullständigtPassT_UtrustT_UtrustningID",
                        column: x => x.UtrustningID,
                        principalTable: "UtrustT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FullständigtPassT_ÖvningarT_ÖvningarID",
                        column: x => x.ÖvningarID,
                        principalTable: "ÖvningarT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FullständigtPassT_AnvändareID",
                table: "FullständigtPassT",
                column: "AnvändareID");

            migrationBuilder.CreateIndex(
                name: "IX_FullständigtPassT_JobbighetsnivåID",
                table: "FullständigtPassT",
                column: "JobbighetsnivåID");

            migrationBuilder.CreateIndex(
                name: "IX_FullständigtPassT_TräningsPassID",
                table: "FullständigtPassT",
                column: "TräningsPassID");

            migrationBuilder.CreateIndex(
                name: "IX_FullständigtPassT_UtrustningID",
                table: "FullständigtPassT",
                column: "UtrustningID");

            migrationBuilder.CreateIndex(
                name: "IX_FullständigtPassT_ÖvningarID",
                table: "FullständigtPassT",
                column: "ÖvningarID");
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FullständigtPassT");

            migrationBuilder.DropTable(
                name: "AnvändareT");

            migrationBuilder.DropTable(
                name: "JobbinivåT");

            migrationBuilder.DropTable(
                name: "TräningspassT");

            migrationBuilder.DropTable(
                name: "UtrustT");

            migrationBuilder.DropTable(
                name: "ÖvningarT");
        }
    }
}
