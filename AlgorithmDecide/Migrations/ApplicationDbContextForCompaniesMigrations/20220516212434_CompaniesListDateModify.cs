using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlgorithmDecide.Migrations.ApplicationDbContextForCompaniesMigrations
{
    public partial class CompaniesListDateModify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfOrigin",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Data");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfOrigin",
                table: "Companies",
                type: "Data",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
