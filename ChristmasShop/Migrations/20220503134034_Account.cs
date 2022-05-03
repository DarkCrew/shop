using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChristmasShop.Migrations
{
    public partial class Account : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Tree_TreeID",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Order_orderID",
                table: "OrderDetail");

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Password = table.Column<string>(nullable: true),
                    salt = table.Column<byte[]>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Unblocked = table.Column<bool>(nullable: false),
                    RoleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "admin" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "ID", "Name" },
                values: new object[] { 2, "user" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Email", "Password", "RoleId", "Unblocked", "salt" },
                values: new object[] { 1, "admin", "60Q8tiQFTYW0lTgCTcOLYw==", 1, true, new byte[] { 161, 106, 144, 182, 180, 100, 41, 60 } });

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Tree_TreeID",
                table: "OrderDetail",
                column: "TreeID",
                principalTable: "Tree",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Order_orderID",
                table: "OrderDetail",
                column: "orderID",
                principalTable: "Order",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Tree_TreeID",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Order_orderID",
                table: "OrderDetail");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Tree_TreeID",
                table: "OrderDetail",
                column: "TreeID",
                principalTable: "Tree",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Order_orderID",
                table: "OrderDetail",
                column: "orderID",
                principalTable: "Order",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
