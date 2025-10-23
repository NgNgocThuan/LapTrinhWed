using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NntDay09LabCF.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nnt_LoaiSanPham",
                columns: table => new
                {
                    nntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nntMaLoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    nntTenLoai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nnt_LoaiSanPham", x => x.nntId);
                });

            migrationBuilder.CreateTable(
                name: "Nnt_SanPham",
                columns: table => new
                {
                    nntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nntMaSanPham = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    nntTenSanPham = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    nntHinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nntSoLuong = table.Column<int>(type: "int", nullable: false),
                    nntDonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    nntMaLoai = table.Column<string>(type: "nvarchar(10)", maxLength: 500, nullable: false),
                    nntTrangThai = table.Column<bool>(type: "bit", nullable: false),
                    Nnt_LoaiSanPhamnntId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nnt_SanPham", x => x.nntId);
                    table.ForeignKey(
                        name: "FK_Nnt_SanPham_Nnt_LoaiSanPham_Nnt_LoaiSanPhamnntId",
                        column: x => x.Nnt_LoaiSanPhamnntId,
                        principalTable: "Nnt_LoaiSanPham",
                        principalColumn: "nntId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nnt_SanPham_Nnt_LoaiSanPhamnntId",
                table: "Nnt_SanPham",
                column: "Nnt_LoaiSanPhamnntId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nnt_SanPham");

            migrationBuilder.DropTable(
                name: "Nnt_LoaiSanPham");
        }
    }
}
