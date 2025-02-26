using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GeekShooping.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductDataTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "Educação", "Curso para aperfeiçoamento do desenvolvimento de aplicações Web, com HTML, CSS e Javascript", "https://github.com/tavinlima/SPODWE1/blob/main/src/img/meta_img.png?raw=true", "Curso de desenvolvimento Web II", 29.9m },
                    { 3L, "Educação", "Curso para aperfeiçoamento do desenvolvimento de aplicações Web, com HTML, CSS e Javascript", "https://github.com/tavinlima/SPODWE1/blob/main/src/img/meta_img.png?raw=true", "Curso de desenvolvimento Web III", 59.9m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);
        }
    }
}
