using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTL06.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Kho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kho",
                columns: table => new
                {
                    KhoID = table.Column<string>(type: "TEXT", nullable: false),
                    SanPhamName = table.Column<string>(type: "TEXT", nullable: false),
                    NumberKho = table.Column<string>(type: "TEXT", nullable: false),
                    KhoStoreExists = table.Column<string>(type: "TEXT", nullable: false),
                    ExportKho = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kho", x => x.KhoID);
                    table.ForeignKey(
                        name: "FK_Kho_SanPham_SanPhamName",
                        column: x => x.SanPhamName,
                        principalTable: "SanPham",
                        principalColumn: "SanPhamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kho_SanPhamName",
                table: "Kho",
                column: "SanPhamName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kho");
        }
    }
}
