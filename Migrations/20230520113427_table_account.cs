using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace btlnhom09.Migrations
{
    /// <inheritdoc />
    public partial class tableaccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountViTri",
                columns: table => new
                {
                    ViTriAccountID = table.Column<string>(type: "TEXT", nullable: false),
                    VitriAccount = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountViTri", x => x.ViTriAccountID);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountID = table.Column<string>(type: "TEXT", nullable: false),
                    AccountName = table.Column<string>(type: "TEXT", nullable: false),
                    AccountPhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    AccountAddress = table.Column<string>(type: "TEXT", nullable: false),
                    AccountBirth = table.Column<string>(type: "TEXT", nullable: false),
                    AccountSex = table.Column<string>(type: "TEXT", nullable: false),
                    AccountBank = table.Column<string>(type: "TEXT", nullable: false),
                    AccountCCCD = table.Column<string>(type: "TEXT", nullable: false),
                    ViTriAccountID = table.Column<string>(type: "TEXT", nullable: false),
                    LuongID = table.Column<string>(type: "TEXT", nullable: false),
                    HopDongID = table.Column<string>(type: "TEXT", nullable: false),
                    AccountStart = table.Column<string>(type: "TEXT", nullable: false),
                    AccountEnd = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountID);
                    table.ForeignKey(
                        name: "FK_Account_AccountViTri_ViTriAccountID",
                        column: x => x.ViTriAccountID,
                        principalTable: "AccountViTri",
                        principalColumn: "ViTriAccountID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Account_HopDong_HopDongID",
                        column: x => x.HopDongID,
                        principalTable: "HopDong",
                        principalColumn: "HopDongID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Account_Luong_LuongID",
                        column: x => x.LuongID,
                        principalTable: "Luong",
                        principalColumn: "LuongID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_HopDongID",
                table: "Account",
                column: "HopDongID");

            migrationBuilder.CreateIndex(
                name: "IX_Account_LuongID",
                table: "Account",
                column: "LuongID");

            migrationBuilder.CreateIndex(
                name: "IX_Account_ViTriAccountID",
                table: "Account",
                column: "ViTriAccountID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "AccountViTri");
        }
    }
}
