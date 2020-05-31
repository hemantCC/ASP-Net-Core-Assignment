using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticalAssignment.Data.Migrations
{
    public partial class removeRetailerIdInOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Retailer",
                table: "Order");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Retailer",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
