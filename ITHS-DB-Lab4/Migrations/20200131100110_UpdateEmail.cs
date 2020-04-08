using Microsoft.EntityFrameworkCore.Migrations;

namespace ITHS_DB_Lab4.Migrations
{
    public partial class UpdateEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
               @"UPDATE AnvändareT 
                SET Email = 'Hans.Hansson@gmail.com'
                Where ID = 1");

            migrationBuilder.Sql(
              @"UPDATE AnvändareT 
                SET Email = 'Linn.Andersson@gmail.com'
                Where ID = 2");

            migrationBuilder.Sql(
              @"UPDATE AnvändareT 
                SET Email = 'Mats.Olsson@gmail.com'
                Where ID = 3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
