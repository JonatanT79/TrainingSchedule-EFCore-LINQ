using Microsoft.EntityFrameworkCore.Migrations;

namespace ITHS_DB_Lab4.Migrations
{
    public partial class Changes20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Förnamn",
                table: "AnvändareT",
                maxLength: 255,
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Efternamn",
                table: "AnvändareT",
                maxLength: 255,
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<string>(
              name: "Förnamn",
              table: "AnvändareT",
              maxLength: 255,
              nullable: false,
              defaultValue: "");

            migrationBuilder.AlterColumn<string>(
              name: "Efernamn",
              table: "AnvändareT",
              maxLength: 255,
              nullable: false,
              defaultValue: "");
        }
    }
}
