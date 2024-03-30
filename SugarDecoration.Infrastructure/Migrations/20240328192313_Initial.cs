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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiscuitCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CakeCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CakeCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
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
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CostumerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_CostumerId",
                        column: x => x.CostumerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Biscuits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "Cakes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Layers = table.Column<int>(type: "int", nullable: false),
                    Form = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Portions = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CostumerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_CostumerId",
                        column: x => x.CostumerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartsProducts",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartsProducts", x => new { x.CartId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_CartsProducts_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartsProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                columns: new[] { "Id", "CreatedOn", "ImageUrl", "Price", "Rating", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 28, 21, 23, 13, 688, DateTimeKind.Local).AddTicks(9454), "https://scontent-sof1-1.xx.fbcdn.net/v/t1.6435-9/45418292_1900224123436935_5112515879866728448_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=5f2048&_nc_ohc=eFIio2QbBlEAX9Yzjue&_nc_ht=scontent-sof1-1.xx&oh=00_AfBoQ7qqdl47HZ7hWnAk-no9njwdW7bf1dMJizkc5xCsOQ&oe=6613AA58", 100.0, 0.0, "Съпруг и съпруга със сини и бели рози" },
                    { 2, new DateTime(2024, 3, 28, 21, 23, 13, 688, DateTimeKind.Local).AddTicks(9484), "https://scontent-sof1-1.xx.fbcdn.net/v/t31.18172-8/11950324_881502548642436_5301516909345454510_o.jpg?_nc_cat=100&ccb=1-7&_nc_sid=5f2048&_nc_ohc=im4NrlMRDwoAX906LIT&_nc_ht=scontent-sof1-1.xx&oh=00_AfANMiRCdEFjBHMKqzdVQ8CfmwHERZjyswaGHkTpw3deDw&oe=66139F73", 120.0, 0.0, "Златни рози" },
                    { 3, new DateTime(2024, 3, 28, 21, 23, 13, 688, DateTimeKind.Local).AddTicks(9487), "https://scontent-sof1-2.xx.fbcdn.net/v/t1.6435-9/118890298_3193596277433040_3828589938106568560_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=5f2048&_nc_ohc=dMYD1Y2twPAAX-5TIdq&_nc_oc=AQmB6ydQvkgot9gup32CReBa78Uc9nJ0lxvLge5csyOGMtoviBAviNqd5ot6C3mvjZ4&_nc_ht=scontent-sof1-2.xx&oh=00_AfCKvMW1pK86G0-3Uvc3A4efBy5a7ZXvntK3EIguunlpsg&oe=6613AE2C", 150.0, 0.0, "Съпруг и съпруга с червени рози и бели цветя" },
                    { 4, new DateTime(2024, 3, 28, 21, 23, 13, 688, DateTimeKind.Local).AddTicks(9490), "https://scontent.fsof10-1.fna.fbcdn.net/v/t31.18172-8/11940464_881502551975769_3150965239804644226_o.jpg?_nc_cat=111&ccb=1-7&_nc_sid=5f2048&_nc_ohc=lIiz0CvrQOAAX8yrHv6&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDS01MUNTFuECPkpvob8zZZXmMJKbYgvCTwQahwOQCQIg&oe=6620333B", 120.0, 0.0, "бели цветя" },
                    { 5, new DateTime(2024, 3, 28, 21, 23, 13, 688, DateTimeKind.Local).AddTicks(9492), "https://scontent.fsof10-1.fna.fbcdn.net/v/t1.6435-9/81678509_2608157715976902_8711874778027261952_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=5f2048&_nc_ohc=dn9ncHjKXt8AX8V4imn&_nc_oc=Adjiqz8TQNQuH0VsI2W2J8AQwDjcgr4XPGHPeTXPJ2qkeaZqY5bGxFIsMXkoAPWg4Jo&_nc_ht=scontent.fsof10-1.fna&oh=00_AfAjqqJ0cgKuP1WozZm7dEPBE_51dVR12bcJ2UmxChzeYg&oe=66201CA0", 110.0, 0.0, "бели цветя" },
                    { 6, new DateTime(2024, 3, 28, 21, 23, 13, 688, DateTimeKind.Local).AddTicks(9494), "https://scontent.fsof10-1.fna.fbcdn.net/v/t1.6435-9/127996258_3428591943933471_6613145035034934063_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=5f2048&_nc_ohc=rPtEwbVYSpsAX8PKZXU&_nc_ht=scontent.fsof10-1.fna&oh=00_AfD393zUJS7ZhFbPMSxqEvvGouqHlkLrInYKA97sq2Hdvg&oe=6624BF3F", 10.0, 0.0, "Коледни елхи" },
                    { 7, new DateTime(2024, 3, 28, 21, 23, 13, 688, DateTimeKind.Local).AddTicks(9497), "https://scontent.fsof10-1.fna.fbcdn.net/v/t1.18169-9/12301697_913490672110290_3131707004579174335_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=5f2048&_nc_ohc=ORKDJKSWeZoAX_k70au&_nc_ht=scontent.fsof10-1.fna&oh=00_AfCU2TCno1TEOAxjtlDR3eVOY3eJcWK_lWlPD7c2VyMphg&oe=6624A21A", 12.0, 0.0, "Коледни фигури" },
                    { 8, new DateTime(2024, 3, 28, 21, 23, 13, 688, DateTimeKind.Local).AddTicks(9499), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/346885612_1175653887168525_5354008429856402980_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=5f2048&_nc_ohc=hObhR06Be5kAX-tTgc6&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDokQeGR3jVPFokGOf4T-2ErzAqwXyrUMnNwn7NHqgQdw&oe=66025108", 15.0, 0.0, "Еднорог" },
                    { 9, new DateTime(2024, 3, 28, 21, 23, 13, 688, DateTimeKind.Local).AddTicks(9502), "https://scontent.fsof10-1.fna.fbcdn.net/v/t39.30808-6/429942016_1126158058806458_357351569670082917_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=5f2048&_nc_ohc=52_xuh-8AD8AX8IJkDL&_nc_ht=scontent.fsof10-1.fna&oh=00_AfC2GOft8pteFCSZoG6CAy8Ot_y5swfu7kOtrW4GqwPhkw&oe=6602E783", 13.0, 0.0, "Баба Марта" }
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
                    { 5, 1, "кръгла", 2, 30, 5 }
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
                name: "IX_Carts_CostumerId",
                table: "Carts",
                column: "CostumerId");

            migrationBuilder.CreateIndex(
                name: "IX_CartsProducts_ProductId",
                table: "CartsProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CostumerId",
                table: "Reviews",
                column: "CostumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");
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
                name: "CartsProducts");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "BiscuitCategories");

            migrationBuilder.DropTable(
                name: "CakeCategories");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
