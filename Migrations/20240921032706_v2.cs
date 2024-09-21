using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coink_api.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Towns_DepartmentId",
                table: "Towns",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CountryId",
                table: "Departments",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Countries_CountryId",
                table: "Departments",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Towns_Departments_DepartmentId",
                table: "Towns",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Countries_CountryId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Towns_Departments_DepartmentId",
                table: "Towns");

            migrationBuilder.DropIndex(
                name: "IX_Towns_DepartmentId",
                table: "Towns");

            migrationBuilder.DropIndex(
                name: "IX_Departments_CountryId",
                table: "Departments");
        }
    }
}
