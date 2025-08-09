using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YRTJapan.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SalesInquiresTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af7add2e-7675-4bff-b9be-34431ac30c2c");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b91476d3-ceec-427a-965e-b935798fe431"));

            migrationBuilder.CreateTable(
                name: "SalesInquiries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInquiries", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1e507769-0ad4-45f5-b525-07de0fe4a541");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "3d856c5b-3517-411c-8136-db8092b8a6e6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "9e449f85-1b49-491b-918e-61fa1157fa02");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "0b7e8ed1-74ec-4775-97e7-72a4d8eb9ada");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "ffa6b950-fb85-44ef-97b8-9f3f9e03d26a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "067c0de3-fd1a-4376-9ec4-52d40d7f6f14");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "CompanyId", "ConcurrencyStamp", "CountryId", "DesignationId", "Email", "EmailConfirmed", "FullName", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName" },
                values: new object[] { "462815c9-01de-40e8-ab36-da2cc7049000", 0, null, null, "9daf6607-a086-4dab-9d09-9a2d66e28441", 1, null, "waheedtariq@msn.com", true, "Waheed Tariq", "Male", false, null, "WAHEEDTARIQ@MSN.COM", "WAHEEDTARIQ@MSN.COM", "AQAAAAIAAYagAAAAEPYYU8VxIxEVRh7fRMw2GhMcs4HNslKQBQHB2MGp6PeJhZ6Tw09zkVxrW8iIV22S2A==", null, false, null, "", null, null, false, "waheedtariq@msn.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "DisplayOrder", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("46b6c8a7-8cbb-44ed-9a57-103a793d9306"), new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7165), 2, "Action", new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7169) },
                    { new Guid("cf1ba116-f8bc-4463-8c35-75eedf37e7fe"), new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(6944), 1, "Scifi", new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7043) },
                    { new Guid("d6d07be0-6f01-4131-bb34-88e3b262f618"), new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7179), 3, "History", new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7184) }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Created", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress", "Updated" },
                values: new object[,]
                {
                    { new Guid("23799651-c7c1-4cc5-8537-5c40e4066a14"), "Vid City", new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7475), "Vivid Books", "7779990000", "66666", "IL", "999 Vid St", new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7480) },
                    { new Guid("707210dd-e44c-48b8-9220-364b8c65d069"), "Tech City", new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7443), "Tech Solution", "6669990000", "12121", "IL", "123 Tech St", new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7451) },
                    { new Guid("86119c3a-772c-49e3-ac7d-2d78ff9c1d4a"), "Lala land", new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7489), "Readers Club", "1113335555", "99999", "NY", "999 Main St", new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7496) }
                });

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "YRTCountry",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 8, 1, 5, 22, 207, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "462815c9-01de-40e8-ab36-da2cc7049000" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Created", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("17f157c0-318c-4603-a3e6-953ee48cef37"), "Corey, James S. A.", new Guid("cf1ba116-f8bc-4463-8c35-75eedf37e7fe"), new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7755), "<p>The fifth novel in Corey's New York Times bestselling Expanse series--now being produced for television by the SyFy Channel!<br><br>A thousand worlds have opened, and the greatest land rush in human history has begun. As wave after wave of colonists leave, the power structures of the old solar system begin to buckle.<br><br>Ships are disappearing without a trace. Private armies are being secretly formed. The sole remaining protomolecule sample is stolen. Terrorist attacks previously considered impossible bring the inner planets to their knees. The sins of the past are returning to exact a terrible price.<br><br>And as a new human order is struggling to be born in blood and fire, James Holden and the crew of the Rocinante must struggle to survive and get back to the only home they have left.</p>", "978-0-316-21758-3", "\\images\\product\\NemesisGames.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Nemesis Games", new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7763) },
                    { new Guid("28267794-c3a7-46e8-88ab-ad4bf9228f44"), "Corey, James S. A.", new Guid("cf1ba116-f8bc-4463-8c35-75eedf37e7fe"), new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7810), "<p>Thirteen hundred gates have opened to solar systems around the galaxy. But as humanity builds its interstellar empire in the alien ruins, the mysteries and threats grow deeper.<br><br>In the dead systems where gates lead to stranger things than alien planets, Elvi Okoye begins a desperate search to discover the nature of a genocide that happened before the first human beings existed, and to find weapons to fight a war against forces at the edge of the imaginable. But the price of that knowledge may be higher than she can pay.<br><br>At the heart of the empire, Teresa Duarte prepares to take on the burden of her father's godlike ambition. The sociopathic scientist Paolo Cort&aacute;zar and the Mephistophelian prisoner James Holden are only two of the dangers in a palace thick with intrigue, but Teresa has a mind of her own and secrets even her father the emperor doesn't guess.<br><br>And throughout the wide human empire, the scattered crew of the Rocinante fights a brave rear-guard action against Duarte's authoritarian regime. Memory of the old order falls away, and a future under Laconia's eternal rule -- and with it, a battle that humanity can only lose - seems more and more certain. Because against the terrors that lie between worlds, courage and ambition will not be enough...</p>", "978-0-316-33286-6", "\\images\\product\\TiamatsWrath.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Tiamat's Wrath", new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7816) },
                    { new Guid("2d393ad7-aa8b-4fa7-9031-38b006eaddbf"), "Corey, James S. A.", new Guid("cf1ba116-f8bc-4463-8c35-75eedf37e7fe"), new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7692), "<p>We are not alone. On Ganymede, breadbasket of the outer planets, a Martian marine watches as her platoon is slaughtered by a monstrous supersoldier. On Earth, a high-level politician struggles to prevent interplanetary war from reigniting. And on Venus, an alien protomolecule has overrun the planet, wreaking massive, mysterious changes and threatening to spread out into the solar system.<br><br>In the vast wilderness of space, James Holden and the crew of the&nbsp;<em>Rocinante</em> have been keeping the peace for the Outer Planets Alliance. When they agree to help a scientist search war-torn Ganymede for a missing child, the future of humanity rests on whether a single ship can prevent an alien invasion that may have already begun.</p>", "978-0-316-12906-0", "\\images\\product\\CalibansWar.jpg", 310000.0, 295000.0, 265000.0, 285000.0, "Caliban's War", new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7702) },
                    { new Guid("5907c623-8f20-480c-b805-03044c434db5"), "Corey, James S. A.", new Guid("cf1ba116-f8bc-4463-8c35-75eedf37e7fe"), new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7830), "<p>The Laconian Empire has fallen, setting the thirteen hundred solar systems free from the rule of Winston Duarte. But the ancient enemy that killed the gate builders is awake, and the war against our universe has begun again.<br><br>In the dead system of Adro, Elvi Okoye leads a desperate scientific mission to understand what the gate builders were and what destroyed them, even if it means compromising herself and the half-alien children who bear the weight of her investigation. Through the wide-flung systems of humanity, Colonel Aliana Tanaka hunts for Duarte&rsquo;s missing daughter. . . and the shattered emperor himself. And on the Rocinante, James Holden and his crew struggle to build a future for humanity out of the shards and ruins of all that has come before.<br><br>As nearly unimaginable forces prepare to annihilate all human life, Holden and a group of unlikely allies discover a last, desperate chance to unite all of humanity, with the promise of a vast galactic civilization free from wars, factions, lies, and secrets if they win.<br><br>But the price of victory may be worse than the cost of defeat.</p>", "978-0-316-33291-0", "\\images\\product\\LeviathanFalls.jpg", 330000.0, 320000.0, 300000.0, 310000.0, "Leviathan Falls", new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7836) },
                    { new Guid("64b40d1e-5bbb-49bd-adf2-0fd6f6380584"), "Corey, James S. A.", new Guid("cf1ba116-f8bc-4463-8c35-75eedf37e7fe"), new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7646), "<p>Humanity has colonized the solar system&mdash;Mars, the Moon, the Asteroid Belt and beyond&mdash;but the stars are still out of our reach.<br><br>Jim Holden is XO of an ice miner making runs from the rings of Saturn to the mining stations of the Belt. When he and his crew stumble upon a derelict ship, the&nbsp;<em>Scopuli</em>, they find themselves in possession of a secret they never wanted. A secret that someone is willing to kill for&mdash;and kill on a scale unfathomable to Jim and his crew. War is brewing in the system unless he can find out who left the ship and why.<br><br>Detective Miller is looking for a girl. One girl in a system of billions, but her parents have money and money talks. When the trail leads him to the&nbsp;<em>Scopuli</em>&nbsp;and rebel sympathizer Holden, he realizes that this girl may be the key to everything.<br><br>Holden and Miller must thread the needle between the Earth government, the Outer Planet revolutionaries, and secretive corporations&mdash;and the odds are against them. But out in the Belt, the rules are different, and one small ship can change the fate of the universe.</p>", "978-0-316-12908-4", "\\images\\product\\LeviathanWakes.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Leviathan Wakes", new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7665) },
                    { new Guid("97f955a7-671c-440f-a905-a66bd54a33a5"), "Corey, James S. A.", new Guid("cf1ba116-f8bc-4463-8c35-75eedf37e7fe"), new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7772), "<p>A revolution brewing for generations has begun in fire. It will end in blood.</p>\r\n<p>The Free Navy - a violent group of Belters in black-market military ships - has crippled the Earth and begun a campaign of piracy and violence among the outer planets. The colony ships heading for the thousand new worlds on the far side of the alien ring gates are easy prey, and no single navy remains strong enough to protect them.</p>\r\n<p>James Holden and his crew know the strengths and weaknesses of this new force better than anyone. Outnumbered and outgunned, the embattled remnants of the old political powers call on the&nbsp;<em>Rocinante&nbsp;</em>for a desperate mission to reach Medina Station at the heart of the gate network.</p>\r\n<p>But the new alliances are as flawed as the old, and the struggle for power has only just begun. As the chaos grows, an alien mystery deepens. Pirate fleets, mutiny and betrayal may be the least of the&nbsp;<em>Rocinante</em>'s problems. And in the uncanny spaces past the ring gates, the choices of a few damaged and desperate people may determine the fate of more than just humanity.</p>", "978-0-316-33474-7", "\\images\\product\\BabylonsAshes.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Babylon's Ashes", new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7782) },
                    { new Guid("9d9e9acd-d71f-46d0-9ac3-7b2591db38f3"), "Corey, James S. A.", new Guid("cf1ba116-f8bc-4463-8c35-75eedf37e7fe"), new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7714), "<p>Abaddon's Gate is the third book in the New York Times bestselling Expanse series.<br><br>For generations, the solar system - Mars, the Moon, the Asteroid Belt - was humanity's great frontier. Until now. The alien artefact working through its program under the clouds of Venus has emerged to build a massive structure outside the orbit of Uranus: a gate that leads into a starless dark.<br><br>Jim Holden and the crew of the Rocinante are part of a vast flotilla of scientific and military ships going out to examine the artefact. But behind the scenes, a complex plot is unfolding, with the destruction of Holden at its core. As the emissaries of the human race try to find whether the gate is an opportunity or a threat, the greatest danger is the one they brought with them.</p>", "978-0-316-12907-7", "\\images\\product\\AbaddonsGate.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Abaddon's Gate", new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7721) },
                    { new Guid("ab8dc5ba-0f08-4d2d-89fe-7fed8fd6353e"), "Corey, James S. A.", new Guid("cf1ba116-f8bc-4463-8c35-75eedf37e7fe"), new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7793), "<p>In the thousand-sun network of humanity's expansion, new colony worlds are struggling to find their way. Every new planet lives on a knife edge between collapse and wonder, and the crew of the aging gunship Rocinante have their hands more than full keeping the fragile peace.<br><br>In the vast space between Earth and Jupiter, the inner planets and belt have formed a tentative and uncertain alliance still haunted by a history of wars and prejudices. On the lost colony world of Laconia, a hidden enemy has a new vision for all of humanity and the power to enforce it.<br><br>New technologies clash with old as the history of human conflict returns to its ancient patterns of war and subjugation. But human nature is not the only enemy, and the forces being unleashed have their own price. A price that will change the shape of humanity -- and of the Rocinante -- unexpectedly and forever...</p>", "978-0-316-33283-5", "\\images\\product\\PersepolisRising.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Persepolis Rising	", new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7800) },
                    { new Guid("de7b5e8b-bce3-4edc-b441-2a4938fb8d8e"), "Corey, James S. A.", new Guid("cf1ba116-f8bc-4463-8c35-75eedf37e7fe"), new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7738), "<p>The gates have opened the way to thousands of habitable planets, and the land rush has begun. Settlers stream out from humanity's home planets in a vast, poorly controlled flood, landing on a new world. Among them, the Rocinante, haunted by the vast, posthuman network of the protomolecule as they investigate what destroyed the great intergalactic society that built the gates and the protomolecule.<br><br>But Holden and his crew must also contend with the growing tensions between the settlers and the company which owns the official claim to the planet. Both sides will stop at nothing to defend what's theirs, but soon a terrible disease strikes and only Holden - with help from the ghostly Detective Miller - can find the cure.</p>", "978-0-316-21762-0", "\\images\\product\\CibolaBurn.jpg", 270000.0, 260000.0, 240000.0, 250000.0, "Cibola Burn", new DateTime(2025, 3, 8, 1, 5, 22, 404, DateTimeKind.Local).AddTicks(7741) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesInquiries");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "462815c9-01de-40e8-ab36-da2cc7049000" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("46b6c8a7-8cbb-44ed-9a57-103a793d9306"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d6d07be0-6f01-4131-bb34-88e3b262f618"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("23799651-c7c1-4cc5-8537-5c40e4066a14"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("707210dd-e44c-48b8-9220-364b8c65d069"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("86119c3a-772c-49e3-ac7d-2d78ff9c1d4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17f157c0-318c-4603-a3e6-953ee48cef37"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28267794-c3a7-46e8-88ab-ad4bf9228f44"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d393ad7-aa8b-4fa7-9031-38b006eaddbf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5907c623-8f20-480c-b805-03044c434db5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64b40d1e-5bbb-49bd-adf2-0fd6f6380584"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("97f955a7-671c-440f-a905-a66bd54a33a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d9e9acd-d71f-46d0-9ac3-7b2591db38f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab8dc5ba-0f08-4d2d-89fe-7fed8fd6353e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de7b5e8b-bce3-4edc-b441-2a4938fb8d8e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "462815c9-01de-40e8-ab36-da2cc7049000");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cf1ba116-f8bc-4463-8c35-75eedf37e7fe"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "723c5550-274f-4e47-8d0a-2effee4b2bc5");

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
    }
}
