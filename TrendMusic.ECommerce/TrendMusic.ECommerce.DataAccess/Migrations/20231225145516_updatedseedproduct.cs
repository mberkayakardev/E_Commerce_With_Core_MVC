using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrendMusic.ECommerce.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updatedseedproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "ProductImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0728d577-885e-4a3e-b4f6-d273f6d7e2af", "AQAAAAIAAYagAAAAEFFZMDo6kdfqXD0scDzACVIdDTEC0ETy80bZ2JAe5pfp6O5Oiq1mSt8UrW7RPnv5OA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3bdd9785-d15e-49d2-9e06-f2327412d035", "AQAAAAIAAYagAAAAEEmHAOkh3WW6Oz9kqItecPXcVB+bgC66/EWoNGvcYg4U6zQCGqC3Wh02gE7yulrPPw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2134), new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2138), new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2140), new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2142), new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2143), new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2145), new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2146), new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2148), new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2149), new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2150), new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2152), new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2153), new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ProductImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2286), "https://upload.wikimedia.org/wikipedia/tr/7/7f/Bomba_Plak.jpg", new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductDescription", "ProductImageUrl", "ProductName", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2289), "Massaka Syndikat Album", "https://scontent.fist13-1.fna.fbcdn.net/v/t1.6435-9/45627140_10157205667499026_6559733147800436736_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=c2f564&_nc_ohc=ymRuS6Qp4-YAX8Nnj0n&_nc_ht=scontent.fist13-1.fna&oh=00_AfB-VpCKAUzOsD8v3YPh1DxJeroAmsM8FO5redNH3It59Q&oe=65B10756", "Massaka & Syndikat", new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductDescription", "ProductImageUrl", "ProductName", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2292), "Kağıt Kesikleri ", "https://i.ytimg.com/vi/MPz_t5yvSGE/maxresdefault.jpg", "Sagopa Kajmer - Bla Bla", new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductDescription", "ProductImageUrl", "ProductName", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2294), "defkhan 59 Albüm", "https://i.scdn.co/image/ab67616d0000b273ae03d01bd0a03f28f1866593", "Defkhan 59 ", new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductDescription", "ProductImageUrl", "ProductName", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2296), "Ceza & Sagopa Neyim Varki Rapten Gayri ?  ", "https://img-s1.onedio.com/id-5cb6fe1f4d1e71621e1d9a9c/rev-0/w-600/h-337/f-jpg/s-a82b6fe62bb77271306dcd2871379b57eb120bf8.jpg", "Sagopa Kajmer ", new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductDescription", "ProductImageUrl", "ProductName", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2297), "Fucs Huzur N'Darem ", "https://i.ytimg.com/vi/KIfSEYLQqGk/hqdefault.jpg", "Fuchs & Huzur Nedarem", new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductImageUrl", "ProductName", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2299), "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Fuat_Ergin.jpg/330px-Fuat_Ergin.jpg", "Fuat Ergin & Suvariler ", new DateTime(2023, 12, 25, 17, 55, 16, 66, DateTimeKind.Local).AddTicks(2300) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductImageUrl",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a6dffff8-f82e-4810-aa0f-40e27c551fdf", "AQAAAAIAAYagAAAAEEQLxxmv1E4TFQTU1MQXf3EI7HsAT9CmfvTuaFdOJDRedkHx7M4aJW+uQUmk60kKfQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "90fbfa52-1c9c-41bd-8835-c8872b0cacf0", "AQAAAAIAAYagAAAAEFRdrA3gELreAwIC3oRvwHE4+UbXDfV36R7svTC/wBodtvOivlZWv5UrmVCfoJ0tOw==" });

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8128), new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ProductDescription", "ProductName", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8131), "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8131) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ProductDescription", "ProductName", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8133), "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8133) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ProductDescription", "ProductName", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8134), "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ProductDescription", "ProductName", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8136), "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ProductDescription", "ProductName", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8138), "Ceza & Killa Hakan 2009 Efsane Albüm & Düet ", "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ProductName", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8140), "BombaPlak", new DateTime(2023, 12, 25, 17, 5, 8, 999, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AppUserId", "CreatedDate", "IsActive", "ProductDemoPath", "ProductDescription", "ProductFullPath", "ProductName", "UpdatedDate" },
                values: new object[,]
                {
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
    }
}
