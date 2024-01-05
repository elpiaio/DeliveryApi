using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliveryApi.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StoreId",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_StoreId",
                table: "Produtos",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Stores_StoreId",
                table: "Produtos",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Stores_StoreId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_StoreId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Produtos");
        }
    }
}
