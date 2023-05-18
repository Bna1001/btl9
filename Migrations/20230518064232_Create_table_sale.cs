using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace btlnhom09.Migrations
{
    /// <inheritdoc />
    public partial class Createtablesale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sale_SaleViTri_ViTriSaleID",
                table: "Sale");

            migrationBuilder.DropTable(
                name: "SaleViTri");

            migrationBuilder.DropIndex(
                name: "IX_Sale_ViTriSaleID",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "ViTriSaleID",
                table: "Sale");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ViTriSaleID",
                table: "Sale",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "SaleViTri",
                columns: table => new
                {
                    ViTriSaleID = table.Column<string>(type: "TEXT", nullable: false),
                    VitriSale = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleViTri", x => x.ViTriSaleID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sale_ViTriSaleID",
                table: "Sale",
                column: "ViTriSaleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_SaleViTri_ViTriSaleID",
                table: "Sale",
                column: "ViTriSaleID",
                principalTable: "SaleViTri",
                principalColumn: "ViTriSaleID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
