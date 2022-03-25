using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Financial.Data.Migrations
{
    public partial class requiredInItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaymentTerms",
                keyColumn: "Id",
                keyValue: new Guid("ee811013-f73a-4ebd-b1c0-e63d0b9eeb24"));

            migrationBuilder.DeleteData(
                table: "PaymentTermsItems",
                keyColumn: "Id",
                keyValue: new Guid("90eb60cc-c92a-4c7b-b82b-6aa3a19e419d"));

            migrationBuilder.DeleteData(
                table: "PaymentTerms",
                keyColumn: "Id",
                keyValue: new Guid("39b595a5-f64e-4b2a-9775-f2ecb80d7ecd"));

            migrationBuilder.AddColumn<int>(
                name: "FinanceAccountType",
                table: "FinanceAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "PaymentTermsId",
                table: "FinanceAccounts",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "PersonId",
                table: "FinanceAccounts",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.InsertData(
                table: "PaymentTerms",
                columns: new[] { "Id", "CompanyId", "CreateAt", "Description", "ForceExpiration", "UpdateAt" },
                values: new object[] { new Guid("25546f86-48e6-403e-8a2b-95964ebfee96"), new Guid("291a4d21-6ab2-47f8-bb47-3ee84191ce5f"), new DateTime(2022, 3, 23, 11, 3, 12, 742, DateTimeKind.Local).AddTicks(7745), "Á vista", 0, new DateTime(2022, 3, 23, 11, 3, 12, 744, DateTimeKind.Local).AddTicks(1861) });

            migrationBuilder.InsertData(
                table: "PaymentTerms",
                columns: new[] { "Id", "CompanyId", "CreateAt", "Description", "ForceExpiration", "UpdateAt" },
                values: new object[] { new Guid("787f7283-3173-405b-abb6-b100347dec69"), new Guid("291a4d21-6ab2-47f8-bb47-3ee84191ce5f"), new DateTime(2022, 3, 23, 11, 3, 12, 745, DateTimeKind.Local).AddTicks(2168), "30 dias", 0, new DateTime(2022, 3, 23, 11, 3, 12, 745, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.InsertData(
                table: "PaymentTermsItems",
                columns: new[] { "Id", "Addition", "CompanyId", "CreateAt", "Days", "Discount", "PaymentTermsId", "UpdateAt" },
                values: new object[] { new Guid("7ce20fd9-11e3-4092-98fe-4b58d1acaaff"), 0m, new Guid("291a4d21-6ab2-47f8-bb47-3ee84191ce5f"), new DateTime(2022, 3, 23, 11, 3, 12, 745, DateTimeKind.Local).AddTicks(2757), 30, 0m, new Guid("787f7283-3173-405b-abb6-b100347dec69"), new DateTime(2022, 3, 23, 11, 3, 12, 745, DateTimeKind.Local).AddTicks(2761) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaymentTerms",
                keyColumn: "Id",
                keyValue: new Guid("25546f86-48e6-403e-8a2b-95964ebfee96"));

            migrationBuilder.DeleteData(
                table: "PaymentTermsItems",
                keyColumn: "Id",
                keyValue: new Guid("7ce20fd9-11e3-4092-98fe-4b58d1acaaff"));

            migrationBuilder.DeleteData(
                table: "PaymentTerms",
                keyColumn: "Id",
                keyValue: new Guid("787f7283-3173-405b-abb6-b100347dec69"));

            migrationBuilder.DropColumn(
                name: "FinanceAccountType",
                table: "FinanceAccounts");

            migrationBuilder.DropColumn(
                name: "PaymentTermsId",
                table: "FinanceAccounts");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "FinanceAccounts");

            migrationBuilder.InsertData(
                table: "PaymentTerms",
                columns: new[] { "Id", "CompanyId", "CreateAt", "Description", "ForceExpiration", "UpdateAt" },
                values: new object[] { new Guid("ee811013-f73a-4ebd-b1c0-e63d0b9eeb24"), new Guid("aa889dfd-e85c-4e0d-90cd-34e462afa4f1"), new DateTime(2022, 3, 22, 22, 45, 34, 551, DateTimeKind.Local).AddTicks(935), "Á vista", 0, new DateTime(2022, 3, 22, 22, 45, 34, 552, DateTimeKind.Local).AddTicks(5554) });

            migrationBuilder.InsertData(
                table: "PaymentTerms",
                columns: new[] { "Id", "CompanyId", "CreateAt", "Description", "ForceExpiration", "UpdateAt" },
                values: new object[] { new Guid("39b595a5-f64e-4b2a-9775-f2ecb80d7ecd"), new Guid("aa889dfd-e85c-4e0d-90cd-34e462afa4f1"), new DateTime(2022, 3, 22, 22, 45, 34, 553, DateTimeKind.Local).AddTicks(4974), "30 dias", 0, new DateTime(2022, 3, 22, 22, 45, 34, 553, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.InsertData(
                table: "PaymentTermsItems",
                columns: new[] { "Id", "Addition", "CompanyId", "CreateAt", "Days", "Discount", "PaymentTermsId", "UpdateAt" },
                values: new object[] { new Guid("90eb60cc-c92a-4c7b-b82b-6aa3a19e419d"), 0m, new Guid("aa889dfd-e85c-4e0d-90cd-34e462afa4f1"), new DateTime(2022, 3, 22, 22, 45, 34, 553, DateTimeKind.Local).AddTicks(5421), 30, 0m, new Guid("39b595a5-f64e-4b2a-9775-f2ecb80d7ecd"), new DateTime(2022, 3, 22, 22, 45, 34, 553, DateTimeKind.Local).AddTicks(5425) });
        }
    }
}
