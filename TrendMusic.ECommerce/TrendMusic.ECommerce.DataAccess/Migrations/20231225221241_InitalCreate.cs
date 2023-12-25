using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrendMusic.ECommerce.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDemoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductFullPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransactionsHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    TransactionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionsHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransactionsHistory_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Amount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, 0m, "7fe57a83-029a-4124-8d99-df889efdd97b", "NesetErtas@gmail.com", false, false, null, null, "NesetErtas", "AQAAAAIAAYagAAAAELcmvpgFlvC9gOKoxmoA8l36nMtYwlAohvZWnBfuFVIzmJODVllSIHB3Nj1IipO7vA==", "+90 555 44 33 22", false, null, false, "Neşet Ertaş" },
                    { 2, 0, 0m, "2b1ad390-5d88-4b94-93fe-c4c29443d150", "berkayakar@gmail.com", false, false, null, null, "BerkayAkar", "AQAAAAIAAYagAAAAECsNZf9HqVgxxrkO23IRnbOWEpxCrizAb6XZOzyPR/6P80LyjpIOhp/jhwp6vIopYQ==", "+90 534 541 34 10", false, null, false, "Berkay Akar" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "IsActive", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Blues", new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8033), true, new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8033) },
                    { 2, "Klasik Müzik", new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8035), true, new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8037) },
                    { 3, "Halk Müzikleri", new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8038), true, new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8039) },
                    { 4, "Elektronik Müzik", new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8040), true, new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8041) },
                    { 5, "Hip - Hop", new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8042), true, new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8043) },
                    { 6, "Cazz ", new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8044), true, new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8044) },
                    { 7, "Pop ", new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8045), true, new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8045) },
                    { 8, "Rock", new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8046), true, new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8047) },
                    { 9, "Çocuk Müzikleri ", new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8048), true, new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8048) },
                    { 10, "Dini Müzik Türleri", new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8049), true, new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8050) },
                    { 11, "Enstrümantal", new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8051), true, new DateTime(2023, 12, 26, 1, 12, 41, 509, DateTimeKind.Local).AddTicks(8051) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AppUserId", "CreatedDate", "IsActive", "ProductDemoPath", "ProductDescription", "ProductFullPath", "ProductImageUrl", "ProductName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(544), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "https://upload.wikimedia.org/wikipedia/tr/7/7f/Bomba_Plak.jpg", "BombaPlak", new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(545) },
                    { 2, 1, new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(548), true, "demopath1", "Massaka Syndikat Album", "Fullpath1", "https://scontent.fist13-1.fna.fbcdn.net/v/t1.6435-9/45627140_10157205667499026_6559733147800436736_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=c2f564&_nc_ohc=ymRuS6Qp4-YAX8Nnj0n&_nc_ht=scontent.fist13-1.fna&oh=00_AfB-VpCKAUzOsD8v3YPh1DxJeroAmsM8FO5redNH3It59Q&oe=65B10756", "Massaka & Syndikat", new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(548) },
                    { 3, 1, new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(550), true, "demopath1", "Kağıt Kesikleri ", "Fullpath1", "https://i.ytimg.com/vi/MPz_t5yvSGE/maxresdefault.jpg", "Sagopa Kajmer - Bla Bla", new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(550) },
                    { 4, 1, new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(552), true, "demopath1", "defkhan 59 Albüm", "Fullpath1", "https://i.scdn.co/image/ab67616d0000b273ae03d01bd0a03f28f1866593", "Defkhan 59 ", new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(553) },
                    { 5, 1, new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(554), true, "demopath1", "Ceza & Sagopa Neyim Varki Rapten Gayri ?  ", "Fullpath1", "https://img-s1.onedio.com/id-5cb6fe1f4d1e71621e1d9a9c/rev-0/w-600/h-337/f-jpg/s-a82b6fe62bb77271306dcd2871379b57eb120bf8.jpg", "Sagopa Kajmer ", new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(555) },
                    { 6, 1, new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(556), true, "demopath1", "Fucs Huzur N'Darem ", "Fullpath1", "https://i.ytimg.com/vi/KIfSEYLQqGk/hqdefault.jpg", "Fuchs & Huzur Nedarem", new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(556) },
                    { 7, 1, new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(558), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Fuat_Ergin.jpg/330px-Fuat_Ergin.jpg", "Fuat Ergin & Suvariler ", new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(558) }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "IsActive", "ProductId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(324), true, 1, new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(323) },
                    { 2, 1, new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(326), true, 2, new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(326) },
                    { 3, 2, new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(328), true, 3, new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(328) },
                    { 4, 3, new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(330), true, 4, new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(330) },
                    { 5, 4, new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(332), true, 5, new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(332) },
                    { 6, 5, new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(334), true, 6, new DateTime(2023, 12, 26, 1, 12, 41, 510, DateTimeKind.Local).AddTicks(333) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ProductId",
                table: "ProductCategories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_AppUserId",
                table: "Products",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionsHistory_AppUserId",
                table: "TransactionsHistory",
                column: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "TransactionsHistory");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
