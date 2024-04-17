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
                    { "1182e1d8-c799-413d-a9d3-c809966f5ed2", 0, "ae4207de-727d-4330-adf4-c547ff211322", "admin@abv.bg", false, "Admin", "Adminov", false, null, "ADMIN@ABV.bg", "ADMIN", "AQAAAAEAACcQAAAAECYkIS66jU9QQ6mc6dFGWAGtsA03tJw3RkxlbSJsTtVHAu+jiL3qhPS7WmPY/4KRPw==", null, false, "226f4b7e-17ca-47d7-b36d-e116543c640e", false, "admin@abv.bg" },
                    { "3b034442-ee41-4acb-92cb-374f72d60a59", 0, "4df23aa4-1a70-4366-abe9-42383f0f421d", "g_ivanov@abv.bg", false, "Georgi", "Ivanov", false, null, "G_IVANOV@ABV.bg", "GOSHE", "AQAAAAEAACcQAAAAEPXl4Br0NlVh3tTU0MFtYH0ZcQxDMf2YWZkAhbjQSE7KHVIdtEnML0WKDQNBQZyzHA==", null, false, "dac86207-fc5a-4197-b56e-f935899e6093", false, "g_ivanov@abv.bg" }
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
                    { 1, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2769), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/418972033_1093443198744611_18295542256863659_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=5f2048&_nc_ohc=oyt_fYQxpqQAb5wlkX3&_nc_ht=scontent.fsof10-1.fna&oh=00_AfAq--jLQ5hLqOijtXT5wzON89KBi5WPe4zaYN49JBTEXA&oe=66234802", 100.00m, "Пирати(Адриана 7)" },
                    { 2, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2805), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/419883159_1096690305086567_9154400905867001135_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=5f2048&_nc_ohc=gqYPb7qhPtsAb4iSrqn&_nc_ht=scontent.fsof10-1.fna&oh=00_AfCk3kEV0NX_qoP0VkVRiebWy7Im1H9MGdvlERnwPmVPaw&oe=66233F51", 120.00m, "Розово сладко(Иванина 8)" },
                    { 3, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2808), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/419814170_1096690445086553_5920770385650976907_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=5f2048&_nc_ohc=yL0QHtExJ9MAb6_q7wH&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDrTCMRxqDTpIfk4tXAoMzxO8lgSfCgpztL3btPJas8jQ&oe=662362CF", 150.00m, "Симба(Кирил 1)" },
                    { 4, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2810), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/419895981_1096690478419883_5265202540193795239_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=5f2048&_nc_ohc=s-BHu3ex-q8Ab6uHFDB&_nc_ht=scontent.fsof10-1.fna&oh=00_AfA-XudfSZAwJ5b_WxbFMTgwWf4RyaHMgN0OE0zCtWs_EQ&oe=66235113", 120.00m, "Why, god, why?" },
                    { 5, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2813), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/420271104_1099055744850023_5401028707936950121_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=5f2048&_nc_ohc=ilC9jJPAWI4Ab6rAiX5&_nc_ht=scontent.fsof10-1.fna&oh=00_AfBRVrXVCUcnYE0x6zvThlbpjyw2w0ehTrkhMGOhq4KTPA&oe=66234BBF", 110.00m, "Погачата на Георги" },
                    { 6, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2816), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/421273451_1100972814658316_2601163674327323390_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=5f2048&_nc_ohc=IP9MBVAOblAAb6EO1G1&_nc_ht=scontent.fsof10-1.fna&oh=00_AfCmPwO7mWsQCMbO7Odnel69USm1kH9spgWawU6Sldn5gQ&oe=662353D7", 60.00m, "Препятствия по пътя" },
                    { 7, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2819), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/421003139_1100973004658297_8756545305937455944_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=5f2048&_nc_ohc=BcWMOIWll9cAb5Ih1TL&_nc_ht=scontent.fsof10-1.fna&oh=00_AfC250frGZak90Hv-gTE7N3SNU3SQ1ZXrXjskefrhxSn9A&oe=66234690", 70.00m, "Карате(Веско 10)" },
                    { 8, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2821), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/421307138_1100973057991625_4347484741087024842_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=5f2048&_nc_ohc=S0oVgoVPVMIAb4Hucnw&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDSI_2CwdWu5xmcwmmZ7bu0N7y8_i3keoPXegTZ-1hCoA&oe=66236B33", 65.00m, "Барби(Мариела 7)" },
                    { 9, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2824), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/421305166_1100973174658280_3232378763777122331_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=5f2048&_nc_ohc=R4NYSjlEX9AAb6WnTxC&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDcbMLGgbShkm0ol086Q2EkcLN23V2fJ9YSGrJQpuqPXA&oe=662348EF", 80.00m, "Мечо Пух(Никола 1)" },
                    { 10, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2827), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/422453926_1103927064362891_1200521909121655771_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=5f2048&_nc_ohc=ZIy3sO497vcAb68LxRu&_nc_ht=scontent.fsof10-1.fna&oh=00_AfBukpcRHGQ5RYzy24loiAyuH18GZznNHA_jIi5e3zyk2w&oe=66235C34", 50.00m, "Сини Пеперуди(Никол 7)" },
                    { 11, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2829), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/422917578_1103927104362887_2140454483848022782_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=5f2048&_nc_ohc=eOvOV-fhrVEAb634ibP&_nc_ht=scontent.fsof10-1.fna&oh=00_AfB9cekCjuO5MZZ33zx8q_JghkOZmrPogD_x7wGp1YIbow&oe=6623411C", 80.00m, "Мини Маус(Теодора 2)" },
                    { 12, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2832), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/422283046_1103927131029551_320020852122884371_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=5f2048&_nc_ohc=PhEHWe1_m-QAb75WnYN&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDKi9xqOjHabPgjJoGBMzx3cc5DqzIFHsgOtr8-JE0SrA&oe=66233FD9", 100.00m, "Кристиано Роналдо(Методи 8)" },
                    { 13, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2834), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/421992174_1103927164362881_2666073469233497469_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=5f2048&_nc_ohc=GX25z23w5rcAb4KrcKH&_nc_ht=scontent.fsof10-1.fna&oh=00_AfByo6aJlE_Ba8y1okKX6-W5kJO7NB_fRYG4vx6byH96vA&oe=66234021", 150.00m, "Розова принцеса(Мариета 10)" },
                    { 14, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2837), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/422395532_1103927251029539_8137194788006343813_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=5f2048&_nc_ohc=LO9gVorGTSwAb47oA1-&_nc_ht=scontent.fsof10-1.fna&oh=00_AfAYzQlhoRH2fxmdGB5mWLk4HjdxQS5Q7r-4NoVf0nJZFg&oe=6623556B", 120.00m, "Състезание с коли(Кристиян 3)" },
                    { 15, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2839), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/422434325_1103927354362862_6819850698041677940_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=5f2048&_nc_ohc=ukNWu9a7loMAb7ZcZw-&_nc_ht=scontent.fsof10-1.fna&oh=00_AfD2dTbQWL1XwH5fNRhDIB6lN3yPrHWUUkyVO05H3ysOqg&oe=662374B7", 110.00m, "Хлапетата/Пирин(Денис 5)" },
                    { 16, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2841), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/422903500_1103933321028932_6325247546336233728_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=5f2048&_nc_ohc=EZVht7CFsBAAb74jNz7&_nc_ht=scontent.fsof10-1.fna&oh=00_AfC4YIei0A5QDbwhJfNazjXgjmfw3HAHYw355iCKfaQh4w&oe=662355C3", 60.00m, "Розови цветя(Бориса 4)" },
                    { 17, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2844), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/422123188_1103933404362257_1707931504307280465_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=5f2048&_nc_ohc=woNTec0Hgy0Ab4fHTmr&_nc_ht=scontent.fsof10-1.fna&oh=00_AfAf_kINoy3ZLN9sFSkoUD9plIOeZyoVwp-9p35ADQvKQA&oe=66234D99", 70.00m, "Розова гимнастика(Антония 13)" },
                    { 18, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2847), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/422337680_1103933437695587_2768842852153729910_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=5f2048&_nc_ohc=n6kzvpKHKYMAb6zpLwr&_nc_ht=scontent.fsof10-1.fna&oh=00_AfBHtcU1DObFEYGgH-rsdv3w7fH7n-zcWRFnT5T34Yk5sg&oe=66234479", 65.00m, "Аржентина/Меси(Илиян)" },
                    { 19, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2850), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/422945261_1104870920935172_7448345022192442547_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=5f2048&_nc_ohc=jJ0e0YC9QSsAb65AEiE&_nc_ht=scontent.fsof10-1.fna&oh=00_AfADr8k4touilXWuDeGR0c_vO1UdvnZPEZQuxqZ7xoJg7g&oe=662356BB", 80.00m, "Лего(Адриан 3)" },
                    { 20, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2852), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/422954610_1104870957601835_5166553921804153623_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=5f2048&_nc_ohc=03q5H16CEqIAb6Bx76T&_nc_ht=scontent.fsof10-1.fna&oh=00_AfCKtxi9DJ37h8NyQMt929wOjM4PNwLpcRU7Y04YYRxywQ&oe=6623553B", 50.00m, "Джунгла/животни(Марти 2)" },
                    { 21, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2854), "https://scontent.fsof10-1.fna.fbcdn.net/v/t1.6435-9/127996258_3428591943933471_6613145035034934063_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=5f2048&_nc_ohc=rPtEwbVYSpsAX8PKZXU&_nc_ht=scontent.fsof10-1.fna&oh=00_AfD393zUJS7ZhFbPMSxqEvvGouqHlkLrInYKA97sq2Hdvg&oe=6624BF3F", 10.00m, "Коледни елхи" },
                    { 22, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2857), "https://scontent.fsof10-1.fna.fbcdn.net/v/t1.18169-9/12301697_913490672110290_3131707004579174335_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=5f2048&_nc_ohc=ORKDJKSWeZoAX_k70au&_nc_ht=scontent.fsof10-1.fna&oh=00_AfCU2TCno1TEOAxjtlDR3eVOY3eJcWK_lWlPD7c2VyMphg&oe=6624A21A", 12.00m, "Коледни фигури" },
                    { 23, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2859), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/414659694_1083679999720931_4686156170598756137_n.jpg?_nc_cat=109&ccb=1-7&_nc_sid=5f2048&_nc_ohc=as37wfBwQK8Ab5Mug42&_nc_ht=scontent.fsof10-1.fna&oh=00_AfCGK-reC7PqEOLEWwwzko1sROVZ_8CWj8q-W3YZtNi-0A&oe=66240241", 15.00m, "Зимни сладки" },
                    { 24, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2862), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/346885612_1175653887168525_5354008429856402980_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=5f2048&_nc_ohc=J8pQ0qQs7kAAb4s2bc_&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDJ68lAKqg0E20ah8YVoP4tpvzw3Zxktb1IyES2U4Vwmw&oe=6623EF48", 13.00m, "Декоративни еднорози" },
                    { 25, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2864), "https://scontent-sof1-2.xx.fbcdn.net/v/t31.18172-8/13767216_1052053388254017_5059430311043810834_o.jpg?_nc_cat=107&ccb=1-7&_nc_sid=5f2048&_nc_ohc=4rgx72Z99dsAX8T8yY9&_nc_ht=scontent-sof1-2.xx&oh=00_AfD7EXfGxSBOaVttui_hAOofFJXB-E7elqHjskgoEr5yHA&oe=6630E30F", 11.00m, "Пролетна тема" },
                    { 26, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2867), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/347598820_1462268427940551_3378899760043768216_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=5f2048&_nc_ohc=ssELXekml1UAb74Lw3p&_nc_ht=scontent.fsof10-1.fna&oh=00_AfC0Ewx8gIUxsz0I7sadvlZYWCtWMOpEAsoaBtjIrAyw8A&oe=66240EBF", 10.00m, "Декоративни котета" },
                    { 27, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2869), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/408289112_1069083081180623_6103859634370956242_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=5f2048&_nc_ohc=mv2MUmF-QO8Ab7EfHv7&_nc_ht=scontent.fsof10-1.fna&oh=00_AfAMXi1gUAJXuSVoXopY7PIiihmWD1lAth0tzDis9JXyuw&oe=66240F1D", 12.00m, "Коледни сладки" },
                    { 28, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2871), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/338166827_548900843899794_5385569313968380087_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=5f2048&_nc_ohc=PSCgPeCXrgcAb6j9QsW&_nc_ht=scontent.fsof10-1.fna&oh=00_AfATy6VoG94Cjh2NstybjuKj7sEvlXYDGyHO0ZFwaTaQEQ&oe=66242223", 15.00m, "Бонбони пеперуди на клечка" },
                    { 29, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2874), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/338166827_548900843899794_5385569313968380087_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=5f2048&_nc_ohc=PSCgPeCXrgcAb6j9QsW&_nc_ht=scontent.fsof10-1.fna&oh=00_AfATy6VoG94Cjh2NstybjuKj7sEvlXYDGyHO0ZFwaTaQEQ&oe=66242223", 13.00m, "Бонбони мечки на клечка" },
                    { 30, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2876), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/340453821_634241451866643_5453280737476644845_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=5f2048&_nc_ohc=87i6kF4Ax98Ab4awAYD&_nc_ht=scontent.fsof10-1.fna&oh=00_AfA3MikW3e7agHZSVd4jqjP-v4rTxNW0EUzjduG4CbmMDg&oe=66241D17", 11.00m, "Мини маус" },
                    { 31, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2878), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/370618359_1006912454064353_122421549472800615_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=5f2048&_nc_ohc=y_c-d4EXHPkAb6e8OeC&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDJ1pkGVuhbluUh4dSsyzTegN9yH9N5MqzKQjcHC_oGJg&oe=662406BD", 10.00m, "Бебешки сладки" },
                    { 32, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2881), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/395350593_1045984213490510_5049859778982539766_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=5f2048&_nc_ohc=-uaRfcy596cAb6O7E27&_nc_ht=scontent.fsof10-1.fna&oh=00_AfAewl4G0thADHLGKiM4rMrSJPJewbKZQ7KAETgMxt5Urw&oe=66240481", 12.00m, "Мини маус" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedOn", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 33, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2883), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/412367668_1078476133574651_2014438863321533166_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=5f2048&_nc_ohc=mK10dhm9R6IAb7eU1ZD&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDSYSsBkrpfhDSTcIhp5UvVFMv9HMJ5zp6r-Fsz5N0K5w&oe=6624123D", 15.00m, "Vet time" },
                    { 34, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2887), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/412421912_1079066630182268_8849429455852772027_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=5f2048&_nc_ohc=b7_xw_AY00YAb4G4USq&_nc_ht=scontent.fsof10-1.fna&oh=00_AfBxwx2uLEDjZtvETiTF_PJtjEfpJAwarVUuIUHib9qNZg&oe=6624254C", 13.00m, "Форма мини маус" },
                    { 35, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2889), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/273151658_4726256077500378_6856753579275926019_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=5f2048&_nc_ohc=yfjlzEaBXswAb7NuBhi&_nc_ht=scontent.fsof10-1.fna&oh=00_AfASCVabXp4kXs0HV1oeLfu7xOkOQz8CC5fYXuFsgC8o0A&oe=66240545", 11.00m, "Кехчета еднорог" },
                    { 36, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2891), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/273049030_4737053996420586_5343548874095564690_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=5f2048&_nc_ohc=iG5P5AF1HXkAb6Vt5n3&_nc_ht=scontent.fsof10-1.fna&oh=00_AfBunWEQPHjrel3Lq1DrsmVGbCPp768asWGQdmA-spF19A&oe=6623FAF4", 10.00m, "Кехчета мики маус" },
                    { 37, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2894), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/275972733_4852334931559158_4876683130673051345_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=5f2048&_nc_ohc=kRjcinr4qo0Ab4CZZ8U&_nc_ht=scontent.fsof10-1.fna&oh=00_AfAaSiY_pT9eZ7bGGXmwHemkUSg-OeZHxn_h9y-exNDTJg&oe=66240D76", 12.00m, "Кехчета с мечета" },
                    { 38, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2896), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/275888286_4854907834635201_5576219607842184040_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=5f2048&_nc_ohc=kIBlo0Frm8cAb5nTa0I&_nc_ht=scontent.fsof10-1.fna&oh=00_AfBVIdHdb4B3_nh2m6JVLQDlDsoPF093SXrHdgBGTNkYSg&oe=6623F44E", 15.00m, "Бисквити във формата на единица" },
                    { 39, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2899), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/278182286_4910435082415809_8231988911027352607_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=5f2048&_nc_ohc=zj0DGN2EyjMAb6g6E5n&_nc_ht=scontent.fsof10-1.fna&oh=00_AfBvUrNy0HtVFYqLWzY6C-t5_H2refxaZvBFfTEbZY0ZFw&oe=6623F7F8", 13.00m, "Меченца" },
                    { 40, new DateTime(2024, 4, 17, 19, 33, 15, 371, DateTimeKind.Local).AddTicks(2901), "https://scontent.fsof10-1.fna.fbcdn.net/v/t1.6435-9/82200699_2623632034429470_7680587017826074624_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=5f2048&_nc_ohc=6G_BPMiyr-MAb7F2cJX&_nc_ht=scontent.fsof10-1.fna&oh=00_AfAmCjYKJf4atPcvS1AKyw1Yiq4pfMxJpAgzXizkdoYPHA&oe=66459706", 11.00m, "Четирилистна детелина" }
                });

            migrationBuilder.InsertData(
                table: "Biscuits",
                columns: new[] { "Id", "CategoryId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 21, 10 },
                    { 2, 1, 22, 8 },
                    { 3, 1, 23, 7 },
                    { 4, 1, 24, 6 },
                    { 5, 1, 25, 9 },
                    { 6, 1, 26, 8 },
                    { 7, 1, 27, 5 },
                    { 8, 1, 28, 4 },
                    { 9, 1, 29, 6 },
                    { 10, 1, 30, 8 },
                    { 11, 3, 31, 10 },
                    { 12, 3, 32, 7 },
                    { 13, 3, 33, 9 },
                    { 14, 3, 34, 6 },
                    { 15, 3, 35, 8 },
                    { 16, 3, 36, 5 },
                    { 17, 3, 37, 4 },
                    { 18, 3, 38, 2 },
                    { 19, 3, 39, 2 },
                    { 20, 3, 40, 2 }
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
                    { 6, 2, "кръгла", 1, 20, 6 },
                    { 7, 2, "кръгла", 2, 25, 7 },
                    { 8, 2, "кръгла", 1, 30, 8 },
                    { 9, 3, "кръгла", 1, 35, 9 },
                    { 10, 2, "полукръгла", 1, 10, 10 },
                    { 11, 1, "кръгла", 3, 35, 11 },
                    { 12, 1, "кръгла", 2, 30, 12 },
                    { 13, 1, "кръгла", 2, 30, 13 },
                    { 14, 2, "кръгла", 1, 20, 14 },
                    { 15, 1, "кръгла", 2, 30, 15 },
                    { 16, 2, "кръгла", 1, 20, 16 },
                    { 17, 2, "кръгла", 2, 25, 17 },
                    { 18, 2, "кръгла", 1, 30, 18 },
                    { 19, 5, "кръгла", 1, 35, 19 },
                    { 20, 2, "полукръгла", 1, 10, 20 }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedOn", "IsOrdered", "ModifiedOn", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 17, 19, 33, 15, 373, DateTimeKind.Local).AddTicks(4651), false, new DateTime(2024, 4, 17, 19, 33, 15, 373, DateTimeKind.Local).AddTicks(4656), "1182e1d8-c799-413d-a9d3-c809966f5ed2" },
                    { 2, new DateTime(2024, 4, 17, 19, 33, 15, 373, DateTimeKind.Local).AddTicks(4660), false, new DateTime(2024, 4, 17, 19, 33, 15, 373, DateTimeKind.Local).AddTicks(4662), "3b034442-ee41-4acb-92cb-374f72d60a59" }
                });

            migrationBuilder.InsertData(
                table: "CartItems",
                columns: new[] { "Id", "CartId", "PhoneNumber", "ProductId", "Quantity", "Text" },
                values: new object[,]
                {
                    { 1, 1, "+398987645", 1, 1, "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10." },
                    { 2, 1, "+398987645", 2, 1, "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10." },
                    { 4, 1, "+398987645", null, 1, "Бих искал торта с леги нинджаго ако може да е за 30 парчета за Иван на 10." },
                    { 5, 2, "+398987645", 8, 1, "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10." },
                    { 6, 2, "+398987645", 2, 1, "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10." },
                    { 7, 2, "+398987645", 10, 1, "Бих искал такава торта само ако може да е за 30 парчета за Иван на 10." },
                    { 8, 2, "+398987645", null, 1, "Бих искал обикновена синя торта само ако може да е за 20 парчета без име." }
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
