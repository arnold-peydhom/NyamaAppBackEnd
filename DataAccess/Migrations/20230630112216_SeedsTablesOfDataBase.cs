using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class SeedsTablesOfDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Achats" },
                    { 2, "Transport" },
                    { 3, "Deplacement" },
                    { 4, "Salaire" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "Name" },
                values: new object[,]
                {
                    { 1, "Paris" },
                    { 2, "Marseille" },
                    { 3, "Lyon" },
                    { 4, "Toulouse" }
                });

            migrationBuilder.InsertData(
                table: "Unit",
                columns: new[] { "UnitId", "Name" },
                values: new object[,]
                {
                    { 1, "Demi-Sac" },
                    { 2, "Sac" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "DistrictId", "CityId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Le Marais" },
                    { 2, 1, "Montmartre" },
                    { 3, 1, "Saint-Germain-des-Prés" },
                    { 4, 1, "Le Quartier Latin" },
                    { 5, 2, "Le Vieux-Port" },
                    { 6, 2, "Le Panier" },
                    { 7, 2, "Le Cours Julien" },
                    { 8, 2, "La Corniche" },
                    { 9, 3, "Vieux Lyon" },
                    { 10, 3, "Presqu'île" },
                    { 11, 3, "Croix-Rousse" },
                    { 12, 3, "Confluence" },
                    { 13, 4, "Capitole" },
                    { 14, 4, "Saint-Cyprien" },
                    { 15, 4, "Carmes" },
                    { 16, 4, "Saint-Étienne" }
                });

            migrationBuilder.InsertData(
                table: "ExpenseType",
                columns: new[] { "ExpenseTypeId", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Achat - Tapioca" },
                    { 2, 1, "Achat - Arachide" },
                    { 3, 1, "Achat - Sucre" },
                    { 4, 2, "transport - Tapioca" },
                    { 5, 2, "transport - Arachide" },
                    { 6, 2, "transport - Sucre" },
                    { 7, 3, "Déplacement - Prospection" },
                    { 8, 3, " Déplacement - Achat Matières premières" },
                    { 9, 3, "Déplacement - Dépôt en boutique" },
                    { 10, 3, "Déplacement - Envoi de commandes" },
                    { 11, 4, "Salaire - Grillage arachides" },
                    { 12, 4, "Salaire - Dépulpage arachides" },
                    { 13, 4, "Salaire Préparation arachides" },
                    { 14, 4, "Salaire - Séchage tapioca" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "DistrictId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "DistrictId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "DistrictId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "DistrictId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "DistrictId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "DistrictId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "DistrictId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "DistrictId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "DistrictId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "DistrictId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "DistrictId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "DistrictId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "DistrictId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "DistrictId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "DistrictId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "District",
                keyColumn: "DistrictId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ExpenseType",
                keyColumn: "ExpenseTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExpenseType",
                keyColumn: "ExpenseTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExpenseType",
                keyColumn: "ExpenseTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExpenseType",
                keyColumn: "ExpenseTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExpenseType",
                keyColumn: "ExpenseTypeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExpenseType",
                keyColumn: "ExpenseTypeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExpenseType",
                keyColumn: "ExpenseTypeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExpenseType",
                keyColumn: "ExpenseTypeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ExpenseType",
                keyColumn: "ExpenseTypeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ExpenseType",
                keyColumn: "ExpenseTypeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ExpenseType",
                keyColumn: "ExpenseTypeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ExpenseType",
                keyColumn: "ExpenseTypeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ExpenseType",
                keyColumn: "ExpenseTypeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ExpenseType",
                keyColumn: "ExpenseTypeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "UnitId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "UnitId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 4);
        }
    }
}
