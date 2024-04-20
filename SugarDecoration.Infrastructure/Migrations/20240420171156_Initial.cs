using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SugarDecoration.Infrastructure.Migrations
{
	public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                name: "BiscuitCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Category identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Category name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiscuitCategories", x => x.Id);
                },
                comment: "Category for biscuit");

            migrationBuilder.CreateTable(
                name: "CakeCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Category identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Category name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CakeCategories", x => x.Id);
                },
                comment: "Category for cake");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Product identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Product title"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Product price"),
                    ImageUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "Product image"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of creation of the product")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                },
                comment: "Product table");

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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Cart identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Costumer identifier"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of creation of cart"),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Last date of modification of cart"),
                    IsOrdered = table.Column<bool>(type: "bit", nullable: false, comment: "Is the cart ordered")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Cart table");

            migrationBuilder.CreateTable(
                name: "Biscuits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Biscuit identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false, comment: "Biscuit quantity"),
                    CategoryId = table.Column<int>(type: "int", nullable: false, comment: "Category identifier"),
                    ProductId = table.Column<int>(type: "int", nullable: false, comment: "Product identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biscuits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Biscuits_BiscuitCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "BiscuitCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Biscuits_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Biscuit table");

            migrationBuilder.CreateTable(
                name: "Cakes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Cake identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Layers = table.Column<int>(type: "int", nullable: false, comment: "Cake layers"),
                    Form = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Cake form"),
                    Portions = table.Column<int>(type: "int", nullable: false, comment: "Cake portions"),
                    CategoryId = table.Column<int>(type: "int", nullable: false, comment: "Category identifier"),
                    ProductId = table.Column<int>(type: "int", nullable: false, comment: "Product identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cakes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cakes_CakeCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CakeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cakes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Cake table");

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "CartItem identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false, comment: "Cart identifier"),
                    ProductId = table.Column<int>(type: "int", nullable: true, comment: "AProduct identifier"),
                    Quantity = table.Column<int>(type: "int", nullable: false, comment: "Quantity of the product"),
                    Text = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false, comment: "Description of order"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "User's number")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                },
                comment: "Cart item");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Order identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User identifier"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of order"),
                    CartId = table.Column<int>(type: "int", nullable: false, comment: "Cart identifier"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, comment: "Soft delete property")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id");
                },
                comment: "Order table");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1182e1d8-c799-413d-a9d3-c809966f5ed2", 0, "5e18aa56-6d29-478f-bc8d-2d9564e008cd", "admin@abv.bg", false, "Admin", "Adminov", false, null, "ADMIN@ABV.bg", "ADMIN", "AQAAAAEAACcQAAAAEF6qg6RpleLMAdg21a8KzZdvspyc/qBFlZ3pSVxIsAX/VZFHm+dBpqNm18CR45WGfw==", null, false, "3a80c33b-39c7-4a42-a68f-c4adfabf0bc8", false, "admin@abv.bg" },
                    { "3b034442-ee41-4acb-92cb-374f72d60a59", 0, "7b025632-58e6-4470-8ffd-6307f06e4129", "g_ivanov@abv.bg", false, "Georgi", "Ivanov", false, null, "G_IVANOV@ABV.bg", "GOSHE", "AQAAAAEAACcQAAAAEMlinuui1xzh/+LJctBo3SX4oaaUe6GozHAMdcPr8rNPVC0VcKMUhCArMKh1ceGEVA==", null, false, "f7935196-bace-4331-8c62-a19316b008be", false, "g_ivanov@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "BiscuitCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Коледни" },
                    { 2, "Декоративни" },
                    { 3, "Специален повод" }
                });

            migrationBuilder.InsertData(
                table: "CakeCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Сватбена торта" },
                    { 2, "Детска торта" },
                    { 3, "Стандартна торта" },
                    { 4, "18+" },
                    { 5, "Специални поводи" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedOn", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5769), "~/images/seeding/cake/Pirates(Adriana 7).jpg", 100.00m, "Пирати(Адриана 7)" },
                    { 2, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5801), "~/images/seeding/cake/PinkSweet(Ivanina 8).jpg", 120.00m, "Розово сладко(Иванина 8)" },
                    { 3, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5804), "~/images/seeding/cake/Simba(Kiril 1).jpg", 150.00m, "Симба(Кирил 1)" },
                    { 4, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5807), "~/images/seeding/cake/Turning30.jpg", 120.00m, "Why, god, why?" },
                    { 5, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5810), "~/images/seeding/cake/BlueCakeWithFeathers.jpg", 110.00m, "Погачата на Георги" },
                    { 6, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5814), "~/images/seeding/cake/ToughtWay.jpg", 60.00m, "Препятствия по пътя" },
                    { 7, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5816), "~/images/seeding/cake/Karate(Vesko10).jpg", 70.00m, "Карате(Веско 10)" },
                    { 8, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5819), "~/images/seeding/cake/Barbie(Mariela 10).jpg", 65.00m, "Барби(Мариела 7)" },
                    { 9, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5821), "~/images/seeding/cake/AnimalPicnic(Nikola 1).jpg", 80.00m, "Мечо Пух(Никола 1)" },
                    { 10, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5825), "~/images/seeding/cake/BlueButterflies(Nikol 7).jpg", 50.00m, "Сини Пеперуди(Никол 7)" },
                    { 11, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5827), "~/images/seeding/cake/MiniMaus(Teodora 2).jpg", 80.00m, "Мини Маус(Теодора 2)" },
                    { 12, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5830), "~/images/seeding/cake/CristianRonaldo(Metodi 8).jpg", 100.00m, "Кристиано Роналдо(Методи 8)" },
                    { 13, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5832), "~/images/seeding/cake/PinkPrincess(Marieta 10).jpg", 150.00m, "Розова принцеса(Мариета 10)" },
                    { 14, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5835), "~/images/seeding/cake/RaceWithCars(Kristian 3).jpg", 120.00m, "Състезание с коли(Кристиян 3)" },
                    { 15, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5837), "~/images/seeding/cake/Hlapetata(Denis 5).jpg", 110.00m, "Хлапетата/Пирин(Денис 5)" },
                    { 16, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5840), "~/images/seeding/cake/PinkFlowers(Borisa 4).jpg", 60.00m, "Розови цветя(Бориса 4)" },
                    { 17, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5842), "~/images/seeding/cake/PinkGymnastic(Antonia 13).jpg", 70.00m, "Розова гимнастика(Антония 13)" },
                    { 18, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5846), "~/images/seeding/cake/Messi(Iliqn).jpg", 65.00m, "Аржентина/Меси(Илиян)" },
                    { 19, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5848), "~/images/seeding/cake/Lego(Adrian 3).jpg", 80.00m, "Лего(Адриан 3)" },
                    { 20, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5851), "~/images/seeding/cakes/GoldenRoses.jpg", 50.00m, "Златни рози" },
                    { 21, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5853), "~/images/seeding/biscuit/ChristmasTrees.jpg", 10.00m, "Коледни елхи" },
                    { 22, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5856), "~/images/seeding/biscuit/ChristmasFigures.jpg", 12.00m, "Коледни фигури" },
                    { 23, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5859), "~/images/seeding/biscuit/WinterFigures.jpg", 15.00m, "Зимни сладки" },
                    { 24, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5861), "~/images/seeding/biscuit/DecorativePonies.jpg", 13.00m, "Декоративни еднорози" },
                    { 25, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5864), "~/images/seeding/biscuit/SpringThema.jpg", 11.00m, "Пролетна тема" },
                    { 26, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5866), "~/images/seeding/biscuit/DecorativeKittens.jpg", 10.00m, "Декоративни котета" },
                    { 27, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5869), "~/images/seeding/biscuit/ChristmasBiscuits.jpg", 12.00m, "Коледни сладки" },
                    { 28, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5871), "~/images/seeding/biscuit/SpringLove.jpg", 15.00m, "Пролетна любов" },
                    { 29, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5873), "~/images/seeding/biscuit/BearsBonbons.jpg", 13.00m, "Бонбони мечки на клечка" },
                    { 30, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5876), "~/images/seeding/biscuit/MiniMaus.jpg", 11.00m, "Мини маус" },
                    { 31, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5878), "~/images/seeding/biscuit/BabysBiscuits.jpg", 10.00m, "Бебешки сладки" },
                    { 32, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5881), "~/images/seeding/biscuit/MikeyMaus.jpg", 12.00m, "Мики маус" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedOn", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 33, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5884), "~/images/seeding/biscuit/VetTime.jpg", 15.00m, "Vet time" },
                    { 34, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5887), "~/images/seeding/biscuit/FormMiniMaus.jpg", 13.00m, "Форма мини маус" },
                    { 35, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5890), "~/images/seeding/biscuit/MuffinsPony.jpg", 11.00m, "Кехчета еднорог" },
                    { 36, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5892), "~/images/seeding/biscuit/MuffinsMikeyMaus.jpg", 10.00m, "Кехчета мики маус" },
                    { 37, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5895), "~/images/seeding/biscuit/MuffinsWithBears.jpg", 12.00m, "Кехчета с мечета" },
                    { 38, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5897), "~/images/seeding/biscuit/FormOfOne.jpg", 15.00m, "Бисквити във формата на единица" },
                    { 39, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5900), "~/images/seeding/biscuit/Bears.jpg", 13.00m, "Меченца" },
                    { 40, new DateTime(2024, 4, 20, 20, 11, 56, 336, DateTimeKind.Local).AddTicks(5902), "~/images/seeding/biscuit/VierLeaf.jpg", 11.00m, "Четирилистна детелина" }
                });

            migrationBuilder.InsertData(
                table: "Biscuits",
                columns: new[] { "Id", "CategoryId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 21, 10 },
                    { 2, 1, 22, 8 },
                    { 3, 1, 23, 7 },
                    { 4, 2, 24, 6 },
                    { 5, 3, 25, 9 },
                    { 6, 2, 26, 8 },
                    { 7, 1, 27, 5 },
                    { 8, 3, 28, 4 },
                    { 9, 3, 29, 6 },
                    { 10, 3, 30, 8 },
                    { 11, 3, 31, 10 },
                    { 12, 3, 32, 7 },
                    { 13, 3, 33, 9 },
                    { 14, 2, 34, 6 },
                    { 15, 2, 35, 8 },
                    { 16, 2, 36, 5 },
                    { 17, 3, 37, 4 },
                    { 18, 3, 38, 2 },
                    { 19, 2, 39, 2 },
                    { 20, 3, 40, 2 }
                });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "Id", "CategoryId", "Form", "Layers", "Portions", "ProductId" },
                values: new object[,]
                {
                    { 1, 2, "кръгла", 1, 35, 1 },
                    { 2, 2, "кръгла", 1, 30, 2 },
                    { 3, 2, "кръгла", 1, 30, 3 },
                    { 4, 5, "кръгла", 1, 20, 4 },
                    { 5, 5, "кръгла", 1, 30, 5 },
                    { 6, 2, "кръгла", 2, 20, 6 },
                    { 7, 2, "кръгла", 1, 25, 7 },
                    { 8, 2, "кръгла", 1, 30, 8 },
                    { 9, 2, "кръгла", 1, 35, 9 },
                    { 10, 2, "кръгла", 1, 10, 10 },
                    { 11, 2, "кръгла", 1, 35, 11 },
                    { 12, 2, "кръгла", 1, 30, 12 },
                    { 13, 2, "кръгла", 1, 30, 13 },
                    { 14, 2, "правоъгълна", 1, 20, 14 },
                    { 15, 2, "кръгла", 2, 30, 15 },
                    { 16, 2, "правоъгълна", 1, 20, 16 },
                    { 17, 2, "правоъгълна", 1, 35, 17 },
                    { 18, 2, "кръгла", 2, 30, 18 },
                    { 19, 2, "кръгла", 1, 35, 19 },
                    { 20, 1, "кръгла", 2, 25, 20 }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedOn", "IsOrdered", "ModifiedOn", "UserId" },
                values: new object[] { 1, new DateTime(2024, 4, 20, 20, 11, 56, 338, DateTimeKind.Local).AddTicks(8123), false, new DateTime(2024, 4, 20, 20, 11, 56, 338, DateTimeKind.Local).AddTicks(8154), "3b034442-ee41-4acb-92cb-374f72d60a59" });

            migrationBuilder.InsertData(
                table: "CartItems",
                columns: new[] { "Id", "CartId", "PhoneNumber", "ProductId", "Quantity", "Text" },
                values: new object[,]
                {
                    { 1, 1, "+398987645", 1, 1, "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10." },
                    { 2, 1, "+398987645", 2, 1, "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10." },
                    { 4, 1, "+398987645", null, 1, "Бих искал торта с леги нинджаго ако може да е за 30 парчета за Иван на 10." },
                    { 5, 1, "+398987645", 8, 1, "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10." },
                    { 6, 1, "+398987645", 2, 1, "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10." },
                    { 7, 1, "+398987645", 10, 1, "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10." },
                    { 8, 1, "+398987645", null, 1, "Бих искал обикновена синя торта само ако може да е за 20 парчета без име." }
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
                name: "IX_Biscuits_CategoryId",
                table: "Biscuits",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Biscuits_ProductId",
                table: "Biscuits",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Cakes_CategoryId",
                table: "Cakes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cakes_ProductId",
                table: "Cakes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CartId",
                table: "Orders",
                column: "CartId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

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
                name: "Biscuits");

            migrationBuilder.DropTable(
                name: "Cakes");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "BiscuitCategories");

            migrationBuilder.DropTable(
                name: "CakeCategories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
