using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YRTJapan.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddGeneralInquiryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ed694d67-aa33-48ec-acd2-a254a292ddbb", "5352564e-8dab-4bd9-a5e7-abcdda219f68" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("64abaee8-e45e-4b66-bd81-f8a76a8a4067"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("711cfc91-ad2c-4774-ad6b-0e01603e587f"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("32f9d3a1-3d51-4ae6-a034-4e8dc68de343"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("81bd144f-6035-4a3d-be25-3c86f5586ed0"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("ed740966-7088-4f17-9022-64092bb80ec1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d518666-9838-4cc8-aa59-f3ad17b26102"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a73320e-d133-4c04-afbe-c245181e3f3e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1e6d02dd-bcc7-402b-bd7b-02e7e5370dbd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3cc10c9c-56c2-4d57-b059-07aebe8284ff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a3f7077-ba03-488d-8c3e-cfd25ce03756"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a9b079c0-b146-4a95-a02a-32401a8d6d4e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aaa2a7c6-4c5f-4a54-a6c1-6e0576de552f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce1f7331-e73b-46e3-a2ff-4cd387678702"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3c4770f-7875-4795-8a66-c609ce6773f8"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed694d67-aa33-48ec-acd2-a254a292ddbb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5352564e-8dab-4bd9-a5e7-abcdda219f68");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc54cbcc-9830-4a61-a65e-a7194b5544b7"));

            migrationBuilder.AddColumn<decimal>(
                name: "FOBPriceInUSD",
                table: "Car",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceInUSD",
                table: "Car",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "GeneralInquiries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralInquiries", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d4288134-369b-4729-9178-9a62a094c844");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "d333a601-f287-4953-b202-9ed1ce73b5df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "919d928e-86b8-45c9-9bc9-5660c6bc5b94");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "c49ec4d2-403e-4a59-9218-d6fcbd6aca75");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "b149e9a1-25ff-4966-b3aa-5ce1a6cf6b05");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", "723c5550-274f-4e47-8d0a-2effee4b2bc5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "CompanyId", "ConcurrencyStamp", "CountryId", "DesignationId", "Email", "EmailConfirmed", "FullName", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName" },
                values: new object[] { "af7add2e-7675-4bff-b9be-34431ac30c2c", 0, null, null, "6dfb5a2a-2992-4eda-8bae-77dd2aab7672", 1, null, "waheedtariq@msn.com", true, "Waheed Tariq", "Male", false, null, "WAHEEDTARIQ@MSN.COM", "WAHEEDTARIQ@MSN.COM", "AQAAAAIAAYagAAAAEPkHtN/n2bvExUiZuCEOI+fO77zlomdVpHSWncRT1MNJsr83wV//G8KRRegXMvvkFA==", null, false, null, "", null, null, false, "waheedtariq@msn.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "DisplayOrder", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("5b222991-2599-4867-b20b-268bce9494df"), new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1253), 2, "Action", new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1255) },
                    { new Guid("b91476d3-ceec-427a-965e-b935798fe431"), new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1175), 1, "Scifi", new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1227) },
                    { new Guid("f42c3890-a4d8-42ed-a43a-9288a4eaf38f"), new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1259), 3, "History", new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1260) }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Created", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress", "Updated" },
                values: new object[,]
                {
                    { new Guid("2e1140fe-9f3f-42b8-8523-68bbf5d0c09a"), "Lala land", new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1361), "Readers Club", "1113335555", "99999", "NY", "999 Main St", new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1363) },
                    { new Guid("4ac43230-2c6b-4933-afa9-6edf3da59bd3"), "Tech City", new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1334), "Tech Solution", "6669990000", "12121", "IL", "123 Tech St", new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1336) },
                    { new Guid("c3c5d5eb-b617-49ee-b75e-a34d0561581d"), "Vid City", new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1344), "Vivid Books", "7779990000", "66666", "IL", "999 Vid St", new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1346) }
                });

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 6, 25, 31, 192, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "af7add2e-7675-4bff-b9be-34431ac30c2c" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Created", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("01668ff8-97d0-427f-8409-fd8dab936099"), "Corey, James S. A.", new Guid("b91476d3-ceec-427a-965e-b935798fe431"), new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1465), "<p>Thirteen hundred gates have opened to solar systems around the galaxy. But as humanity builds its interstellar empire in the alien ruins, the mysteries and threats grow deeper.<br><br>In the dead systems where gates lead to stranger things than alien planets, Elvi Okoye begins a desperate search to discover the nature of a genocide that happened before the first human beings existed, and to find weapons to fight a war against forces at the edge of the imaginable. But the price of that knowledge may be higher than she can pay.<br><br>At the heart of the empire, Teresa Duarte prepares to take on the burden of her father's godlike ambition. The sociopathic scientist Paolo Cort&aacute;zar and the Mephistophelian prisoner James Holden are only two of the dangers in a palace thick with intrigue, but Teresa has a mind of her own and secrets even her father the emperor doesn't guess.<br><br>And throughout the wide human empire, the scattered crew of the Rocinante fights a brave rear-guard action against Duarte's authoritarian regime. Memory of the old order falls away, and a future under Laconia's eternal rule -- and with it, a battle that humanity can only lose - seems more and more certain. Because against the terrors that lie between worlds, courage and ambition will not be enough...</p>", "978-0-316-33286-6", "\\images\\product\\TiamatsWrath.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Tiamat's Wrath", new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1466) },
                    { new Guid("1088e497-a334-45bb-97f2-bea90f69d0a4"), "Corey, James S. A.", new Guid("b91476d3-ceec-427a-965e-b935798fe431"), new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1422), "<p>We are not alone. On Ganymede, breadbasket of the outer planets, a Martian marine watches as her platoon is slaughtered by a monstrous supersoldier. On Earth, a high-level politician struggles to prevent interplanetary war from reigniting. And on Venus, an alien protomolecule has overrun the planet, wreaking massive, mysterious changes and threatening to spread out into the solar system.<br><br>In the vast wilderness of space, James Holden and the crew of the&nbsp;<em>Rocinante</em> have been keeping the peace for the Outer Planets Alliance. When they agree to help a scientist search war-torn Ganymede for a missing child, the future of humanity rests on whether a single ship can prevent an alien invasion that may have already begun.</p>", "978-0-316-12906-0", "\\images\\product\\CalibansWar.jpg", 310000.0, 295000.0, 265000.0, 285000.0, "Caliban's War", new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1424) },
                    { new Guid("1fb49bfe-8715-4ef9-8dff-43c55b9bdc36"), "Corey, James S. A.", new Guid("b91476d3-ceec-427a-965e-b935798fe431"), new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1455), "<p>In the thousand-sun network of humanity's expansion, new colony worlds are struggling to find their way. Every new planet lives on a knife edge between collapse and wonder, and the crew of the aging gunship Rocinante have their hands more than full keeping the fragile peace.<br><br>In the vast space between Earth and Jupiter, the inner planets and belt have formed a tentative and uncertain alliance still haunted by a history of wars and prejudices. On the lost colony world of Laconia, a hidden enemy has a new vision for all of humanity and the power to enforce it.<br><br>New technologies clash with old as the history of human conflict returns to its ancient patterns of war and subjugation. But human nature is not the only enemy, and the forces being unleashed have their own price. A price that will change the shape of humanity -- and of the Rocinante -- unexpectedly and forever...</p>", "978-0-316-33283-5", "\\images\\product\\PersepolisRising.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Persepolis Rising	", new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1457) },
                    { new Guid("4d1c34d9-fd14-401c-aec9-c3c71788c5d6"), "Corey, James S. A.", new Guid("b91476d3-ceec-427a-965e-b935798fe431"), new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1471), "<p>The Laconian Empire has fallen, setting the thirteen hundred solar systems free from the rule of Winston Duarte. But the ancient enemy that killed the gate builders is awake, and the war against our universe has begun again.<br><br>In the dead system of Adro, Elvi Okoye leads a desperate scientific mission to understand what the gate builders were and what destroyed them, even if it means compromising herself and the half-alien children who bear the weight of her investigation. Through the wide-flung systems of humanity, Colonel Aliana Tanaka hunts for Duarte&rsquo;s missing daughter. . . and the shattered emperor himself. And on the Rocinante, James Holden and his crew struggle to build a future for humanity out of the shards and ruins of all that has come before.<br><br>As nearly unimaginable forces prepare to annihilate all human life, Holden and a group of unlikely allies discover a last, desperate chance to unite all of humanity, with the promise of a vast galactic civilization free from wars, factions, lies, and secrets if they win.<br><br>But the price of victory may be worse than the cost of defeat.</p>", "978-0-316-33291-0", "\\images\\product\\LeviathanFalls.jpg", 330000.0, 320000.0, 300000.0, 310000.0, "Leviathan Falls", new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1473) },
                    { new Guid("b4522b8b-f8d8-4040-9e50-1f2b51570cd6"), "Corey, James S. A.", new Guid("b91476d3-ceec-427a-965e-b935798fe431"), new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1429), "<p>Abaddon's Gate is the third book in the New York Times bestselling Expanse series.<br><br>For generations, the solar system - Mars, the Moon, the Asteroid Belt - was humanity's great frontier. Until now. The alien artefact working through its program under the clouds of Venus has emerged to build a massive structure outside the orbit of Uranus: a gate that leads into a starless dark.<br><br>Jim Holden and the crew of the Rocinante are part of a vast flotilla of scientific and military ships going out to examine the artefact. But behind the scenes, a complex plot is unfolding, with the destruction of Holden at its core. As the emissaries of the human race try to find whether the gate is an opportunity or a threat, the greatest danger is the one they brought with them.</p>", "978-0-316-12907-7", "\\images\\product\\AbaddonsGate.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Abaddon's Gate", new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1431) },
                    { new Guid("d0e157ef-a10d-4507-b28d-fe53e3c7ec5b"), "Corey, James S. A.", new Guid("b91476d3-ceec-427a-965e-b935798fe431"), new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1406), "<p>Humanity has colonized the solar system&mdash;Mars, the Moon, the Asteroid Belt and beyond&mdash;but the stars are still out of our reach.<br><br>Jim Holden is XO of an ice miner making runs from the rings of Saturn to the mining stations of the Belt. When he and his crew stumble upon a derelict ship, the&nbsp;<em>Scopuli</em>, they find themselves in possession of a secret they never wanted. A secret that someone is willing to kill for&mdash;and kill on a scale unfathomable to Jim and his crew. War is brewing in the system unless he can find out who left the ship and why.<br><br>Detective Miller is looking for a girl. One girl in a system of billions, but her parents have money and money talks. When the trail leads him to the&nbsp;<em>Scopuli</em>&nbsp;and rebel sympathizer Holden, he realizes that this girl may be the key to everything.<br><br>Holden and Miller must thread the needle between the Earth government, the Outer Planet revolutionaries, and secretive corporations&mdash;and the odds are against them. But out in the Belt, the rules are different, and one small ship can change the fate of the universe.</p>", "978-0-316-12908-4", "\\images\\product\\LeviathanWakes.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Leviathan Wakes", new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1408) },
                    { new Guid("dce7c551-7e2e-46c4-aba8-11e83f68892c"), "Corey, James S. A.", new Guid("b91476d3-ceec-427a-965e-b935798fe431"), new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1442), "<p>The fifth novel in Corey's New York Times bestselling Expanse series--now being produced for television by the SyFy Channel!<br><br>A thousand worlds have opened, and the greatest land rush in human history has begun. As wave after wave of colonists leave, the power structures of the old solar system begin to buckle.<br><br>Ships are disappearing without a trace. Private armies are being secretly formed. The sole remaining protomolecule sample is stolen. Terrorist attacks previously considered impossible bring the inner planets to their knees. The sins of the past are returning to exact a terrible price.<br><br>And as a new human order is struggling to be born in blood and fire, James Holden and the crew of the Rocinante must struggle to survive and get back to the only home they have left.</p>", "978-0-316-21758-3", "\\images\\product\\NemesisGames.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Nemesis Games", new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1443) },
                    { new Guid("e9592525-9cd2-4de1-a466-5de0e04cc636"), "Corey, James S. A.", new Guid("b91476d3-ceec-427a-965e-b935798fe431"), new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1448), "<p>A revolution brewing for generations has begun in fire. It will end in blood.</p>\r\n<p>The Free Navy - a violent group of Belters in black-market military ships - has crippled the Earth and begun a campaign of piracy and violence among the outer planets. The colony ships heading for the thousand new worlds on the far side of the alien ring gates are easy prey, and no single navy remains strong enough to protect them.</p>\r\n<p>James Holden and his crew know the strengths and weaknesses of this new force better than anyone. Outnumbered and outgunned, the embattled remnants of the old political powers call on the&nbsp;<em>Rocinante&nbsp;</em>for a desperate mission to reach Medina Station at the heart of the gate network.</p>\r\n<p>But the new alliances are as flawed as the old, and the struggle for power has only just begun. As the chaos grows, an alien mystery deepens. Pirate fleets, mutiny and betrayal may be the least of the&nbsp;<em>Rocinante</em>'s problems. And in the uncanny spaces past the ring gates, the choices of a few damaged and desperate people may determine the fate of more than just humanity.</p>", "978-0-316-33474-7", "\\images\\product\\BabylonsAshes.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Babylon's Ashes", new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1450) },
                    { new Guid("f6c4522c-f14c-4f05-825a-b7d088528149"), "Corey, James S. A.", new Guid("b91476d3-ceec-427a-965e-b935798fe431"), new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1435), "<p>The gates have opened the way to thousands of habitable planets, and the land rush has begun. Settlers stream out from humanity's home planets in a vast, poorly controlled flood, landing on a new world. Among them, the Rocinante, haunted by the vast, posthuman network of the protomolecule as they investigate what destroyed the great intergalactic society that built the gates and the protomolecule.<br><br>But Holden and his crew must also contend with the growing tensions between the settlers and the company which owns the official claim to the planet. Both sides will stop at nothing to defend what's theirs, but soon a terrible disease strikes and only Holden - with help from the ghostly Detective Miller - can find the cure.</p>", "978-0-316-21762-0", "\\images\\product\\CibolaBurn.jpg", 270000.0, 260000.0, 240000.0, 250000.0, "Cibola Burn", new DateTime(2025, 3, 2, 6, 25, 31, 284, DateTimeKind.Local).AddTicks(1437) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneralInquiries");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "af7add2e-7675-4bff-b9be-34431ac30c2c" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5b222991-2599-4867-b20b-268bce9494df"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f42c3890-a4d8-42ed-a43a-9288a4eaf38f"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("2e1140fe-9f3f-42b8-8523-68bbf5d0c09a"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("4ac43230-2c6b-4933-afa9-6edf3da59bd3"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("c3c5d5eb-b617-49ee-b75e-a34d0561581d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01668ff8-97d0-427f-8409-fd8dab936099"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1088e497-a334-45bb-97f2-bea90f69d0a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1fb49bfe-8715-4ef9-8dff-43c55b9bdc36"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d1c34d9-fd14-401c-aec9-c3c71788c5d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4522b8b-f8d8-4040-9e50-1f2b51570cd6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d0e157ef-a10d-4507-b28d-fe53e3c7ec5b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dce7c551-7e2e-46c4-aba8-11e83f68892c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9592525-9cd2-4de1-a466-5de0e04cc636"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6c4522c-f14c-4f05-825a-b7d088528149"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af7add2e-7675-4bff-b9be-34431ac30c2c");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b91476d3-ceec-427a-965e-b935798fe431"));

            migrationBuilder.DropColumn(
                name: "FOBPriceInUSD",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "PriceInUSD",
                table: "Car");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "544eef83-5940-49bf-8d4d-2aa19d408eeb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "f7c0e552-7528-4787-b085-6950306a65ea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "e7259295-4919-412b-8928-a18b19ed3d9e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "f4c0b214-b913-4218-8aea-54cd161df63c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "7c087437-6596-4afc-a1ae-22b0cdb14396");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed694d67-aa33-48ec-acd2-a254a292ddbb", "e67daf9a-1e34-430b-a986-d82f64c19c49", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "CompanyId", "ConcurrencyStamp", "CountryId", "DesignationId", "Email", "EmailConfirmed", "FullName", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5352564e-8dab-4bd9-a5e7-abcdda219f68", 0, null, null, "fbbd8572-ef7c-467c-b60f-46461612f9b9", 1, null, "waheedtariq@msn.com", true, "Waheed Tariq", "Male", false, null, "WAHEEDTARIQ@MSN.COM", "WAHEEDTARIQ@MSN.COM", "AQAAAAIAAYagAAAAEHsckX5oYbudzUTXDjkexZLfXsMWOT7Mpad2UhsGLdGO37jL0NWn8kHInSn7JYlYug==", null, false, null, "", null, null, false, "waheedtariq@msn.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "DisplayOrder", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("64abaee8-e45e-4b66-bd81-f8a76a8a4067"), new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(5951), 3, "History", new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(5954) },
                    { new Guid("711cfc91-ad2c-4774-ad6b-0e01603e587f"), new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(5941), 2, "Action", new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(5944) },
                    { new Guid("fc54cbcc-9830-4a61-a65e-a7194b5544b7"), new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(5858), 1, "Scifi", new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(5928) }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Created", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress", "Updated" },
                values: new object[,]
                {
                    { new Guid("32f9d3a1-3d51-4ae6-a034-4e8dc68de343"), "Vid City", new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6119), "Vivid Books", "7779990000", "66666", "IL", "999 Vid St", new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6122) },
                    { new Guid("81bd144f-6035-4a3d-be25-3c86f5586ed0"), "Lala land", new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6129), "Readers Club", "1113335555", "99999", "NY", "999 Main St", new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6132) },
                    { new Guid("ed740966-7088-4f17-9022-64092bb80ec1"), "Tech City", new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6099), "Tech Solution", "6669990000", "12121", "IL", "123 Tech St", new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6106) }
                });

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 10, 34, 34, 767, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ed694d67-aa33-48ec-acd2-a254a292ddbb", "5352564e-8dab-4bd9-a5e7-abcdda219f68" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Created", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("0d518666-9838-4cc8-aa59-f3ad17b26102"), "Corey, James S. A.", new Guid("fc54cbcc-9830-4a61-a65e-a7194b5544b7"), new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6238), "<p>We are not alone. On Ganymede, breadbasket of the outer planets, a Martian marine watches as her platoon is slaughtered by a monstrous supersoldier. On Earth, a high-level politician struggles to prevent interplanetary war from reigniting. And on Venus, an alien protomolecule has overrun the planet, wreaking massive, mysterious changes and threatening to spread out into the solar system.<br><br>In the vast wilderness of space, James Holden and the crew of the&nbsp;<em>Rocinante</em> have been keeping the peace for the Outer Planets Alliance. When they agree to help a scientist search war-torn Ganymede for a missing child, the future of humanity rests on whether a single ship can prevent an alien invasion that may have already begun.</p>", "978-0-316-12906-0", "\\images\\product\\CalibansWar.jpg", 310000.0, 295000.0, 265000.0, 285000.0, "Caliban's War", new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6241) },
                    { new Guid("1a73320e-d133-4c04-afbe-c245181e3f3e"), "Corey, James S. A.", new Guid("fc54cbcc-9830-4a61-a65e-a7194b5544b7"), new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6280), "<p>A revolution brewing for generations has begun in fire. It will end in blood.</p>\r\n<p>The Free Navy - a violent group of Belters in black-market military ships - has crippled the Earth and begun a campaign of piracy and violence among the outer planets. The colony ships heading for the thousand new worlds on the far side of the alien ring gates are easy prey, and no single navy remains strong enough to protect them.</p>\r\n<p>James Holden and his crew know the strengths and weaknesses of this new force better than anyone. Outnumbered and outgunned, the embattled remnants of the old political powers call on the&nbsp;<em>Rocinante&nbsp;</em>for a desperate mission to reach Medina Station at the heart of the gate network.</p>\r\n<p>But the new alliances are as flawed as the old, and the struggle for power has only just begun. As the chaos grows, an alien mystery deepens. Pirate fleets, mutiny and betrayal may be the least of the&nbsp;<em>Rocinante</em>'s problems. And in the uncanny spaces past the ring gates, the choices of a few damaged and desperate people may determine the fate of more than just humanity.</p>", "978-0-316-33474-7", "\\images\\product\\BabylonsAshes.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Babylon's Ashes", new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6283) },
                    { new Guid("1e6d02dd-bcc7-402b-bd7b-02e7e5370dbd"), "Corey, James S. A.", new Guid("fc54cbcc-9830-4a61-a65e-a7194b5544b7"), new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6259), "<p>The gates have opened the way to thousands of habitable planets, and the land rush has begun. Settlers stream out from humanity's home planets in a vast, poorly controlled flood, landing on a new world. Among them, the Rocinante, haunted by the vast, posthuman network of the protomolecule as they investigate what destroyed the great intergalactic society that built the gates and the protomolecule.<br><br>But Holden and his crew must also contend with the growing tensions between the settlers and the company which owns the official claim to the planet. Both sides will stop at nothing to defend what's theirs, but soon a terrible disease strikes and only Holden - with help from the ghostly Detective Miller - can find the cure.</p>", "978-0-316-21762-0", "\\images\\product\\CibolaBurn.jpg", 270000.0, 260000.0, 240000.0, 250000.0, "Cibola Burn", new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6262) },
                    { new Guid("3cc10c9c-56c2-4d57-b059-07aebe8284ff"), "Corey, James S. A.", new Guid("fc54cbcc-9830-4a61-a65e-a7194b5544b7"), new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6270), "<p>The fifth novel in Corey's New York Times bestselling Expanse series--now being produced for television by the SyFy Channel!<br><br>A thousand worlds have opened, and the greatest land rush in human history has begun. As wave after wave of colonists leave, the power structures of the old solar system begin to buckle.<br><br>Ships are disappearing without a trace. Private armies are being secretly formed. The sole remaining protomolecule sample is stolen. Terrorist attacks previously considered impossible bring the inner planets to their knees. The sins of the past are returning to exact a terrible price.<br><br>And as a new human order is struggling to be born in blood and fire, James Holden and the crew of the Rocinante must struggle to survive and get back to the only home they have left.</p>", "978-0-316-21758-3", "\\images\\product\\NemesisGames.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Nemesis Games", new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6272) },
                    { new Guid("7a3f7077-ba03-488d-8c3e-cfd25ce03756"), "Corey, James S. A.", new Guid("fc54cbcc-9830-4a61-a65e-a7194b5544b7"), new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6303), "<p>Thirteen hundred gates have opened to solar systems around the galaxy. But as humanity builds its interstellar empire in the alien ruins, the mysteries and threats grow deeper.<br><br>In the dead systems where gates lead to stranger things than alien planets, Elvi Okoye begins a desperate search to discover the nature of a genocide that happened before the first human beings existed, and to find weapons to fight a war against forces at the edge of the imaginable. But the price of that knowledge may be higher than she can pay.<br><br>At the heart of the empire, Teresa Duarte prepares to take on the burden of her father's godlike ambition. The sociopathic scientist Paolo Cort&aacute;zar and the Mephistophelian prisoner James Holden are only two of the dangers in a palace thick with intrigue, but Teresa has a mind of her own and secrets even her father the emperor doesn't guess.<br><br>And throughout the wide human empire, the scattered crew of the Rocinante fights a brave rear-guard action against Duarte's authoritarian regime. Memory of the old order falls away, and a future under Laconia's eternal rule -- and with it, a battle that humanity can only lose - seems more and more certain. Because against the terrors that lie between worlds, courage and ambition will not be enough...</p>", "978-0-316-33286-6", "\\images\\product\\TiamatsWrath.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Tiamat's Wrath", new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6306) },
                    { new Guid("a9b079c0-b146-4a95-a02a-32401a8d6d4e"), "Corey, James S. A.", new Guid("fc54cbcc-9830-4a61-a65e-a7194b5544b7"), new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6248), "<p>Abaddon's Gate is the third book in the New York Times bestselling Expanse series.<br><br>For generations, the solar system - Mars, the Moon, the Asteroid Belt - was humanity's great frontier. Until now. The alien artefact working through its program under the clouds of Venus has emerged to build a massive structure outside the orbit of Uranus: a gate that leads into a starless dark.<br><br>Jim Holden and the crew of the Rocinante are part of a vast flotilla of scientific and military ships going out to examine the artefact. But behind the scenes, a complex plot is unfolding, with the destruction of Holden at its core. As the emissaries of the human race try to find whether the gate is an opportunity or a threat, the greatest danger is the one they brought with them.</p>", "978-0-316-12907-7", "\\images\\product\\AbaddonsGate.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Abaddon's Gate", new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6251) },
                    { new Guid("aaa2a7c6-4c5f-4a54-a6c1-6e0576de552f"), "Corey, James S. A.", new Guid("fc54cbcc-9830-4a61-a65e-a7194b5544b7"), new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6318), "<p>The Laconian Empire has fallen, setting the thirteen hundred solar systems free from the rule of Winston Duarte. But the ancient enemy that killed the gate builders is awake, and the war against our universe has begun again.<br><br>In the dead system of Adro, Elvi Okoye leads a desperate scientific mission to understand what the gate builders were and what destroyed them, even if it means compromising herself and the half-alien children who bear the weight of her investigation. Through the wide-flung systems of humanity, Colonel Aliana Tanaka hunts for Duarte&rsquo;s missing daughter. . . and the shattered emperor himself. And on the Rocinante, James Holden and his crew struggle to build a future for humanity out of the shards and ruins of all that has come before.<br><br>As nearly unimaginable forces prepare to annihilate all human life, Holden and a group of unlikely allies discover a last, desperate chance to unite all of humanity, with the promise of a vast galactic civilization free from wars, factions, lies, and secrets if they win.<br><br>But the price of victory may be worse than the cost of defeat.</p>", "978-0-316-33291-0", "\\images\\product\\LeviathanFalls.jpg", 330000.0, 320000.0, 300000.0, 310000.0, "Leviathan Falls", new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6321) },
                    { new Guid("ce1f7331-e73b-46e3-a2ff-4cd387678702"), "Corey, James S. A.", new Guid("fc54cbcc-9830-4a61-a65e-a7194b5544b7"), new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6291), "<p>In the thousand-sun network of humanity's expansion, new colony worlds are struggling to find their way. Every new planet lives on a knife edge between collapse and wonder, and the crew of the aging gunship Rocinante have their hands more than full keeping the fragile peace.<br><br>In the vast space between Earth and Jupiter, the inner planets and belt have formed a tentative and uncertain alliance still haunted by a history of wars and prejudices. On the lost colony world of Laconia, a hidden enemy has a new vision for all of humanity and the power to enforce it.<br><br>New technologies clash with old as the history of human conflict returns to its ancient patterns of war and subjugation. But human nature is not the only enemy, and the forces being unleashed have their own price. A price that will change the shape of humanity -- and of the Rocinante -- unexpectedly and forever...</p>", "978-0-316-33283-5", "\\images\\product\\PersepolisRising.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Persepolis Rising	", new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6295) },
                    { new Guid("f3c4770f-7875-4795-8a66-c609ce6773f8"), "Corey, James S. A.", new Guid("fc54cbcc-9830-4a61-a65e-a7194b5544b7"), new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6221), "<p>Humanity has colonized the solar system&mdash;Mars, the Moon, the Asteroid Belt and beyond&mdash;but the stars are still out of our reach.<br><br>Jim Holden is XO of an ice miner making runs from the rings of Saturn to the mining stations of the Belt. When he and his crew stumble upon a derelict ship, the&nbsp;<em>Scopuli</em>, they find themselves in possession of a secret they never wanted. A secret that someone is willing to kill for&mdash;and kill on a scale unfathomable to Jim and his crew. War is brewing in the system unless he can find out who left the ship and why.<br><br>Detective Miller is looking for a girl. One girl in a system of billions, but her parents have money and money talks. When the trail leads him to the&nbsp;<em>Scopuli</em>&nbsp;and rebel sympathizer Holden, he realizes that this girl may be the key to everything.<br><br>Holden and Miller must thread the needle between the Earth government, the Outer Planet revolutionaries, and secretive corporations&mdash;and the odds are against them. But out in the Belt, the rules are different, and one small ship can change the fate of the universe.</p>", "978-0-316-12908-4", "\\images\\product\\LeviathanWakes.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Leviathan Wakes", new DateTime(2025, 2, 8, 10, 34, 34, 898, DateTimeKind.Local).AddTicks(6226) }
                });
        }
    }
}
