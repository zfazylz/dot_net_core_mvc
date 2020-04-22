using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PCShop.Migrations
{
    public partial class PCShopMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 25, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: false),
                    ZipCode = table.Column<string>(maxLength: 5, nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "Hardwares",
                columns: table => new
                {
                    HardwareId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    IsOnSale = table.Column<bool>(nullable: false),
                    IsInStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hardwares", x => x.HardwareId);
                    table.ForeignKey(
                        name: "FK_Hardwares_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    HardwareId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Hardwares_HardwareId",
                        column: x => x.HardwareId,
                        principalTable: "Hardwares",
                        principalColumn: "HardwareId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<string>(nullable: true),
                    HardwareId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Hardwares_HardwareId",
                        column: x => x.HardwareId,
                        principalTable: "Hardwares",
                        principalColumn: "HardwareId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, null, "CPU" },
                    { 2, null, "GPU" },
                    { 3, null, "RAM" },
                    { 4, null, "ROM" },
                    { 5, null, "Cases" }
                });

            migrationBuilder.InsertData(
                table: "Hardwares",
                columns: new[] { "HardwareId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Threads	- 20, CPU Series - Intel Core i9, Graphics integrated - no integerated GPU, CPU Cores - 10, CPU Speed - 3.70 GHz, L3 Cache - 19.25 MB", "\\Images\\thumbnails\\cpu1.jpg", "\\Images\\thumbnails\\cpu1.jpg", true, true, "Intel Core i9-10900X Tray", 990m },
                    { 2, 1, "High End Quad Core CPU, tray for Sockel 1150, 84 W TDP 4 Cores / 4 Threads, Intel® HD Graphics 4600 integrated Basistakt: 3.30 GHz, (up to 3.70 GHz) 6 MB L3 cache", "\\Images\\thumbnails\\cpu2.jpg", "\\Images\\thumbnails\\cpu2.jpg", true, true, "Intel Core I5-4590 4 core", 450m },
                    { 3, 1, "Enthusiast Quad Core CPU, Boxed (without heatsink) for Sockel 1151, 91 W TDP 4 Cores / 8 Threads, Intel® HD Graphics 530 integrated Basistakt: 4.00 GHz, (up to 4.20 GHz) 8 MB L3 cache, Unlocked multiplier", "\\Images\\thumbnails\\cpu3.jpg", "\\Images\\thumbnails\\cpu3.jpg", true, false, "Intel Core i7-6700K", 630m },
                    { 4, 2, "AMD Radeon™ RX 5700 XT 8.0 GB, 1840 MHz chip clock rate, 2035 MHz Boost, Connection via PCIe 4.0, Active Cooling (Tri-Slot), 2x HDMI, 2x DisplayPort, Crossfire", "\\Images\\thumbnails\\gpu1.jpg", "\\Images\\thumbnails\\gpu1.jpg", true, false, "Radeon RX 5700 8.0 GB", 750m },
                    { 5, 2, "NVIDIA® GeForce® RTX 2070 Super™ 8.0 GB, Overclocked, 1605 MHz chip clock rate, 1800 MHz Boost, Connection via 3.0, Active Cooling (Tri-Slot)", "\\Images\\thumbnails\\gpu2.jpg", "\\Images\\thumbnails\\gpu2.jpg", true, true, "GeForce RTX 2070  8.0 GB", 860m },
                    { 6, 2, "AMD Radeon™ RX 4000 XT 4.0 GB, Overclocked, 1605 MHz chip clock rate, 1905 MHz Boost, Connection via PCIe 4.0, Active Cooling (Dual-Slot) ", "\\Images\\thumbnails\\gpu3.jpg", "\\Images\\thumbnails\\gpu3.jpg", true, false, "Radeon RX 4000 4.0 GB", 320m },
                    { 7, 3, "16 GB RAM, 2x 8 GB Kit, DDR4, 3200 MHz (PC4-25600), DIMM 288 Pin, CL16", "\\Images\\thumbnails\\ram1.jpg", "\\Images\\thumbnails\\ram1.jpg", true, false, "Crucial Black 16GB", 210m },
                    { 8, 3, "16 GB RAM, 2x 8 GB Kit, DDR4, 3200 MHz (PC4-25600), DIMM 288 Pin, CL1616 GB RAM, 2x 8 GB Kit, DDR4, 3200 MHz (PC4-25600), DIMM 288 Pin, CL16", "\\Images\\thumbnails\\ram2.jpg", "\\Images\\thumbnails\\ram2.jpg", true, false, "G.Skill Aegis 16GB", 150m },
                    { 9, 3, "4 GB RAM, 2x 2 GB Kit, DDR3, 1333 MHz (PC3-10600), DIMM 240 Pin, CL9", "\\Images\\thumbnails\\ram3.jpg", "\\Images\\thumbnails\\ram3.jpg", true, false, "Corsair XMS3 RAM 4GB", 110m },
                    { 10, 4, "1.0 TB SSD, Connection via PCI Express x4 (NVMe), Form factor M.2 (2280), Write speed up to 3300 MB/s, up to 3500 MB/s", "\\Images\\thumbnails\\rom1.jpg", "\\Images\\thumbnails\\rom1.jpg", true, false, "Samsung SSD 970 1TB", 420m },
                    { 11, 4, "480 GB SSD, Connection via SATA3, Form factor 2.5, Installationa height 7 mm, Write speed up to 410 MB/s, upp to 500 MB/s", "\\Images\\thumbnails\\rom2.jpg", "\\Images\\thumbnails\\rom2.jpg", true, false, "Intel SSD S3500 480GB", 375m },
                    { 12, 4, "240 GB SSD, Connection via SATA3, Form factor 2.5, Installation height 7 mm, Write speed up to 450 MB/s, up to 520 MB/s", "\\Images\\thumbnails\\rom3.jpg", "\\Images\\thumbnails\\rom3.jpg", true, false, "ADATA SU630 SDD 240GB", 230m },
                    { 13, 5, "Midi-Tower (sound dampened), supports ATX, mATX Boards, Internal: 8x 2.5, 3x 3.5, External: 2x 5.25, 1x 140 mm fan, 1x 120 mm fan, 2x USB3.1 Gen 1", "\\Images\\thumbnails\\case1.jpg", "\\Images\\thumbnails\\case1.jpg", true, false, "Pure Base 600 Midi-Tower", 110m },
                    { 14, 5, "Mini ITX Gehäuse, supports mini-ITX Boards, Internal: 4x 2.5, 1x 3.5", "\\Images\\thumbnails\\case2.jpg", "\\Images\\thumbnails\\case2.jpg", true, false, "Cooler Master Mastercase H100", 225m },
                    { 15, 5, "Midi-Tower mit plasticfenster, supports ATX Boards, Internal: 3x 2.5, 2x 3.5, 2x 120 mm fan", "\\Images\\thumbnails\\case3.jpg", "\\Images\\thumbnails\\case3.jpg", true, false, "GIGABYTE GB-AC300G", 350m }
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
                name: "IX_Hardwares_CategoryId",
                table: "Hardwares",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_HardwareId",
                table: "OrderDetails",
                column: "HardwareId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_HardwareId",
                table: "ShoppingCartItems",
                column: "HardwareId");
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
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Hardwares");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
