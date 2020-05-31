using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticalAssignment.Data.Migrations
{
    public partial class addRetailerIdInOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Retailer",
                table: "Order",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Retailer",
                table: "Order");
        }
    }
}
