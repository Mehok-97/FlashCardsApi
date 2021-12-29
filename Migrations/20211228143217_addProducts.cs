using Microsoft.EntityFrameworkCore.Migrations;
#nullable disable

namespace FlashCardsApi.Migrations
{
    public partial class addProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.Sql("INSERT INTO Products VALUES('House','المنزل',CURRENT_TIMESTAMP,DATEADD(second,10,CURRENT_TIMESTAMP),10,450.5,2)");
    	    migrationBuilder.Sql("INSERT INTO Products VALUES('Mobile','الهاتف',CURRENT_TIMESTAMP,DATEADD(second,20,CURRENT_TIMESTAMP),10,120,3)");
            migrationBuilder.Sql("INSERT INTO Products VALUES('DataEntry','إدخال بيانات',CURRENT_TIMESTAMP,DATEADD(second,30,CURRENT_TIMESTAMP),10,0,1)");
            migrationBuilder.Sql("INSERT INTO Products VALUES('Bicycle','دراجة هوائية',CURRENT_TIMESTAMP,DATEADD(second,40,CURRENT_TIMESTAMP),10,40.5,4)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
