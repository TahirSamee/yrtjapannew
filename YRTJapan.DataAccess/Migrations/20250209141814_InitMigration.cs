using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YRTJapan.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "API_Configuration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    APIKey = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    Endpoint = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedById = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_API_Configuration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "API_Log",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    APIEndpoint = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    RequestTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResponseTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedById = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_API_Log", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Gender = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    FullName = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    DesignationId = table.Column<int>(type: "int", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
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
                name: "Car",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LOT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AUCTION_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AUCTION_DATE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AUCTION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MARKA_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MODEL_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MARKA_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MODEL_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YEAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TOWN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ENG_V = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PW = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KUZOV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GRADE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COLOR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KPP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KPP_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PRIV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MILEAGE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EQUIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RATE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    START = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FINISH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STATUS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TIME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AVG_PRICE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AVG_STRING = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAGES = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TAG2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DashboardSetting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SettingJSON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedById = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DashboardSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Favourites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MakeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FreeQuotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreeQuotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inquiry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedById = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquiry", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalePrice = table.Column<float>(type: "real", nullable: false),
                    SaleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedById = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YRTBankAccount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Telex = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    AccountNumber = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    IBAN = table.Column<string>(type: "VARCHAR(25)", nullable: false),
                    SwiftCode = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Address = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedById = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YRTBankAccount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YRTClientTestimonial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    UserComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserScore = table.Column<int>(type: "int", nullable: false),
                    UserImg = table.Column<string>(type: "NVARCHAR(200)", nullable: false),
                    IsVarified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedById = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YRTClientTestimonial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YRTConfiguration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfigKey = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    ConfigValue = table.Column<string>(type: "CHAR(1)", nullable: false),
                    ConfigDesc = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedById = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YRTConfiguration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YRTCountry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Code = table.Column<string>(type: "VARCHAR(5)", nullable: false),
                    LogoImg = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedById = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YRTCountry", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YRTDesignation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedById = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YRTDesignation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YRTMaker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    LogoImg = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    IsGlobal = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedById = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YRTMaker", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YRTUserReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    UserComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserScore = table.Column<int>(type: "int", nullable: false),
                    UserImg = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedById = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YRTUserReview", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YRTWebsiteConfiguration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WebConfigTitle = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    WebConfigDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebConfigImage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    WebPageName = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedById = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YRTWebsiteConfiguration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "bde251de-911c-4792-87b3-c0ddb316472e", "Admin", "ADMIN" },
                    { "2", "edb01137-5928-4be1-802c-491ae2e685ef", "Employee", "EMPLOYEE" },
                    { "3", "fd6ab8b6-625f-461c-b42f-3a240968c20d", "Customer", "CUSTOMER" },
                    { "4", "2ce4f3de-fef9-4116-93b7-8bf2dab7fb0e", "DataEntryOperator", "DATAENTRYOPERATOR" },
                    { "5", "e926e944-04de-446d-8fa0-bb0399d8f5dd", "Sale", "SALE" },
                    { "6", "d32def81-5ae2-4a87-b802-03a63af4d159", "Accountant", "ACCOUNTANT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "CompanyId", "ConcurrencyStamp", "CountryId", "DesignationId", "Email", "EmailConfirmed", "FullName", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c36b1412-230b-423c-a562-d8daae6d69bd", 0, null, null, "52008a65-17db-473b-93e1-b6d1a1400548", 1, null, "waheedtariq@msn.com", true, "Waheed Tariq", "Male", false, null, "WAHEEDTARIQ@MSN.COM", "WAHEEDTARIQ@MSN.COM", "AQAAAAIAAYagAAAAEHOgCpIrCJh4234ZcBgbLZth+L+MPLOx6UNIZTR2Mld/XRm2mGvqEWFmmbjigPLrGw==", null, false, null, "", null, null, false, "waheedtariq@msn.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "DisplayOrder", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("5b81b2f2-8cd8-467b-977b-665f46ab18d1"), new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6425), 2, "Action", new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6425) },
                    { new Guid("7e680871-5437-4bea-89a6-fc050f006953"), new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6391), 1, "Scifi", new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6404) },
                    { new Guid("a589d649-2559-421d-9297-eab259f4ab6e"), new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6426), 3, "History", new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6427) }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Created", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress", "Updated" },
                values: new object[,]
                {
                    { new Guid("253afcbf-2d3b-467b-a4b6-6b35f3dfc0ea"), "Tech City", new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6488), "Tech Solution", "6669990000", "12121", "IL", "123 Tech St", new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6488) },
                    { new Guid("28075343-cb4d-4c71-b5ea-d750b55d4a96"), "Vid City", new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6495), "Vivid Books", "7779990000", "66666", "IL", "999 Vid St", new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6495) },
                    { new Guid("c9b63938-caea-4f78-9a17-7335364a9fc2"), "Lala land", new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6498), "Readers Club", "1113335555", "99999", "NY", "999 Main St", new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6498) }
                });

            migrationBuilder.InsertData(
                table: "YRTCountry",
                columns: new[] { "Id", "Code", "CreatedById", "CreatedDate", "IsActive", "LogoImg", "Name", "UpdatedById", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "DZ", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7399), false, "/images/countries/Algeria.jpg", "Algeria", null, null },
                    { 2, "AO", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7425), false, "/images/countries/Angola.jpg", "Angola", null, null },
                    { 3, "AI", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7427), false, "/images/countries/Anguilla.jpg", "Anguilla", null, null },
                    { 4, "AG", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7428), false, "/images/countries/Antigua.jpg", "Antigua", null, null },
                    { 5, "AM", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7430), false, "/images/countries/Armenia.jpg", "Armenia", null, null },
                    { 6, "AW", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7430), false, "/images/countries/Aruba.jpg", "Aruba", null, null },
                    { 7, "AU", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7432), false, "/images/countries/Australia.jpg", "Australia", null, null },
                    { 8, "AZ", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7433), false, "/images/countries/Azerbaijan.jpg", "Azerbaijan", null, null },
                    { 9, "BS", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7434), false, "/images/countries/Bahamas.jpg", "Bahamas", null, null },
                    { 10, "BH", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7435), false, "/images/countries/Bahrain.jpg", "Bahrain", null, null },
                    { 11, "BD", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7436), false, "/images/countries/Bangladesh.jpg", "Bangladesh", null, null },
                    { 12, "BB", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7437), false, "/images/countries/Barbados.jpg", "Barbados", null, null },
                    { 13, "BE", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7437), false, "/images/countries/Belgium.jpg", "Belgium", null, null },
                    { 14, "BJ", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7438), false, "/images/countries/Benin.jpg", "Benin", null, null },
                    { 15, "BM", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7440), false, "/images/countries/Bermuda.jpg", "Bermuda", null, null },
                    { 16, "BO", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7441), false, "/images/countries/Bolivia.jpg", "Bolivia", null, null },
                    { 17, "BW", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7441), false, "/images/countries/Botswana.jpg", "Botswana", null, null },
                    { 18, "VG", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7442), false, "/images/countries/British_Virgin_Islands.jpg", "British Virgin Islands", null, null },
                    { 19, "BN", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7448), false, "/images/countries/Brunei.jpg", "Brunei", null, null },
                    { 20, "BG", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7448), false, "/images/countries/Bulgaria.jpg", "Bulgaria", null, null },
                    { 21, "BF", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7449), false, "/images/countries/Burkina_Faso.jpg", "Burkina Faso", null, null },
                    { 22, "BI", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7450), false, "/images/countries/Burundi.jpg", "Burundi", null, null },
                    { 23, "KH", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7451), false, "/images/countries/Cambodia.jpg", "Cambodia", null, null },
                    { 24, "CM", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7452), false, "/images/countries/Cameroon.jpg", "Cameroon", null, null },
                    { 25, "CA", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7453), false, "/images/countries/Canada.jpg", "Canada", null, null },
                    { 26, "KY", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7454), false, "/images/countries/Cayman_Islands.jpg", "Cayman Islands", null, null },
                    { 27, "CL", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7454), false, "/images/countries/Chile.jpg", "Chile", null, null },
                    { 28, "CO", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7455), false, "/images/countries/Colombia.jpg", "Colombia", null, null },
                    { 29, "DM", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7457), false, "/images/countries/Commonwealth_of_Dominica.jpg", "Commonwealth of Dominica", null, null },
                    { 30, "KM", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7459), false, "/images/countries/Comoros.jpg", "Comoros", null, null },
                    { 31, "CK", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7460), false, "/images/countries/Cook_Islands.jpg", "Cook Islands", null, null },
                    { 32, "CR", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7461), false, "/images/countries/Costa_Rica.jpg", "Costa Rica", null, null },
                    { 33, "CI", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7462), false, "/images/countries/Cote_d'Ivoire.jpg", "Cote d'Ivoire", null, null },
                    { 34, "HR", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7463), false, "/images/countries/Croatia.jpg", "Croatia", null, null },
                    { 35, "CY", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7464), false, "/images/countries/Cyprus.jpg", "Cyprus", null, null },
                    { 36, "DK", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7465), false, "/images/countries/Denmark.jpg", "Denmark", null, null },
                    { 37, "DJ", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7466), false, "/images/countries/Djibouti.jpg", "Djibouti", null, null },
                    { 38, "DO", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7466), false, "/images/countries/Dominican_Republic.jpg", "Dominican Republic", null, null },
                    { 39, "CD", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7467), false, "/images/countries/DR_Congo.jpg", "DR Congo", null, null },
                    { 40, "TL", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7468), false, "/images/countries/East_Timor.jpg", "East Timor", null, null },
                    { 41, "EG", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7776), false, "/images/countries/Egypt.jpg", "Egypt", null, null },
                    { 42, "SV", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7778), false, "/images/countries/El_Salvador.jpg", "El Salvador", null, null },
                    { 43, "GB", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7779), false, "/images/countries/United_Kingdom.jpg", "United Kingdom", null, null },
                    { 44, "EE", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7780), false, "/images/countries/Estonia.jpg", "Estonia", null, null },
                    { 45, "SZ", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7781), false, "/images/countries/Eswatini.jpg", "Eswatini", null, null },
                    { 46, "ET", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7781), false, "/images/countries/Ethiopia.jpg", "Ethiopia", null, null },
                    { 47, "FJ", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7782), false, "/images/countries/Fiji.jpg", "Fiji", null, null },
                    { 48, "FI", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7783), false, "/images/countries/Finland.jpg", "Finland", null, null },
                    { 49, "FR", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7784), false, "/images/countries/France.jpg", "France", null, null },
                    { 50, "PF", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7785), false, "/images/countries/French_Polynesia.jpg", "French Polynesia", null, null },
                    { 51, "GA", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7785), false, "/images/countries/Gabon.jpg", "Gabon", null, null },
                    { 52, "GM", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7786), false, "/images/countries/Gambia.jpg", "Gambia", null, null },
                    { 53, "GE", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7787), false, "/images/countries/Georgia.jpg", "Georgia", null, null },
                    { 54, "DE", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7788), false, "/images/countries/Germany.jpg", "Germany", null, null },
                    { 55, "GH", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7789), false, "/images/countries/Ghana.jpg", "Ghana", null, null },
                    { 56, "GD", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7790), false, "/images/countries/Grenada.jpg", "Grenada", null, null },
                    { 57, "GP", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7790), false, "/images/countries/Guadeloupe.jpg", "Guadeloupe", null, null },
                    { 58, "GU", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7791), false, "/images/countries/Guam.jpg", "Guam", null, null },
                    { 59, "GT", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7792), false, "/images/countries/Guatemala.jpg", "Guatemala", null, null },
                    { 60, "GN", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7793), false, "/images/countries/Guinea.jpg", "Guinea", null, null },
                    { 61, "GW", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7794), false, "/images/countries/Guinea-Bissau.jpg", "Guinea-Bissau", null, null },
                    { 62, "GY", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7795), false, "/images/countries/Guyana.jpg", "Guyana", null, null },
                    { 63, "HT", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7795), false, "/images/countries/Haiti.jpg", "Haiti", null, null },
                    { 64, "HN", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7796), false, "/images/countries/Honduras.jpg", "Honduras", null, null },
                    { 65, "HK", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7797), false, "/images/countries/Hong_Kong.jpg", "Hong Kong", null, null },
                    { 66, "IS", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7798), false, "/images/countries/Iceland.jpg", "Iceland", null, null },
                    { 67, "IN", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7799), false, "/images/countries/India.jpg", "India", null, null },
                    { 68, "ID", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7800), false, "/images/countries/Indonesia.jpg", "Indonesia", null, null },
                    { 69, "IE", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7801), false, "/images/countries/Ireland.jpg", "Ireland", null, null },
                    { 70, "IT", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7801), false, "/images/countries/Italy.jpg", "Italy", null, null },
                    { 71, "JM", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7802), false, "/images/countries/Jamaica.jpg", "Jamaica", null, null },
                    { 72, "JO", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7803), false, "/images/countries/Jordan.jpg", "Jordan", null, null },
                    { 73, "KZ", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7804), false, "/images/countries/Kazakhstan.jpg", "Kazakhstan", null, null },
                    { 74, "KE", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7805), false, "/images/countries/Kenya.jpg", "Kenya", null, null },
                    { 75, "KI", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7805), false, "/images/countries/Kiribati.jpg", "Kiribati", null, null },
                    { 76, "KW", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7806), false, "/images/countries/Kuwait.jpg", "Kuwait", null, null },
                    { 77, "KG", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7807), false, "/images/countries/Kyrgyzstan.jpg", "Kyrgyzstan", null, null },
                    { 78, "LB", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7808), false, "/images/countries/Lebanon.jpg", "Lebanon", null, null },
                    { 79, "LS", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7808), false, "/images/countries/Lesotho.jpg", "Lesotho", null, null },
                    { 80, "LR", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7809), false, "/images/countries/Liberia.jpg", "Liberia", null, null },
                    { 81, "LY", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7888), false, "/images/countries/Libya.jpg", "Libya", null, null },
                    { 82, "MG", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7888), false, "/images/countries/Madagascar.jpg", "Madagascar", null, null },
                    { 83, "MW", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7889), false, "/images/countries/Malawi.jpg", "Malawi", null, null },
                    { 84, "MY", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7890), false, "/images/countries/Malaysia.jpg", "Malaysia", null, null },
                    { 85, "MV", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7891), false, "/images/countries/Maldives.jpg", "Maldives", null, null },
                    { 86, "ML", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7915), false, "/images/countries/Mali.jpg", "Mali", null, null },
                    { 87, "MT", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7916), false, "/images/countries/Malta.jpg", "Malta", null, null },
                    { 88, "MH", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7917), false, "/images/countries/Marshall_Islands.jpg", "Marshall Islands", null, null },
                    { 89, "MQ", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7918), false, "/images/countries/Martinique.jpg", "Martinique", null, null },
                    { 90, "MR", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7920), false, "/images/countries/Mauritania.jpg", "Mauritania", null, null },
                    { 91, "MU", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7920), false, "/images/countries/Mauritius.jpg", "Mauritius", null, null },
                    { 92, "MX", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7921), false, "/images/countries/Mexico.jpg", "Mexico", null, null },
                    { 93, "FM", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7922), false, "/images/countries/Micronesia.jpg", "Micronesia", null, null },
                    { 94, "MN", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7923), false, "/images/countries/Mongolia.jpg", "Mongolia", null, null },
                    { 95, "MA", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7924), false, "/images/countries/Morocco.jpg", "Morocco", null, null },
                    { 96, "MZ", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7925), false, "/images/countries/Mozambique.jpg", "Mozambique", null, null },
                    { 97, "MM", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7925), false, "/images/countries/Myanmar.jpg", "Myanmar", null, null },
                    { 98, "NA", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7926), false, "/images/countries/Namibia.jpg", "Namibia", null, null },
                    { 99, "NR", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7927), false, "/images/countries/Nauru.jpg", "Nauru", null, null },
                    { 100, "NL", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7927), false, "/images/countries/Netherlands.jpg", "Netherlands", null, null },
                    { 101, "AN", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7928), false, "/images/countries/Netherlands_Antilles.jpg", "Netherlands Antilles", null, null },
                    { 102, "NC", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7929), false, "/images/countries/New_Caledonia.jpg", "New Caledonia", null, null },
                    { 103, "NZ", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7930), false, "/images/countries/New_Zealand.jpg", "New Zealand", null, null },
                    { 104, "NI", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7931), false, "/images/countries/Nicaragua.jpg", "Nicaragua", null, null },
                    { 105, "NE", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7932), false, "/images/countries/Niger.jpg", "Niger", null, null },
                    { 106, "NG", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7932), false, "/images/countries/Nigeria.jpg", "Nigeria", null, null },
                    { 107, "NO", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7933), false, "/images/countries/Norway.jpg", "Norway", null, null },
                    { 108, "OM", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7934), false, "/images/countries/Oman.jpg", "Oman", null, null },
                    { 109, "PK", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7935), false, "/images/countries/Pakistan.jpg", "Pakistan", null, null },
                    { 110, "PW", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7935), false, "/images/countries/Palau.jpg", "Palau", null, null },
                    { 111, "PA", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7936), false, "/images/countries/Panama.jpg", "Panama", null, null },
                    { 112, "PG", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7937), false, "/images/countries/Papua_New_Guinea.jpg", "Papua New Guinea", null, null },
                    { 113, "PY", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7940), false, "/images/countries/Paraguay.jpg", "Paraguay", null, null },
                    { 114, "PE", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7941), false, "/images/countries/Peru.jpg", "Peru", null, null },
                    { 115, "PH", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7941), false, "/images/countries/Philippines.jpg", "Philippines", null, null },
                    { 116, "PL", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7942), false, "/images/countries/Poland.jpg", "Poland", null, null },
                    { 117, "PT", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7943), false, "/images/countries/Portugal.jpg", "Portugal", null, null },
                    { 118, "QA", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7944), false, "/images/countries/Qatar.jpg", "Qatar", null, null },
                    { 119, "CG", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7944), false, "/images/countries/RC_Congo.jpg", "RC Congo", null, null },
                    { 120, "AB", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7945), false, "/images/countries/Republic_of_Abkhazia.jpg", "Republic of Abkhazia", null, null },
                    { 121, "TG", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7946), false, "/images/countries/Republic_of_Togo.jpg", "Republic of Togo", null, null },
                    { 122, "RO", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7947), false, "/images/countries/Romania.jpg", "Romania", null, null },
                    { 123, "RU", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7948), false, "/images/countries/Russia.jpg", "Russia", null, null },
                    { 124, "RW", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7949), false, "/images/countries/Rwanda.jpg", "Rwanda", null, null },
                    { 125, "MF", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7950), false, "/images/countries/Saint_Martin.jpg", "Saint Martin", null, null },
                    { 126, "WS", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7951), false, "/images/countries/Samoa.jpg", "Samoa", null, null },
                    { 127, "SA", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7951), false, "/images/countries/Saudi_Arabia.jpg", "Saudi Arabia", null, null },
                    { 128, "SN", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7973), false, "/images/countries/Senegal.jpg", "Senegal", null, null },
                    { 129, "SC", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7974), false, "/images/countries/Seychelles.jpg", "Seychelles", null, null },
                    { 130, "SL", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7975), false, "/images/countries/Sierra_Leone.jpg", "Sierra Leone", null, null },
                    { 131, "SG", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7977), false, "/images/countries/Singapore.jpg", "Singapore", null, null },
                    { 132, "SX", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7978), false, "/images/countries/Sint_Maarten.jpg", "Sint Maarten", null, null },
                    { 133, "SB", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7979), false, "/images/countries/Solomon_Islands.jpg", "Solomon Islands", null, null },
                    { 134, "SO", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7980), false, "/images/countries/Somalia.jpg", "Somalia", null, null },
                    { 135, "ZA", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7981), false, "/images/countries/South_Africa.jpg", "South Africa", null, null },
                    { 136, "KR", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7982), false, "/images/countries/South_Korea.jpg", "South Korea", null, null },
                    { 137, "SS", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7983), false, "/images/countries/South_Sudan.jpg", "South Sudan", null, null },
                    { 138, "ES", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7983), false, "/images/countries/Spain.jpg", "Spain", null, null },
                    { 139, "LK", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7986), false, "/images/countries/Sri_Lanka.jpg", "Sri Lanka", null, null },
                    { 140, "KN", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7987), false, "/images/countries/St._Kitts.jpg", "St. Kitts", null, null },
                    { 141, "LC", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7988), false, "/images/countries/St._Lucia.jpg", "St. Lucia", null, null },
                    { 142, "VC", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7988), false, "/images/countries/St._Vincent.jpg", "St. Vincent", null, null },
                    { 143, "SD", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7989), false, "/images/countries/Sudan.jpg", "Sudan", null, null },
                    { 144, "SR", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7990), false, "/images/countries/Suriname.jpg", "Suriname", null, null },
                    { 145, "SE", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7991), false, "/images/countries/Sweden.jpg", "Sweden", null, null },
                    { 146, "TW", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7991), false, "/images/countries/Taiwan.jpg", "Taiwan", null, null },
                    { 147, "TJ", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7992), false, "/images/countries/Tajikistan.jpg", "Tajikistan", null, null },
                    { 148, "TZ", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7993), false, "/images/countries/Tanzania.jpg", "Tanzania", null, null },
                    { 149, "TH", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7994), false, "/images/countries/Thailand.jpg", "Thailand", null, null },
                    { 150, "TO", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7995), false, "/images/countries/Tonga.jpg", "Tonga", null, null },
                    { 151, "TT", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7995), false, "/images/countries/Trinidad.jpg", "Trinidad", null, null },
                    { 152, "TN", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7996), false, "/images/countries/Tunisia.jpg", "Tunisia", null, null },
                    { 153, "TR", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7997), false, "/images/countries/Turkey.jpg", "Turkey", null, null },
                    { 154, "TM", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7998), false, "/images/countries/Turkmenistan.jpg", "Turkmenistan", null, null },
                    { 155, "TC", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7998), false, "/images/countries/Turks_and_Caicos_Islands.jpg", "Turks and Caicos Islands", null, null },
                    { 156, "TV", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(7999), false, "/images/countries/Tuvalu.jpg", "Tuvalu", null, null },
                    { 157, "AE", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(8000), false, "/images/countries/UAE.jpg", "UAE", null, null },
                    { 158, "UG", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(8001), false, "/images/countries/Uganda.jpg", "Uganda", null, null },
                    { 159, "UA", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(8002), false, "/images/countries/Ukraine.jpg", "Ukraine", null, null },
                    { 160, "US", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(8003), false, "/images/countries/United_States_of_America.jpg", "United States of America", null, null },
                    { 161, "UY", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(8004), false, "/images/countries/Uruguay.jpg", "Uruguay", null, null },
                    { 162, "VU", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(8004), false, "/images/countries/Vanuatu.jpg", "Vanuatu", null, null },
                    { 163, "VE", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(8005), false, "/images/countries/Venezuela.jpg", "Venezuela", null, null },
                    { 164, "VN", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(8006), false, "/images/countries/Vietnam.jpg", "Vietnam", null, null },
                    { 165, "YE", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(8007), false, "/images/countries/Yemen.jpg", "Yemen", null, null },
                    { 166, "ZM", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(8007), false, "/images/countries/Zambia.jpg", "Zambia", null, null },
                    { 167, "", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(8008), false, "/images/countries/Zanzibar.jpg", "Zanzibar", null, null },
                    { 168, "ZW", null, new DateTime(2025, 2, 9, 18, 18, 14, 309, DateTimeKind.Local).AddTicks(8009), false, "/images/countries/Zimbabwe.jpg", "Zimbabwe", null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "c36b1412-230b-423c-a562-d8daae6d69bd" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Created", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title", "Updated" },
                values: new object[,]
                {
                    { new Guid("19740e53-38b7-40df-8db1-51113432a5d0"), "Corey, James S. A.", new Guid("7e680871-5437-4bea-89a6-fc050f006953"), new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6521), "<p>Humanity has colonized the solar system&mdash;Mars, the Moon, the Asteroid Belt and beyond&mdash;but the stars are still out of our reach.<br><br>Jim Holden is XO of an ice miner making runs from the rings of Saturn to the mining stations of the Belt. When he and his crew stumble upon a derelict ship, the&nbsp;<em>Scopuli</em>, they find themselves in possession of a secret they never wanted. A secret that someone is willing to kill for&mdash;and kill on a scale unfathomable to Jim and his crew. War is brewing in the system unless he can find out who left the ship and why.<br><br>Detective Miller is looking for a girl. One girl in a system of billions, but her parents have money and money talks. When the trail leads him to the&nbsp;<em>Scopuli</em>&nbsp;and rebel sympathizer Holden, he realizes that this girl may be the key to everything.<br><br>Holden and Miller must thread the needle between the Earth government, the Outer Planet revolutionaries, and secretive corporations&mdash;and the odds are against them. But out in the Belt, the rules are different, and one small ship can change the fate of the universe.</p>", "978-0-316-12908-4", "\\images\\product\\LeviathanWakes.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Leviathan Wakes", new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6521) },
                    { new Guid("30d77372-9dc6-4823-afbb-d253d4a4c341"), "Corey, James S. A.", new Guid("7e680871-5437-4bea-89a6-fc050f006953"), new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6546), "<p>The fifth novel in Corey's New York Times bestselling Expanse series--now being produced for television by the SyFy Channel!<br><br>A thousand worlds have opened, and the greatest land rush in human history has begun. As wave after wave of colonists leave, the power structures of the old solar system begin to buckle.<br><br>Ships are disappearing without a trace. Private armies are being secretly formed. The sole remaining protomolecule sample is stolen. Terrorist attacks previously considered impossible bring the inner planets to their knees. The sins of the past are returning to exact a terrible price.<br><br>And as a new human order is struggling to be born in blood and fire, James Holden and the crew of the Rocinante must struggle to survive and get back to the only home they have left.</p>", "978-0-316-21758-3", "\\images\\product\\NemesisGames.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Nemesis Games", new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6546) },
                    { new Guid("5dcff174-612e-4831-b637-8d10062bedca"), "Corey, James S. A.", new Guid("7e680871-5437-4bea-89a6-fc050f006953"), new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6550), "<p>A revolution brewing for generations has begun in fire. It will end in blood.</p>\r\n<p>The Free Navy - a violent group of Belters in black-market military ships - has crippled the Earth and begun a campaign of piracy and violence among the outer planets. The colony ships heading for the thousand new worlds on the far side of the alien ring gates are easy prey, and no single navy remains strong enough to protect them.</p>\r\n<p>James Holden and his crew know the strengths and weaknesses of this new force better than anyone. Outnumbered and outgunned, the embattled remnants of the old political powers call on the&nbsp;<em>Rocinante&nbsp;</em>for a desperate mission to reach Medina Station at the heart of the gate network.</p>\r\n<p>But the new alliances are as flawed as the old, and the struggle for power has only just begun. As the chaos grows, an alien mystery deepens. Pirate fleets, mutiny and betrayal may be the least of the&nbsp;<em>Rocinante</em>'s problems. And in the uncanny spaces past the ring gates, the choices of a few damaged and desperate people may determine the fate of more than just humanity.</p>", "978-0-316-33474-7", "\\images\\product\\BabylonsAshes.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Babylon's Ashes", new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6551) },
                    { new Guid("6b9f53bc-c85d-48f0-8541-a74f4f50a42c"), "Corey, James S. A.", new Guid("7e680871-5437-4bea-89a6-fc050f006953"), new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6543), "<p>The gates have opened the way to thousands of habitable planets, and the land rush has begun. Settlers stream out from humanity's home planets in a vast, poorly controlled flood, landing on a new world. Among them, the Rocinante, haunted by the vast, posthuman network of the protomolecule as they investigate what destroyed the great intergalactic society that built the gates and the protomolecule.<br><br>But Holden and his crew must also contend with the growing tensions between the settlers and the company which owns the official claim to the planet. Both sides will stop at nothing to defend what's theirs, but soon a terrible disease strikes and only Holden - with help from the ghostly Detective Miller - can find the cure.</p>", "978-0-316-21762-0", "\\images\\product\\CibolaBurn.jpg", 270000.0, 260000.0, 240000.0, 250000.0, "Cibola Burn", new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6544) },
                    { new Guid("6e23dc61-a9ef-43d9-9f62-457c5bdef317"), "Corey, James S. A.", new Guid("7e680871-5437-4bea-89a6-fc050f006953"), new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6559), "<p>Thirteen hundred gates have opened to solar systems around the galaxy. But as humanity builds its interstellar empire in the alien ruins, the mysteries and threats grow deeper.<br><br>In the dead systems where gates lead to stranger things than alien planets, Elvi Okoye begins a desperate search to discover the nature of a genocide that happened before the first human beings existed, and to find weapons to fight a war against forces at the edge of the imaginable. But the price of that knowledge may be higher than she can pay.<br><br>At the heart of the empire, Teresa Duarte prepares to take on the burden of her father's godlike ambition. The sociopathic scientist Paolo Cort&aacute;zar and the Mephistophelian prisoner James Holden are only two of the dangers in a palace thick with intrigue, but Teresa has a mind of her own and secrets even her father the emperor doesn't guess.<br><br>And throughout the wide human empire, the scattered crew of the Rocinante fights a brave rear-guard action against Duarte's authoritarian regime. Memory of the old order falls away, and a future under Laconia's eternal rule -- and with it, a battle that humanity can only lose - seems more and more certain. Because against the terrors that lie between worlds, courage and ambition will not be enough...</p>", "978-0-316-33286-6", "\\images\\product\\TiamatsWrath.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Tiamat's Wrath", new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6560) },
                    { new Guid("790c3df3-c244-40f6-95dc-106f14ba9f3c"), "Corey, James S. A.", new Guid("7e680871-5437-4bea-89a6-fc050f006953"), new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6541), "<p>Abaddon's Gate is the third book in the New York Times bestselling Expanse series.<br><br>For generations, the solar system - Mars, the Moon, the Asteroid Belt - was humanity's great frontier. Until now. The alien artefact working through its program under the clouds of Venus has emerged to build a massive structure outside the orbit of Uranus: a gate that leads into a starless dark.<br><br>Jim Holden and the crew of the Rocinante are part of a vast flotilla of scientific and military ships going out to examine the artefact. But behind the scenes, a complex plot is unfolding, with the destruction of Holden at its core. As the emissaries of the human race try to find whether the gate is an opportunity or a threat, the greatest danger is the one they brought with them.</p>", "978-0-316-12907-7", "\\images\\product\\AbaddonsGate.jpg", 320000.0, 300000.0, 275000.0, 290000.0, "Abaddon's Gate", new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6541) },
                    { new Guid("98a66dcf-9122-4322-b585-1299d40d38e8"), "Corey, James S. A.", new Guid("7e680871-5437-4bea-89a6-fc050f006953"), new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6556), "<p>In the thousand-sun network of humanity's expansion, new colony worlds are struggling to find their way. Every new planet lives on a knife edge between collapse and wonder, and the crew of the aging gunship Rocinante have their hands more than full keeping the fragile peace.<br><br>In the vast space between Earth and Jupiter, the inner planets and belt have formed a tentative and uncertain alliance still haunted by a history of wars and prejudices. On the lost colony world of Laconia, a hidden enemy has a new vision for all of humanity and the power to enforce it.<br><br>New technologies clash with old as the history of human conflict returns to its ancient patterns of war and subjugation. But human nature is not the only enemy, and the forces being unleashed have their own price. A price that will change the shape of humanity -- and of the Rocinante -- unexpectedly and forever...</p>", "978-0-316-33283-5", "\\images\\product\\PersepolisRising.jpg", 300000.0, 290000.0, 260000.0, 280000.0, "Persepolis Rising	", new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6556) },
                    { new Guid("fc935fb1-5c4f-490c-8704-e8de365b4d3f"), "Corey, James S. A.", new Guid("7e680871-5437-4bea-89a6-fc050f006953"), new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6566), "<p>The Laconian Empire has fallen, setting the thirteen hundred solar systems free from the rule of Winston Duarte. But the ancient enemy that killed the gate builders is awake, and the war against our universe has begun again.<br><br>In the dead system of Adro, Elvi Okoye leads a desperate scientific mission to understand what the gate builders were and what destroyed them, even if it means compromising herself and the half-alien children who bear the weight of her investigation. Through the wide-flung systems of humanity, Colonel Aliana Tanaka hunts for Duarte&rsquo;s missing daughter. . . and the shattered emperor himself. And on the Rocinante, James Holden and his crew struggle to build a future for humanity out of the shards and ruins of all that has come before.<br><br>As nearly unimaginable forces prepare to annihilate all human life, Holden and a group of unlikely allies discover a last, desperate chance to unite all of humanity, with the promise of a vast galactic civilization free from wars, factions, lies, and secrets if they win.<br><br>But the price of victory may be worse than the cost of defeat.</p>", "978-0-316-33291-0", "\\images\\product\\LeviathanFalls.jpg", 330000.0, 320000.0, 300000.0, 310000.0, "Leviathan Falls", new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6566) },
                    { new Guid("fd844ad0-67b3-440d-a910-bc2061f1e768"), "Corey, James S. A.", new Guid("7e680871-5437-4bea-89a6-fc050f006953"), new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6537), "<p>We are not alone. On Ganymede, breadbasket of the outer planets, a Martian marine watches as her platoon is slaughtered by a monstrous supersoldier. On Earth, a high-level politician struggles to prevent interplanetary war from reigniting. And on Venus, an alien protomolecule has overrun the planet, wreaking massive, mysterious changes and threatening to spread out into the solar system.<br><br>In the vast wilderness of space, James Holden and the crew of the&nbsp;<em>Rocinante</em> have been keeping the peace for the Outer Planets Alliance. When they agree to help a scientist search war-torn Ganymede for a missing child, the future of humanity rests on whether a single ship can prevent an alien invasion that may have already begun.</p>", "978-0-316-12906-0", "\\images\\product\\CalibansWar.jpg", 310000.0, 295000.0, 265000.0, 285000.0, "Caliban's War", new DateTime(2025, 2, 9, 18, 18, 14, 365, DateTimeKind.Local).AddTicks(6537) }
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
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ApplicationUserId",
                table: "ShoppingCarts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ProductId",
                table: "ShoppingCarts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "API_Configuration");

            migrationBuilder.DropTable(
                name: "API_Log");

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
                name: "Car");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "DashboardSetting");

            migrationBuilder.DropTable(
                name: "Favourites");

            migrationBuilder.DropTable(
                name: "FreeQuotes");

            migrationBuilder.DropTable(
                name: "Inquiry");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "YRTBankAccount");

            migrationBuilder.DropTable(
                name: "YRTClientTestimonial");

            migrationBuilder.DropTable(
                name: "YRTConfiguration");

            migrationBuilder.DropTable(
                name: "YRTCountry");

            migrationBuilder.DropTable(
                name: "YRTDesignation");

            migrationBuilder.DropTable(
                name: "YRTMaker");

            migrationBuilder.DropTable(
                name: "YRTUserReview");

            migrationBuilder.DropTable(
                name: "YRTWebsiteConfiguration");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
