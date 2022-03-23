using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Financial.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PaymentTerms",
                keyColumn: "Id",
                keyValue: new Guid("b57b2ff9-b04f-4aa2-aa52-d0d57d9cd4bc"));

            migrationBuilder.DeleteData(
                table: "PaymentTermsItems",
                keyColumn: "Id",
                keyValue: new Guid("eda34963-7132-4819-a900-552e202a8e03"));

            migrationBuilder.DeleteData(
                table: "PaymentTerms",
                keyColumn: "Id",
                keyValue: new Guid("e90cfbaf-e4c3-4c59-b16d-b113c056acb5"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("b57b2ff9-b04f-4aa2-aa52-d0d57d9cd4bc"), new Guid("6257e628-ad1c-4402-b8d6-7e234c276794"), new DateTime(2022, 3, 22, 21, 49, 29, 265, DateTimeKind.Local).AddTicks(7275), "Á vista", 0, new DateTime(2022, 3, 22, 21, 49, 29, 266, DateTimeKind.Local).AddTicks(5008) });

            migrationBuilder.InsertData(
                table: "PaymentTerms",
                columns: new[] { "Id", "CompanyId", "CreateAt", "Description", "ForceExpiration", "UpdateAt" },
                values: new object[] { new Guid("e90cfbaf-e4c3-4c59-b16d-b113c056acb5"), new Guid("6257e628-ad1c-4402-b8d6-7e234c276794"), new DateTime(2022, 3, 22, 21, 49, 29, 267, DateTimeKind.Local).AddTicks(4866), "30 dias", 0, new DateTime(2022, 3, 22, 21, 49, 29, 267, DateTimeKind.Local).AddTicks(4874) });

            migrationBuilder.InsertData(
                table: "PaymentTermsItems",
                columns: new[] { "Id", "Addition", "CompanyId", "CreateAt", "Days", "Discount", "PaymentTermsId", "UpdateAt" },
                values: new object[] { new Guid("eda34963-7132-4819-a900-552e202a8e03"), 0m, new Guid("6257e628-ad1c-4402-b8d6-7e234c276794"), new DateTime(2022, 3, 22, 21, 49, 29, 267, DateTimeKind.Local).AddTicks(5289), 30, 0m, new Guid("e90cfbaf-e4c3-4c59-b16d-b113c056acb5"), new DateTime(2022, 3, 22, 21, 49, 29, 267, DateTimeKind.Local).AddTicks(5294) });
        }
    }
}
