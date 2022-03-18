using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Financial.Data.Migrations
{
    public partial class mySql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FinanceAccount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    FinanceAccountType = table.Column<int>(type: "int", nullable: false),
                    PaymentTermsId = table.Column<int>(type: "int", nullable: false),
                    FinanceAccountItemId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceAccount", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FinanceAccount");
        }
    }
}
