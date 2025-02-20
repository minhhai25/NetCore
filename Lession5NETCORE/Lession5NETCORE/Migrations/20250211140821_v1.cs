using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lession5NETCORE.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORY",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NOTE = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CATEGORY__3214EC272362531C", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ODERS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODE = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    TOTAL_PRICE = table.Column<double>(type: "float", nullable: true),
                    NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PHONE = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ADDRESS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ODERS__3214EC271743E051", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NOTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRICE = table.Column<double>(type: "float", nullable: true),
                    IMAGES = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CATEGORY_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PRODUCT__3214EC27FD32EFEF", x => x.ID);
                    table.ForeignKey(
                        name: "FK__PRODUCT__CATEGOR__398D8EEE",
                        column: x => x.CATEGORY_ID,
                        principalTable: "CATEGORY",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ORDER_DETAIL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ODERS_ID = table.Column<int>(type: "int", nullable: true),
                    PRODUCT_ID = table.Column<int>(type: "int", nullable: true),
                    QUANTITY = table.Column<int>(type: "int", nullable: true),
                    PRICE = table.Column<double>(type: "float", nullable: true),
                    TOTAL_PRICE = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ORDER_DE__3214EC278A761570", x => x.ID);
                    table.ForeignKey(
                        name: "FK__ORDER_DET__ODERS__3E52440B",
                        column: x => x.ODERS_ID,
                        principalTable: "ODERS",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__ORDER_DET__PRODU__3F466844",
                        column: x => x.PRODUCT_ID,
                        principalTable: "PRODUCT",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_DETAIL_ODERS_ID",
                table: "ORDER_DETAIL",
                column: "ODERS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_DETAIL_PRODUCT_ID",
                table: "ORDER_DETAIL",
                column: "PRODUCT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_CATEGORY_ID",
                table: "PRODUCT",
                column: "CATEGORY_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ORDER_DETAIL");

            migrationBuilder.DropTable(
                name: "ODERS");

            migrationBuilder.DropTable(
                name: "PRODUCT");

            migrationBuilder.DropTable(
                name: "CATEGORY");
        }
    }
}
