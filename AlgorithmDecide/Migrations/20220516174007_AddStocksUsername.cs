using Microsoft.EntityFrameworkCore.Migrations;

namespace AlgorithmDecide.Migrations
{
    public partial class AddStocksUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Stocks",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "Stocks");
        }
    }
}
