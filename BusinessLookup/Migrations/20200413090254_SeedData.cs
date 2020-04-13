using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessLookup.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Description", "Established", "Name", "Owner" },
                values: new object[,]
                {
                    { 1, "We sell tom foolery items.", "2004", "Hooligans", "John" },
                    { 2, "We sell golfing equipment and more.", "1993", "Golf N Stuff", "Ernesto" },
                    { 3, "We sell the latest tech cell phones.", "2007", "Phones and More", "George" },
                    { 4, "We sell the gnarliest surfboards.", "1978", "Surfboards R Us", "Andy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4);
        }
    }
}
