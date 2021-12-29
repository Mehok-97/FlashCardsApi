using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlashCardsApi.Migrations
{
    public partial class CustomDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Details VALUES('Size','250',6)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('Old','25',6)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('Rooms','4',6)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('Site','Syria',6)");


            migrationBuilder.Sql("INSERT INTO Details VALUES('Kind','Samsung',7)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('OS','Andoid.11',7)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('Color','Brown',7)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('Cameras','3',7)");


            migrationBuilder.Sql("INSERT INTO Details VALUES('Hours','8',8)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('Type','FullTime',8)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('Vaccations','11',8)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('Team','Yes',8)");



            migrationBuilder.Sql("INSERT INTO Details VALUES('Color','Yellow',9)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('Material','Iron',9)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('Extras','Helmet',9)");
            

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
