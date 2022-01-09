using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD.Migrations
{
    public partial class OtherEntities1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SurName",
                table: "Seller",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurName",
                table: "Seller");
        }
    }
}
