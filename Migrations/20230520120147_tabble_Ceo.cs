using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace btlnhom09.Migrations
{
    /// <inheritdoc />
    public partial class tabbleCeo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CeoViTri",
                columns: table => new
                {
                    ViTriCeoID = table.Column<string>(type: "TEXT", nullable: false),
                    VitriCeo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CeoViTri", x => x.ViTriCeoID);
                });

            migrationBuilder.CreateTable(
                name: "Ceo",
                columns: table => new
                {
                    CeoID = table.Column<string>(type: "TEXT", nullable: false),
                    CeoName = table.Column<string>(type: "TEXT", nullable: false),
                    CeoPhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    CeoAddress = table.Column<string>(type: "TEXT", nullable: false),
                    CeoBirth = table.Column<string>(type: "TEXT", nullable: false),
                    CeoSex = table.Column<string>(type: "TEXT", nullable: false),
                    CeoBank = table.Column<string>(type: "TEXT", nullable: false),
                    CeoCCCD = table.Column<string>(type: "TEXT", nullable: false),
                    ViTriCeoID = table.Column<string>(type: "TEXT", nullable: false),
                    LuongID = table.Column<string>(type: "TEXT", nullable: false),
                    HopDongID = table.Column<string>(type: "TEXT", nullable: false),
                    CeoStart = table.Column<string>(type: "TEXT", nullable: false),
                    CeoEnd = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ceo", x => x.CeoID);
                    table.ForeignKey(
                        name: "FK_Ceo_CeoViTri_ViTriCeoID",
                        column: x => x.ViTriCeoID,
                        principalTable: "CeoViTri",
                        principalColumn: "ViTriCeoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ceo_HopDong_HopDongID",
                        column: x => x.HopDongID,
                        principalTable: "HopDong",
                        principalColumn: "HopDongID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ceo_Luong_LuongID",
                        column: x => x.LuongID,
                        principalTable: "Luong",
                        principalColumn: "LuongID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ceo_HopDongID",
                table: "Ceo",
                column: "HopDongID");

            migrationBuilder.CreateIndex(
                name: "IX_Ceo_LuongID",
                table: "Ceo",
                column: "LuongID");

            migrationBuilder.CreateIndex(
                name: "IX_Ceo_ViTriCeoID",
                table: "Ceo",
                column: "ViTriCeoID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ceo");

            migrationBuilder.DropTable(
                name: "CeoViTri");
        }
    }
}
