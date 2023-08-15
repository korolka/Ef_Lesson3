using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL_V2.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeyWord = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ActionPrice = table.Column<double>(type: "float", nullable: false),
                    DescriptionField1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionField2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cart_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cart_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KeyLink",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    KeyWordsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KeyLink_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KeyLink_Words_KeyWordsId",
                        column: x => x.KeyWordsId,
                        principalTable: "Words",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Icon", "Name" },
                values: new object[,]
                {
                    { 1, "https://cdn.samsungshop.com.ua/products/7699/cover/133269/SM-A346_Galaxy-A34-5G_Awesome-Graphite_Front2.png", "Smartphone" },
                    { 2, "https://img.freepik.com/premium-vector/smiling-red-car-cartoon-white_29190-4845.jpg", "Car" },
                    { 3, "https://etno-shop.ru/upload/iblock/d3a/s1200.jpg", "Kettle" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Login", "Name", "Password" },
                values: new object[,]
                {
                    { 1, "SobakaBarabaka@gmail.com", "HorseInPalto", "Vlad", "qwerty" },
                    { 2, "Gyci2021@gmail.com", "Gyci", "Andrew", "ytrewq" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Header", "KeyWord" },
                values: new object[,]
                {
                    { 1, "iditional Info", "Gadget" },
                    { 2, "Model", "6s" },
                    { 3, "Model", "Pro 13" },
                    { 4, "Model", "H 1.6" },
                    { 5, "Model", "1.8 tsi" },
                    { 6, "Model", "TWK3P420" },
                    { 7, "name", "HENDI" },
                    { 8, "name", "Profi Cook" },
                    { 9, "Model", "PC-HWS 1168" },
                    { 10, "color", "Color:Чорний" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "ActionPrice", "CategoryId", "DescriptionField1", "DescriptionField2", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 9500.0, 1, "Modern phone. This item was designed in 2016", "It has 8 mp camera", "https://support.apple.com/library/APPLE/APPLECARE_ALLGEOS/SP726/SP726-iphone6s-gray-select-2015.png", "Iphone", 10000.0 },
                    { 2, 550000.0, 1, "New Computer for all", "a lot of features", "https://ilounge.ua/files/articles/macbook-pro-2021-promo.jpg", "MacBook", 50000.0 },
                    { 3, 4500.0, 2, "Very comfortable car for family", "5 doors", "https://i.infocar.ua/i/12/187/1400x936.jpg", "Opel Astra", 100000.0 },
                    { 4, 10000.0, 2, "Big sedan for family", "have very strong engine", "https://cdn.motor1.com/images/mgl/JYjbJ/s1/4x3/2019-volkswagen-jetta-gli-live.webp", "Volkswagen Jetta", 15000.0 },
                    { 5, 1499.0, 3, "Шкала рівня води\r\nЗі шкалою\r\nЗахист\r\nВимкнення при знятті з бази\r\nВід перегріву\r\nВід увімкнення без води", "Тип нагрівального елемента\r\nПрихований (диск)\r\nТип\r\nЗвичайний\r\n", "https://content.rozetka.com.ua/goods/images/big/18592642.jpg", "Електрочайник BOSCH", 1799.0 },
                    { 6, 12285.0, 3, "Шкала рівня води\r\nЗі шкалою\r\nТип нагрівального елемента\r\nПрихований (диск)", "Тип\r\nМашина для заварювання", "https://content2.rozetka.com.ua/goods/images/big/13239860.jpg", "Машина для заварювання", 12285.0 },
                    { 7, 3999.0, 3, "Тип нагрівального елемента\r\nПрихований (диск)", "Тип\r\nДиспенсер-нагрівач води", "Тип\r\nДиспенсер-нагрівач води", "Диспенсер-нагрівач води", 4900.0 }
                });

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "ID", "ProductId", "UserId" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 2, 3, 1 },
                    { 3, 4, 2 },
                    { 4, 5, 1 },
                    { 5, 6, 1 },
                    { 6, 1, 2 },
                    { 7, 7, 2 }
                });

            migrationBuilder.InsertData(
                table: "KeyLink",
                columns: new[] { "Id", "KeyWordsId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 2 },
                    { 4, 4, 3 },
                    { 5, 5, 4 },
                    { 6, 6, 5 },
                    { 7, 7, 6 },
                    { 8, 8, 7 },
                    { 9, 9, 7 },
                    { 10, 10, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_ProductId",
                table: "Cart",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserId",
                table: "Cart",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyLink_KeyWordsId",
                table: "KeyLink",
                column: "KeyWordsId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyLink_ProductId",
                table: "KeyLink",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "KeyLink");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Words");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
