using Microsoft.EntityFrameworkCore.Migrations;

namespace AlgorithmDecide.Migrations
{
    public partial class InsuranceColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeInsuranceId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Insurance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PercentageTax = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeInsuranceId",
                table: "Employees",
                column: "EmployeeInsuranceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Insurance_EmployeeInsuranceId",
                table: "Employees",
                column: "EmployeeInsuranceId",
                principalTable: "Insurance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Insurance_EmployeeInsuranceId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Insurance");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeeInsuranceId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeInsuranceId",
                table: "Employees");
        }
    }
}
