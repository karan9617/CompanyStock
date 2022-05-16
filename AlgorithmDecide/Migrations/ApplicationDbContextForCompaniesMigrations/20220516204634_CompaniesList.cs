using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlgorithmDecide.Migrations.ApplicationDbContextForCompaniesMigrations
{
    public partial class CompaniesList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockPrice = table.Column<float>(type: "real", nullable: false),
                    Evalutation = table.Column<float>(type: "real", nullable: false),
                    DateOfOrigin = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
