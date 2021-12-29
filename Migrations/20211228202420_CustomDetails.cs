using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlashCardsApi.Migrations
{
    public partial class CustomDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Details VALUES('Size','250',1)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('Old','25',1)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('Rooms','4',1)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('Site','Syria',1)");


            migrationBuilder.Sql("INSERT INTO Details VALUES('Kind','Samsung',2)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('OS','Andoid.11',2)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('Color','Brown',2)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('Cameras','3',2)");


            migrationBuilder.Sql("INSERT INTO Details VALUES('Hours','8',3)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('Type','FullTime',3)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('Vaccations','11',3)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('Team','Yes',3)");



            migrationBuilder.Sql("INSERT INTO Details VALUES('Color','Yellow',4)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('Material','Iron',4)");
            migrationBuilder.Sql("INSERT INTO Details VALUES('Extras','Helmet',4)");
            

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
