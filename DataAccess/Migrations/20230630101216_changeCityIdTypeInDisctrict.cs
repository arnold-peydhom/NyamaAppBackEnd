using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class changeCityIdTypeInDisctrict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_District_City_CityId1",
                table: "District");

            migrationBuilder.DropIndex(
                name: "IX_District_CityId1",
                table: "District");

            migrationBuilder.DropColumn(
                name: "CityId1",
                table: "District");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "District",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_District_CityId",
                table: "District",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_District_City_CityId",
                table: "District",
                column: "CityId",
                principalTable: "City",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_District_City_CityId",
                table: "District");

            migrationBuilder.DropIndex(
                name: "IX_District_CityId",
                table: "District");

            migrationBuilder.AlterColumn<string>(
                name: "CityId",
                table: "District",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CityId1",
                table: "District",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_District_CityId1",
                table: "District",
                column: "CityId1");

            migrationBuilder.AddForeignKey(
                name: "FK_District_City_CityId1",
                table: "District",
                column: "CityId1",
                principalTable: "City",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
