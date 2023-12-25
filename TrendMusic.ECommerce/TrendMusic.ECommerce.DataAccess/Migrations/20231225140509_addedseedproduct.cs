using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrendMusic.ECommerce.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedseedproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "a6dffff8-f82e-4810-aa0f-40e27c551fdf", "NesetErtas@gmail.com", false, false, null, null, "NesetErtas", "AQAAAAIAAYagAAAAEEQLxxmv1E4TFQTU1MQXf3EI7HsAT9CmfvTuaFdOJDRedkHx7M4aJW+uQUmk60kKfQ==", "+90 555 44 33 22", false, null, false, "Neşet Ertaş" },
                    { 2, 0, "90fbfa52-1c9c-41bd-8835-c8872b0cacf0", "berkayakar@gmail.com", false, false, null, null, "BerkayAkar", "AQAAAAIAAYagAAAAEFRdrA3gELreAwIC3oRvwHE4+UbXDfV36R7svTC/wBodtvOivlZWv5UrmVCfoJ0tOw==", "+90 534 541 34 10", false, null, false, "Berkay Akar" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7961), new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7963), new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7965), new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7967), new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7969), new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7970), new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7971), new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7973), new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7974), new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7976), new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7977), new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7979), new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AppUserId", "CreatedDate", "IsActive", "ProductDemoPath", "ProductDescription", "ProductFullPath", "ProductName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8128), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8129) },
                    { 2, 1, new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8131), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8131) },
                    { 3, 1, new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8133), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8133) },
                    { 4, 1, new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8134), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8135) },
                    { 5, 1, new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8136), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8137) },
                    { 6, 1, new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8138), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8138) },
                    { 7, 1, new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8140), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8140) },
                    { 8, 1, new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8142), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8142) },
                    { 9, 1, new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8143), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8144) },
                    { 10, 1, new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8145), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8146) },
                    { 11, 1, new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8147), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8147) },
                    { 12, 1, new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8149), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8149) },
                    { 13, 1, new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8150), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8151) },
                    { 14, 1, new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8152), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8153) },
                    { 15, 1, new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8154), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8154) },
                    { 16, 1, new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8156), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8156) },
                    { 17, 1, new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8158), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8158) },
                    { 18, 1, new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8159), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8160) },
                    { 19, 1, new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8161), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8162) },
                    { 20, 1, new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8163), true, "demopath1", "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "Fullpath1", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8163) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(900), new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(903), new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(905), new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(906), new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(907) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(908), new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(908) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(909), new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(910), new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(912), new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(913), new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(914) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(915), new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(916), new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(918), new DateTime(2023, 12, 24, 23, 31, 41, 318, DateTimeKind.Local).AddTicks(918) });
        }
    }
}
