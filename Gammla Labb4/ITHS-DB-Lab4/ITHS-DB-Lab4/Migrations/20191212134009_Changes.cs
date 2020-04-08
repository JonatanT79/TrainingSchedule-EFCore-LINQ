using Microsoft.EntityFrameworkCore.Migrations;

namespace ITHS_DB_Lab4.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<string>(
                name: "Övningensnamn",
                table: "ÖvningarT",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Utrustning",
                table: "UtrustT",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Passnamn",
                table: "TräningspassT",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "JobbighetsnivåID",
                table: "FullständigtPassT",
                nullable: true,
                defaultValue: 5,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Förnamn",
                table: "AnvändareT",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Efternamn",
                table: "AnvändareT",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
              name: "Email",
              table: "AnvändareT",
              nullable: true);

            migrationBuilder.Sql(
                @"UPDATE AnvändareT 
                SET Förnamn = Substring(Namn,1,(CharIndex(' ', Namn) - 1)),
                Efternamn = Substring(Namn, (CharIndex(' ', Namn ) + 1), Len(Namn))");

            migrationBuilder.DropColumn(
                name: "Namn",
                table: "AnvändareT");
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Efternamn",
                table: "AnvändareT");

            migrationBuilder.DropColumn(
                name: "Förnamn",
                table: "AnvändareT");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "AnvändareT");

            migrationBuilder.AddColumn<string>(
                name: "Namn",
                table: "AnvändareT");

            migrationBuilder.AlterColumn<string>(
                name: "Övningensnamn",
                table: "ÖvningarT",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Utrustning",
                table: "UtrustT",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Passnamn",
                table: "TräningspassT",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "JobbighetsnivåID",
                table: "FullständigtPassT",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true,
                oldDefaultValue: 5);
        }
    }
}