using System;
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
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
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
                    CartId = table.Column<int>(type: "int", nullable: false, comment: "Cart identifier"),
                    ProductId = table.Column<int>(type: "int", nullable: false, comment: "Product identifier"),
                    Id = table.Column<int>(type: "int", nullable: false, comment: "CartItem identifier"),
                    Quantity = table.Column<int>(type: "int", nullable: false, comment: "Quantity of the product"),
                    Text = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false, comment: "Description of order"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Description of order")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => new { x.CartId, x.ProductId });
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    CartId = table.Column<int>(type: "int", nullable: false, comment: "Cart identifier")
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

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "OrderItem identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false, comment: "Order identifier"),
                    ProductId = table.Column<int>(type: "int", nullable: false, comment: "Product identifier"),
                    Quantity = table.Column<int>(type: "int", nullable: false, comment: "Quantity of the product"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Product price")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Order item table");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1182e1d8-c799-413d-a9d3-c809966f5ed2", 0, "437233d1-0cdf-4d68-a3c2-f1e72a100bf7", "admin@abv.bg", false, "Boris", "Anastasov", false, null, "ADMIN@ABV.bg", "ADMIN", "AQAAAAEAACcQAAAAEPsmoYC+HOAs7WiyUec+EoIhWQ5JZjch9uZ2aZJTdtArIdzKX+Av84ItK3pnLf9Low==", null, false, "9f8d62fc-7734-481b-a240-22e3730e9989", false, "Admin" },
                    { "3b034442-ee41-4acb-92cb-374f72d60a59", 0, "00f42319-3e06-451e-b9ee-dbe1ca319f4f", "g_ivanov@abv.bg", false, "Georgi", "Ivanov", false, null, "G_IVANOV@ABV.bg", "GOSHE", "AQAAAAEAACcQAAAAEDgxvDCuBSGaBx/MMNgYKCX1NNJb4miA7wqbzyPdStvPpp58M4oMHn6x4Bv7sRkXhQ==", null, false, "399b8eab-8228-4609-bf63-4c2b5e0c89cc", false, "Goshe" }
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
                    { 1, new DateTime(2024, 4, 5, 19, 13, 47, 690, DateTimeKind.Local).AddTicks(5823), "https://scontent-sof1-1.xx.fbcdn.net/v/t1.6435-9/45418292_1900224123436935_5112515879866728448_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=5f2048&_nc_ohc=eFIio2QbBlEAX9Yzjue&_nc_ht=scontent-sof1-1.xx&oh=00_AfBoQ7qqdl47HZ7hWnAk-no9njwdW7bf1dMJizkc5xCsOQ&oe=6613AA58", 100.00m, "Съпруг и съпруга със сини и бели рози" },
                    { 2, new DateTime(2024, 4, 5, 19, 13, 47, 690, DateTimeKind.Local).AddTicks(5854), "https://scontent-sof1-1.xx.fbcdn.net/v/t31.18172-8/11950324_881502548642436_5301516909345454510_o.jpg?_nc_cat=100&ccb=1-7&_nc_sid=5f2048&_nc_ohc=im4NrlMRDwoAX906LIT&_nc_ht=scontent-sof1-1.xx&oh=00_AfANMiRCdEFjBHMKqzdVQ8CfmwHERZjyswaGHkTpw3deDw&oe=66139F73", 120.00m, "Златни рози" },
                    { 3, new DateTime(2024, 4, 5, 19, 13, 47, 690, DateTimeKind.Local).AddTicks(5857), "https://scontent-sof1-2.xx.fbcdn.net/v/t1.6435-9/118890298_3193596277433040_3828589938106568560_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=5f2048&_nc_ohc=dMYD1Y2twPAAX-5TIdq&_nc_oc=AQmB6ydQvkgot9gup32CReBa78Uc9nJ0lxvLge5csyOGMtoviBAviNqd5ot6C3mvjZ4&_nc_ht=scontent-sof1-2.xx&oh=00_AfCKvMW1pK86G0-3Uvc3A4efBy5a7ZXvntK3EIguunlpsg&oe=6613AE2C", 150.00m, "Съпруг и съпруга с червени рози и бели цветя" },
                    { 4, new DateTime(2024, 4, 5, 19, 13, 47, 690, DateTimeKind.Local).AddTicks(5859), "https://scontent.fsof10-1.fna.fbcdn.net/v/t31.18172-8/11940464_881502551975769_3150965239804644226_o.jpg?_nc_cat=111&ccb=1-7&_nc_sid=5f2048&_nc_ohc=lIiz0CvrQOAAX8yrHv6&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDS01MUNTFuECPkpvob8zZZXmMJKbYgvCTwQahwOQCQIg&oe=6620333B", 120.00m, "бели цветя" },
                    { 5, new DateTime(2024, 4, 5, 19, 13, 47, 690, DateTimeKind.Local).AddTicks(5862), "https://scontent.fsof10-1.fna.fbcdn.net/v/t1.6435-9/81678509_2608157715976902_8711874778027261952_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=5f2048&_nc_ohc=dn9ncHjKXt8AX8V4imn&_nc_oc=Adjiqz8TQNQuH0VsI2W2J8AQwDjcgr4XPGHPeTXPJ2qkeaZqY5bGxFIsMXkoAPWg4Jo&_nc_ht=scontent.fsof10-1.fna&oh=00_AfAjqqJ0cgKuP1WozZm7dEPBE_51dVR12bcJ2UmxChzeYg&oe=66201CA0", 110.00m, "бели цветя" },
                    { 6, new DateTime(2024, 4, 5, 19, 13, 47, 690, DateTimeKind.Local).AddTicks(6321), "https://scontent-sof1-2.xx.fbcdn.net/v/t1.6435-9/137404609_3542798825846115_8434655239208905708_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=5f2048&_nc_ohc=6mljKPhHnjIAX9LqFQP&_nc_ht=scontent-sof1-2.xx&oh=00_AfBpxiR_gQOHHryQJJG74wnITMjeC-uP-D7yn1swVD6-9w&oe=6630BA9C", 60.00m, "Ауди (Христо 20)" },
                    { 7, new DateTime(2024, 4, 5, 19, 13, 47, 690, DateTimeKind.Local).AddTicks(6327), "https://scontent-sof1-2.xx.fbcdn.net/v/t1.6435-9/140654272_3565104620282202_1586972040598179455_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=5f2048&_nc_ohc=Vj0NGhYBi5UAX8K_V_D&_nc_oc=AdhlsQ819_EuGRxSBpmepYYaVVPNKFAYniEjOeksAzIo73lVtWBOfl5WxyqG1XiN4Dg&_nc_ht=scontent-sof1-2.xx&oh=00_AfC9AO_padKrBp4jE-hg43Wd9pRoGwVrfaOVaUdMvX6yLw&oe=6630D046", 70.00m, "Тик ток (Краси 9)" },
                    { 8, new DateTime(2024, 4, 5, 19, 13, 47, 690, DateTimeKind.Local).AddTicks(6330), "https://scontent-sof1-2.xx.fbcdn.net/v/t1.6435-9/141452606_3575133479279316_4925539086264007770_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=5f2048&_nc_ohc=2fq3kZ-mCbQAX8H16po&_nc_ht=scontent-sof1-2.xx&oh=00_AfCaQLmus1wBRboVdTFOEANkgvgwaROC7cLRXmUxpxSK8g&oe=6630B930", 65.00m, "Stranger Things (Емануела 12)" },
                    { 9, new DateTime(2024, 4, 5, 19, 13, 47, 690, DateTimeKind.Local).AddTicks(6332), "https://scontent-sof1-1.xx.fbcdn.net/v/t1.6435-9/144275472_3592112990914698_7625468473701199444_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=5f2048&_nc_ohc=0U-MJHaY2wcAX-Ulp2B&_nc_ht=scontent-sof1-1.xx&oh=00_AfB9kj9vo2afu6ByV-zqG_1Xhr86byOFMxbmJoRDyE-nIg&oe=6630C891", 80.00m, "Шоколад, портокал и уиски (Юбилей 50)" },
                    { 10, new DateTime(2024, 4, 5, 19, 13, 47, 690, DateTimeKind.Local).AddTicks(6339), "https://scontent-sof1-2.xx.fbcdn.net/v/t1.6435-9/144577998_3598291693630161_1749300887982667483_n.jpg?_nc_cat=111&ccb=1-7&_nc_sid=5f2048&_nc_ohc=-LGMg0ot0EkAX8TkT1w&_nc_ht=scontent-sof1-2.xx&oh=00_AfBxnZXhfdImfFwWDpZcFHSjWwyx0dVw9SoN_ujnIvrTWg&oe=6630C07C", 50.00m, "Бебе Бос (Николай 1/2)" },
                    { 11, new DateTime(2024, 4, 5, 19, 13, 47, 690, DateTimeKind.Local).AddTicks(6342), "https://scontent.fsof10-1.fna.fbcdn.net/v/t1.6435-9/127996258_3428591943933471_6613145035034934063_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=5f2048&_nc_ohc=rPtEwbVYSpsAX8PKZXU&_nc_ht=scontent.fsof10-1.fna&oh=00_AfD393zUJS7ZhFbPMSxqEvvGouqHlkLrInYKA97sq2Hdvg&oe=6624BF3F", 10.00m, "Коледни елхи" },
                    { 12, new DateTime(2024, 4, 5, 19, 13, 47, 690, DateTimeKind.Local).AddTicks(6344), "https://scontent.fsof10-1.fna.fbcdn.net/v/t1.18169-9/12301697_913490672110290_3131707004579174335_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=5f2048&_nc_ohc=ORKDJKSWeZoAX_k70au&_nc_ht=scontent.fsof10-1.fna&oh=00_AfCU2TCno1TEOAxjtlDR3eVOY3eJcWK_lWlPD7c2VyMphg&oe=6624A21A", 12.00m, "Коледни фигури" },
                    { 13, new DateTime(2024, 4, 5, 19, 13, 47, 690, DateTimeKind.Local).AddTicks(6347), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/346885612_1175653887168525_5354008429856402980_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=5f2048&_nc_ohc=hObhR06Be5kAX-tTgc6&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDokQeGR3jVPFokGOf4T-2ErzAqwXyrUMnNwn7NHqgQdw&oe=66025108", 15.00m, "Еднорог" },
                    { 14, new DateTime(2024, 4, 5, 19, 13, 47, 690, DateTimeKind.Local).AddTicks(6349), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/429942016_1126158058806458_357351569670082917_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=5f2048&_nc_ohc=52_xuh-8AD8AX8IJkDL&_nc_ht=scontent.fsof10-1.fna&oh=00_AfC2GOft8pteFCSZoG6CAy8Ot_y5swfu7kOtrW4GqwPhkw&oe=6602E783", 13.00m, "Баба Марта" },
                    { 15, new DateTime(2024, 4, 5, 19, 13, 47, 690, DateTimeKind.Local).AddTicks(6352), "https://scontent-sof1-2.xx.fbcdn.net/v/t31.18172-8/13767216_1052053388254017_5059430311043810834_o.jpg?_nc_cat=107&ccb=1-7&_nc_sid=5f2048&_nc_ohc=4rgx72Z99dsAX8T8yY9&_nc_ht=scontent-sof1-2.xx&oh=00_AfD7EXfGxSBOaVttui_hAOofFJXB-E7elqHjskgoEr5yHA&oe=6630E30F", 11.00m, "Пролетна тема" }
                });

            migrationBuilder.InsertData(
                table: "Biscuits",
                columns: new[] { "Id", "CategoryId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 11, 10 },
                    { 2, 1, 12, 8 },
                    { 3, 3, 13, 10 },
                    { 4, 3, 14, 12 },
                    { 5, 3, 15, 20 }
                });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "Id", "CategoryId", "Form", "Layers", "Portions", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, "кръгла", 3, 35, 1 },
                    { 2, 1, "кръгла", 2, 30, 2 },
                    { 3, 1, "кръгла", 2, 30, 3 },
                    { 4, 2, "кръгла", 1, 20, 4 },
                    { 5, 1, "кръгла", 2, 30, 5 },
                    { 6, 5, "кръгла", 1, 20, 6 },
                    { 7, 2, "кръгла", 2, 25, 7 },
                    { 8, 2, "кръгла", 1, 30, 8 },
                    { 9, 5, "кръгла", 1, 35, 9 },
                    { 10, 2, "полукръгла", 1, 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedOn", "IsOrdered", "ModifiedOn", "UserId" },
                values: new object[] { 1, new DateTime(2024, 4, 5, 19, 13, 47, 692, DateTimeKind.Local).AddTicks(9052), false, new DateTime(2024, 4, 5, 19, 13, 47, 692, DateTimeKind.Local).AddTicks(9071), "1182e1d8-c799-413d-a9d3-c809966f5ed2" });

            migrationBuilder.InsertData(
                table: "CartItems",
                columns: new[] { "CartId", "ProductId", "Id", "PhoneNumber", "Quantity", "Text" },
                values: new object[] { 1, 1, 1, "0884567234", 1, "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10." });

            migrationBuilder.InsertData(
                table: "CartItems",
                columns: new[] { "CartId", "ProductId", "Id", "PhoneNumber", "Quantity", "Text" },
                values: new object[] { 1, 2, 2, "0884567234", 1, "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10." });

            migrationBuilder.InsertData(
                table: "CartItems",
                columns: new[] { "CartId", "ProductId", "Id", "PhoneNumber", "Quantity", "Text" },
                values: new object[] { 1, 3, 3, "0884567234", 1, "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10." });

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
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

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
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "BiscuitCategories");

            migrationBuilder.DropTable(
                name: "CakeCategories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
