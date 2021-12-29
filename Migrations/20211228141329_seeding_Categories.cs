using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlashCardsApi.Migrations
{
    public partial class seeding_Categories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
                        migrationBuilder.Sql("INSERT INTO Categories VALUES('Work')");
            migrationBuilder.Sql("INSERT INTO Categories VALUES('House')");
            migrationBuilder.Sql("INSERT INTO Categories VALUES('Technology')");
            migrationBuilder.Sql("INSERT INTO Categories VALUES('Vehicals')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
