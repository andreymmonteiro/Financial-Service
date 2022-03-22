using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Financial.Data.Migrations
{
    public partial class paymentTermsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentTerms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ForceExpiration = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    CompanyId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTerms", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PaymentTermsItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Days = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Addition = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PaymentTermsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CompanyId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreateAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTermsItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentTermsItems_PaymentTerms_PaymentTermsId",
                        column: x => x.PaymentTermsId,
                        principalTable: "PaymentTerms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "PaymentTerms",
                columns: new[] { "Id", "CompanyId", "CreateAt", "Description", "ForceExpiration", "UpdateAt" },
                values: new object[] { new Guid("659fea76-dc49-44eb-a907-cb5820f78762"), new Guid("8dc5eb0c-ed68-4b1e-b9fe-77e82efb1f31"), new DateTime(2022, 3, 21, 21, 3, 42, 64, DateTimeKind.Local).AddTicks(6041), "Á vista", 0, new DateTime(2022, 3, 21, 21, 3, 42, 65, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.InsertData(
                table: "PaymentTerms",
                columns: new[] { "Id", "CompanyId", "CreateAt", "Description", "ForceExpiration", "UpdateAt" },
                values: new object[] { new Guid("f3536b08-682b-4063-831f-68d9486517c1"), new Guid("8dc5eb0c-ed68-4b1e-b9fe-77e82efb1f31"), new DateTime(2022, 3, 21, 21, 3, 42, 66, DateTimeKind.Local).AddTicks(4171), "30 dias", 0, new DateTime(2022, 3, 21, 21, 3, 42, 66, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.InsertData(
                table: "PaymentTermsItems",
                columns: new[] { "Id", "Addition", "CompanyId", "CreateAt", "Days", "Discount", "PaymentTermsId", "UpdateAt" },
                values: new object[] { new Guid("b836bec6-79fc-4926-bd76-889b7c090977"), 0m, new Guid("8dc5eb0c-ed68-4b1e-b9fe-77e82efb1f31"), new DateTime(2022, 3, 21, 21, 3, 42, 66, DateTimeKind.Local).AddTicks(4608), 30, 0m, new Guid("f3536b08-682b-4063-831f-68d9486517c1"), new DateTime(2022, 3, 21, 21, 3, 42, 66, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTermsItems_PaymentTermsId",
                table: "PaymentTermsItems",
                column: "PaymentTermsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentTermsItems");

            migrationBuilder.DropTable(
                name: "PaymentTerms");
        }
    }
}
