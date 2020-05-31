using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticalAssignment.Data.Migrations
{
    public partial class addProductRetailerInProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductRetailer",
                table: "Product",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductRetailer",
                table: "Product");
        }
    }
}
